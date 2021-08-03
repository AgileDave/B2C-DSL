
using System.Collections.Generic;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.claimsProviders;
using agileways.b2c.builder.library.common.clientDefinitions;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.library.common.journeys;
using agileways.b2c.builder.library.common.relyingParties;
using agileways.b2c.builder.library.common.transformations;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.content;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.library.policies
{

    public static class SocialAndLocalAccounts
    {

        public static TrustFrameworkPolicy TrustFrameworkBase(string policyName, string tenantName, params Contact[] contacts)
        {
            return PolicyBuilder.Init(policyName, $"http://{tenantName}/{policyName}", tenantName)
                                    .AddContacts(contacts)
                                    .SetBuildingBlocks(new BuildingBlocks
                                    {
                                        ClaimsSchema = new List<ClaimType> {
                                            BaseClaims.AccountEnabled,
                                            BaseClaims.AlternativeSecurityId,
                                            BaseClaims.AuthenticationSource,
                                            BaseClaims.ClientId,
                                            BaseClaims.DisplayName,
                                            BaseClaims.Email,
                                            BaseClaims.ExecutedSelfAssertedInput,
                                            BaseClaims.GivenName,
                                            BaseClaims.GrantType,
                                            BaseClaims.IdentityProvider,
                                            BaseClaims.IsActiveMFASession,
                                            BaseClaims.IssuerUserId,
                                            BaseClaims.MailNickName,
                                            BaseClaims.Nca,
                                            BaseClaims.NewUser,
                                            BaseClaims.ObjectId,
                                            BaseClaims.ObjectIdFromSession,
                                            BaseClaims.OtherMails,
                                            BaseClaims.Password,
                                            BaseClaims.PasswordPolicies,
                                            BaseClaims.NewPassword,
                                            BaseClaims.ReenterPassword,
                                            BaseClaims.ResourceId,
                                            BaseClaims.Scope,
                                            BaseClaims.SignInName,
                                            BaseClaims.SignInNamesEmailAddress,
                                            BaseClaims.Subject,
                                            BaseClaims.Surname,
                                            BaseClaims.TenantId,
                                            BaseClaims.UpnUserName,
                                            BaseClaims.UserPrincipalName
                                        },
                                        ClaimsTransformations = new List<ClaimsTransformation> {
                                            BaseTransforms.AssertAccountEnabledIsTrue,
                                            BaseTransforms.CreateAlternativeSecurityId,
                                            BaseTransforms.CreateOtherMailsFromEmail,
                                            BaseTransforms.CreateRandomUPNUserName,
                                            BaseTransforms.CreateSubjectClaimFromAlternativeSecurityId,
                                            BaseTransforms.CreateUserPrincipalName
                                        },
                                        ClientDefinitions = new List<ClientDefinition> {
                                            BaseClientDefinitions.DefaultWeb
                                        },
                                        ContentDefinitions = new List<ContentDefinition> {
                                            BaseContentDefinitions.ApiError,
                                            BaseContentDefinitions.ApiIdpSelections,
                                            BaseContentDefinitions.ApiIdpSelectionsSignUp,
                                            BaseContentDefinitions.ApiLocalAccountPasswordReset,
                                            BaseContentDefinitions.ApiLocalAccountSignUp,
                                            BaseContentDefinitions.ApiSelfAsserted,
                                            BaseContentDefinitions.ApiSelfAssertedProfileUpdate,
                                            BaseContentDefinitions.ApiSignUpOrSignIn
                                        }
                                    })
                                    .SetClaimsProviders(
                                        BaseClaimsProviders.LocalAccountSignin,
                                        BaseClaimsProviders.AzureActiveDirectory,
                                        BaseClaimsProviders.SelfAsserted,
                                        BaseClaimsProviders.LocalAccount,
                                        BaseClaimsProviders.SessionManagement,
                                        BaseClaimsProviders.TPEngine,
                                        BaseClaimsProviders.TokenIssuer
                                    );
        }

        public static TrustFrameworkPolicy TrustFrameworkExtensions(string policyName, TrustFrameworkPolicy basePolicy, string proxyIefAppId,
                                                                    string iefAppId, string extensionAppId, string extensionAppObjectId)
        {
            return PolicyBuilder.Init(policyName, $"http://{basePolicy.TenantId}/{policyName}", basePolicy.TenantId)
                                .InheritFrom(basePolicy)
                                .SetClaimsProviders(ClaimsProviderBuilder.Init("Local Account SignIn", "")
                                                    .AddTechnicalProfile(TechnicalProfileBuilder.Init("login-NonInteractive")
                                                                            .AddMetadata("client_id", proxyIefAppId)
                                                                            .AddMetadata("IdTokenAudience", iefAppId)
                                                                            .AcceptsClaim(BaseClaims.ClientId, defaultValue: proxyIefAppId)
                                                                            .AcceptsClaim(BaseClaims.ResourceId, "resource", defaultValue: iefAppId)),
                                                    ClaimsProviderBuilder.Init("Azure Active Directory", "")
                                                    .AddTechnicalProfile(TechnicalProfileBuilder.Init("AAD-Common")
                                                                            .AddMetadata("ClientId", extensionAppId)
                                                                            .AddMetadata("ApplicationObjectId", extensionAppObjectId))
                                );

        }

        public static TrustFrameworkPolicy UserJourneys(string policyName, TrustFrameworkPolicy basePolicy)
        {
            return PolicyBuilder.Init(policyName, $"http://{basePolicy.TenantId}/{policyName}", basePolicy.TenantId)
                                    .InheritFrom(basePolicy)
                                    .SetUserJourneys(BaseSocialAndLocalJourneys.Susi,
                                                    BaseSocialAndLocalJourneys.ProfileEdit,
                                                    BaseSocialAndLocalJourneys.PasswordReset);

        }

        public static TrustFrameworkPolicy RelyingPartySusi(string policyName, TrustFrameworkPolicy basePolicy)
        {
            return PolicyBuilder.Init(policyName, $"http://{basePolicy.TenantId}/{policyName}", basePolicy.TenantId)
                                .InheritFrom(basePolicy)
                                .SetRelyingParty(BaseLocalAndSocialRelyingParty.Susi);
        }

        public static TrustFrameworkPolicy RelyingPartyProfileEdit(string policyName, TrustFrameworkPolicy basePolicy)
        {
            return PolicyBuilder.Init(policyName, $"http://{basePolicy.TenantId}/{policyName}", basePolicy.TenantId)
                                .InheritFrom(basePolicy)
                                .SetRelyingParty(BaseLocalAndSocialRelyingParty.ProfileEdit);
        }

        public static TrustFrameworkPolicy RelyingPartyPasswordReset(string policyName, TrustFrameworkPolicy basePolicy)
        {
            return PolicyBuilder.Init(policyName, $"http://{basePolicy.TenantId}/{policyName}", basePolicy.TenantId)
                                .InheritFrom(basePolicy)
                                .SetRelyingParty(BaseLocalAndSocialRelyingParty.PasswordReset);
        }
    }
}