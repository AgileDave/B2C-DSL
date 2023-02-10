
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.common;
using System.Collections.Generic;
using agileways.b2c.builder.models.transform;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.techProfile;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.transformations;
using agileways.b2c.builder.library.common.techProfiles;
using agileways.b2c.builder.library.common.clientDefinitions;
using agileways.b2c.builder.models.journey;
using agileways.b2c.builder.library.common.contentDefinitions;
using System.Xml.Serialization;

namespace agileways.b2c.builder.runner.Samples
{
    public class CommonEndpoint : Policy
    {
        public string CommonEndpointSignUpOrSignIn { get => "CommonEndpointSignUpOrSignIn"; }
        public ClaimType Groups { get; private set; }
        public ClaimType Role { get; private set; }
        public ClaimType LoginHint { get; private set; }
        public ClaimType IpAddress { get; private set; }

        public CommonEndpoint(string policyName, TrustFrameworkPolicy basePolicy) : base(policyName, basePolicy) => this.Build();
        public override void Build()
        {
            IpAddress = ClaimBuilder.AsString
                        .WithId("CR-IP-Address")
                        .WithDisplayName("ip address")
                        .WithUserHelpText("users current logon ip address from claims resolver");

            Groups = ClaimBuilder.AsStringCollection
                                        .WithId("groups")
                                        .WithDisplayName("User Groups")
                                        .WithUserHelpText("The groups a user has for this application");

            LoginHint = ClaimBuilder.AsString
                                        .WithId("login_hint")
                                        .WithDisplayName("Login Hint for AAD");

            Role = ClaimBuilder.AsStringCollection
                                        .WithId("role")
                                        .WithDisplayName("Extension attribute for role from AAD");
            var loginHintTransform = LoginHintTransform(LoginHint);
            var oidcTechProfile = AadCommon_OpenIdConnect(LoginHint, Groups, Role, loginHintTransform);
            var susiJourney = Susi(oidcTechProfile);
            var selfAssertedLocalAccountSigninWithEmail =
                    SelfAsserted_LocalAccountSignin_Email_That_Returns_IPAddress(IpAddress);

            ThePolicy.SetBuildingBlocks(BuildingBlockBuilder.Init()
                                        .AddClaimType(Groups)
                                        .AddClaimType(LoginHint)
                                        .AddClaimType(Role)
                                        .AddClaimType(IpAddress)
                                        .AddClaimsTransformation(loginHintTransform));
            ThePolicy.SetClaimsProviders(ClaimsProviderBuilder.Init("Common AAD", "microsoftonline.com")
                                    .AddTechnicalProfile(oidcTechProfile)
                                    .AddTechnicalProfile(selfAssertedLocalAccountSigninWithEmail));

            ThePolicy.SetUserJourneys(susiJourney);
        }

        private ClaimsTransformation LoginHintTransform(ClaimType loginHint)
        {
            return TransformationBuilder.Init("CreateLoginHintClaim", "CreateStringClaim")
                    .AcceptingParameter("value", DataType.@string, "{OAUTH-KV:lh}")
                    .ReturnsClaim(loginHint, "createdClaim");
        }

        private TechnicalProfile SelfAsserted_LocalAccountSignin_Email_That_Returns_IPAddress(ClaimType ipAddress)
        {
            return TechnicalProfileBuilder.Init("SelfAsserted-LocalAccountSignin-Email")
                    .AddMetadata(TechProfileMetadata.IncludeClaimResolvingInClaimsHandling, "true")
                    .ReturnsClaim(ipAddress, defaultValue: "{Context:IPAddress}", alwaysUseDefaultValue: true);
        }

        private TechnicalProfile AadCommon_OpenIdConnect(ClaimType loginHint, ClaimType groups, ClaimType role, ClaimsTransformation loginHintTransform)
        {
            return TechnicalProfileBuilder.Init("AADCommon-OpenIdConnect", "Microsoft AAD Login", ProtocolName.OpenIdConnect, "Login with your Contoso account")
                .AddMetadata(TechProfileMetadata.METADATA, "https://login.microsoftonline.com/common/v2.0/.well-known/openid-configuration")
                .AddMetadata(TechProfileMetadata.client_id, "9bb42244-a0ca-499f-afe0-1428718c9594")
                .AddMetadata(TechProfileMetadata.response_types, "code")
                .AddMetadata(TechProfileMetadata.scope, "openid profile")
                .AddMetadata(TechProfileMetadata.HttpBinding, "POST")
                .AddMetadata(TechProfileMetadata.UserPolicyInRedirectUri, "false")
                .AddMetadata(TechProfileMetadata.DiscoverMetadataByTokenIssuer, "true")
                .AddMetadata(TechProfileMetadata.ValidTokenIssuerPrefixes, "https://login.microsoftonline.com/")
                .AddMetadata(TechProfileMetadata.IncludeClaimResolvingInClaimsHandling, "true")

                .AcceptsClaim(loginHint)

                .ReturnsClaim(BaseClaims.IssuerUserId, "oid")
                .ReturnsClaim(BaseClaims.TenantId, "tid")
                .ReturnsClaim(BaseClaims.GivenName, "given_name")
                .ReturnsClaim(BaseClaims.Surname, "family_name")
                .ReturnsClaim(BaseClaims.DisplayName, "name")
                .ReturnsClaim(BaseClaims.AuthenticationSource, defaultValue: "socialIdpAuthentication", alwaysUseDefaultValue: true)
                .ReturnsClaim(BaseClaims.IdentityProvider, "iss")
                .ReturnsClaim(groups, "groups")
                .ReturnsClaim(role, "extn.role")
                .ReturnsClaim(IpAddress, defaultValue: "{Context:IPAddress}", alwaysUseDefaultValue: true)

                .AddCryptographicKey("client_secret", "B2C_1A_AADAppSecret")

                .UsingInputClaimsTransform(loginHintTransform)

                .UsingOutputClaimsTransform(BaseTransforms.CreateRandomUPNUserName)
                .UsingOutputClaimsTransform(BaseTransforms.CreateUserPrincipalName)
                .UsingOutputClaimsTransform(BaseTransforms.CreateAlternativeSecurityId)
                .UsingOutputClaimsTransform(BaseTransforms.CreateSubjectClaimFromAlternativeSecurityId)

                .UsingSessionManagementProfile(BaseSessionMgtTechnicalProfiles.SocialLogin);
        }

        private UserJourney Susi(TechnicalProfile oidcCommon)
        {
            return UserJourneyBuilder.Init(CommonEndpointSignUpOrSignIn)
                                .UsingDefaultWebClientDefinition()
                                .AddOrchestrationStep(
                                    OrchestrationStepBuilder.AsCombinedSignInSignUp
                                        .UsingContentDefinition(BaseContentDefinitions.ApiSignUpOrSignIn)
                                        .AddClaimsProviderSelection(validationClaimsExchangeId: "LocalAccountSigninEmailExchange")
                                        .AddClaimsProviderSelection(targetClaimsExchangeId: "AzureADCommonExchange")
                                        .AddClaimsExchange("LocalAccountSigninEmailExchange", BaseLocalAccountTechnicalProfiles.SelfAssertedLocalAccountSigninEmail))
                                .AddOrchestrationStep(
                                    OrchestrationStepBuilder.AsClaimsExchange
                                        .WithClaimsExistsPrecondition(BaseClaims.ObjectId)
                                        .AddClaimsExchange("SignUpWithLogonEmailExchange", BaseLocalAccountTechnicalProfiles.LocalAccountSignUpWithLogonEmail)
                                        .AddClaimsExchange("AzureADCommonExchange", oidcCommon))
                                .AddOrchestrationStep(
                                    OrchestrationStepBuilder.AsClaimsExchange
                                        .WithClaimsEqualsPrecondition(BaseClaims.AuthenticationSource, "localAccountAuthentication")
                                        .AddClaimsExchange("AADUserReadUsingAlternativeSecurityId", BaseAadTechnicalProfiles.AadUserReadUsingAlternativeSecurityIdNoError))
                                .AddOrchestrationStep(
                                    OrchestrationStepBuilder.AsClaimsExchange
                                        .WithClaimsExistsPrecondition(BaseClaims.ObjectId)
                                        .AddClaimsExchange("SelfAsserted-Social", BaseSelfAssertedTechnicalProfiles.SelfAssertedSocial))
                                .AddOrchestrationStep(
                                    OrchestrationStepBuilder.AsClaimsExchange
                                        .WithClaimsEqualsPrecondition(BaseClaims.AuthenticationSource, "socialIdpAuthentication")
                                        .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId))
                                .AddOrchestrationStep(
                                    OrchestrationStepBuilder.AsClaimsExchange
                                        .WithClaimsExistsPrecondition(BaseClaims.ObjectId)
                                        .AddClaimsExchange("AADUserWrite", BaseAadTechnicalProfiles.AadUserWriteUsingAlternativeSecurityId))
                                .AddOrchestrationStep(OrchestrationStepBuilder.AsJwtIssuer);
        }
    }
}