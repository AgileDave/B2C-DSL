using agileways.b2c.builder;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.library.common.techProfiles;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.techProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agileway.b2c.console
{
    public class TermsOfServiceSignUpOrSignIn : Policy
    {
        const string CURRENT_TOS_VERSION = "1.0";

        public TermsOfServiceSignUpOrSignIn(string policyName, TrustFrameworkPolicy tfpBase) : base(policyName, tfpBase) => this.Build();
        //public TermsOfServiceSignUpOrSignIn(string policyName, TrustFrameworkPolicy tfpBase) : base(policyName, tfpBase) => this.Build();

        public override void Build()
        {
            // Claims
            ClaimType agreedToToS = ClaimBuilder.AsString
                .WithId("AgreedToTermsOfService")
                .WithDisplayName("Agreed To Terms Of Service")
                .DisplayClaimAsMultiSelectCheckbox()
                .RestrictWith(new Restriction
                {
                    Items = new List<object> {
                        new EnumerationItem { Text = "", Value = CURRENT_TOS_VERSION}
                    }
                });

            ClaimType persistedToS = ClaimBuilder.AsString
                .WithId("extension_AgreedToTermsOfService")
                .WithDisplayName("This is the current business Terms of Service version")
                .AddAdminHelpText("This is the current business Terms of Service version");

            ClaimType currentToS = ClaimBuilder.AsString
                .WithId("policyTOSversion")
                .WithDisplayName("This is the current business Terms of Service version")
                .AddAdminHelpText("This is the current business Terms of Service version");

            ClaimType isTosRenewalNeeded = ClaimBuilder.AsBool
                .WithId("renewalTOSrequired")
                .WithDisplayName("This variable states whether TOS requires to be renewed")
                .AddAdminHelpText("This variable states whether TOS requires to be renewed");

            // Claims transformation
            ClaimsTransformation isToSRenewalNeededTransform = TransformationBuilder.Init("IsTermsOfServiceRequired", "CompareClaims")
                .AcceptingClaim(currentToS, "inputClaim1")
                .AcceptingClaim(persistedToS, "inputClaim2")
                .AcceptingParameter("operator", DataType.@string, "NOT EQUAL")
                .AcceptingParameter("ignoreCase", DataType.@string, "true")
                .ReturnsClaim(isTosRenewalNeeded, "outputClaim");

            ClaimsTransformation assertToSSelectedTransform = TransformationBuilder.Init("AssertTOSHasBeenSelected", "AssertStringClaimsAreEqual")
                .AcceptingClaim(agreedToToS, "inputClaim1")
                .AcceptingClaim(currentToS, "inputClaim2")
                .AcceptingParameter("stringComparison", DataType.@string, "ordinalIgnoreCase");

            // Technical profiles
            TechnicalProfile tpLocalAccountSignUpWithLogonEmail = TechnicalProfileBuilder.Init("LocalAccountSignUpWithLogonEmail")
                .ReturnsClaim(agreedToToS, required: true)
                .ReturnsClaim(isTosRenewalNeeded, defaultValue: "false");

            TechnicalProfile tpAAD_UserWriteUsingLogonEmail = TechnicalProfileBuilder.Init("AAD-UserWriteUsingLogonEmail")
                .PersistsClaim(agreedToToS, persistedToS.Id);


            TechnicalProfile tpAAD_ReadTOS = TechnicalProfileBuilder.Init("AAD-ReadTOS")
                .AddMetadata("Operation", "Read")
                .AddMetadata("RaiseErrorIfClaimsPrincipalDoesNotExist", "true")
                .ParticipatesInSso(false)
                .AcceptsClaim(BaseClaims.ObjectId, required: true)
                .ReturnsClaim(persistedToS);
            tpAAD_ReadTOS.IncludeTechnicalProfile = new IncludeTechnicalProfile
            {
                ReferenceId = "AAD-Common"
            };

            TechnicalProfile tpSelfAsserted_LocalAccountSignin_Email =
                TechnicalProfileBuilder.Init("SelfAsserted-LocalAccountSignin-Email")
                    .AddMetadata("SignUpTarget", "SignUpWithLogonEmailExchange")
                    .AddMetadata("setting.operatingMode", "Email")
                    .AddMetadata("ContentDefinitionReferenceId", BaseContentDefinitions.ApiSelfAsserted.Id)
                    .AcceptsClaim(BaseClaims.SignInName)
                    .AcceptsClaim(currentToS, defaultValue: CURRENT_TOS_VERSION)
                    .ReturnsClaim(currentToS, defaultValue: CURRENT_TOS_VERSION)
                    .ReturnsClaim(BaseClaims.SignInName, required: true)
                    .ReturnsClaim(BaseClaims.Password, required: true)
                    .ReturnsClaim(BaseClaims.ObjectId)
                    .ReturnsClaim(BaseClaims.AuthenticationSource)
                    .ReturnsClaim(persistedToS)
                    .ParticipatesInSso(false)
                    .UsingOutputClaimsTransform(isToSRenewalNeededTransform)
                    .UsingSessionManagementProfile(BaseSessionMgtTechnicalProfiles.Aad);
            tpSelfAsserted_LocalAccountSignin_Email.DisplayName = "Local Account Signin";
            tpSelfAsserted_LocalAccountSignin_Email.Protocol = new TechnicalProfileProtocol
            {
                Name = ProtocolName.Proprietary,
                Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            };
            tpSelfAsserted_LocalAccountSignin_Email.ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                new ValidationTechnicalProfile { ReferenceId = "login-NonInteractive"},
                new ValidationTechnicalProfile { ReferenceId = tpAAD_ReadTOS.Id }
            };


            TechnicalProfile tpVerfiyTOSConsentedTo = TechnicalProfileBuilder.Init("VerfiyTOSConsentedTo")
                .ReturnsClaim(persistedToS)
                .UsingOutputClaimsTransform(assertToSSelectedTransform);
            tpVerfiyTOSConsentedTo.DisplayName = "Verifies TOS has been Accepted";
            tpVerfiyTOSConsentedTo.Protocol = new TechnicalProfileProtocol
            {
                Name = ProtocolName.Proprietary,
                Handler = "Web.TPEngine.Providers.ClaimsTransformationProtocolProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            };

            TechnicalProfile tpAAD_UserWriteProfileUsingObjectIdUpdateTOU = TechnicalProfileBuilder.Init("AAD-UserWriteProfileUsingObjectIdUpdateTOU")
                .AddMetadata("Operation", "Write")
                .AddMetadata("RaiseErrorIfClaimsPrincipalAlreadyExists", "false")
                .AddMetadata("RaiseErrorIfClaimsPrincipalDoesNotExist", "true")
                .AcceptsClaim(BaseClaims.ObjectId, required: true)
                .ParticipatesInSso(false)
                .PersistsClaim(BaseClaims.ObjectId)
                .PersistsClaim(agreedToToS, persistedToS.Id);
            tpAAD_UserWriteProfileUsingObjectIdUpdateTOU.IncludeTechnicalProfile = new IncludeTechnicalProfile
            {
                ReferenceId = "AAD-Common"
            };

            TechnicalProfile tpCheckTOSrequirement = TechnicalProfileBuilder.Init("CheckTOSrequirement")
                .AcceptsClaim(currentToS, required: true)
                .AcceptsClaim(persistedToS, required: true)
                .ReturnsClaim(isTosRenewalNeeded)
                .ReturnsClaim(currentToS)
                .ReturnsClaim(persistedToS)
                .UsingOutputClaimsTransform(isToSRenewalNeededTransform);
            tpCheckTOSrequirement.DisplayName = "Check TOS Requirement";
            tpCheckTOSrequirement.Protocol = new TechnicalProfileProtocol
            {
                Name = ProtocolName.Proprietary,
                Handler = "Web.TPEngine.Providers.ClaimsTransformationProtocolProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            };


            TechnicalProfile tpSelfAsserted_RefreshTOS = TechnicalProfileBuilder.Init("SelfAsserted-RefreshTOS")
                .AddMetadata("ContentDefinitionReferenceId", BaseContentDefinitions.ApiSelfAsserted.Id)
                .AddMetadata("UserMessageIfClaimsTransformationStringsAreNotEqual", "You need to accept the TOS")
                .ParticipatesInSso(false)
                .AcceptsClaim(agreedToToS)
                .ReturnsClaim(agreedToToS);
            tpSelfAsserted_RefreshTOS.DisplayName = "Terms And Use Update";
            tpSelfAsserted_RefreshTOS.Protocol = new TechnicalProfileProtocol
            {
                Name = ProtocolName.Proprietary,
                Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            };
            tpSelfAsserted_RefreshTOS.ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                new ValidationTechnicalProfile { ReferenceId = tpVerfiyTOSConsentedTo.Id },
                new ValidationTechnicalProfile { ReferenceId = tpAAD_UserWriteProfileUsingObjectIdUpdateTOU.Id }
            };

            // User Journeys
            UserJourney susiJourney = UserJourneyBuilder.Init("TermsOfServiceSignUpOrSignIn")
                .AddOrchestrationStep(
                    OrchestrationStepBuilder.AsCombinedSignInSignUp
                        .UsingContentDefinition(BaseContentDefinitions.ApiSignUpOrSignIn)
                        .AddClaimsProviderSelection(validationClaimsExchangeId: "LocalAccountSigninEmailExchange")
                        .AddClaimsExchange("LocalAccountSigninEmailExchange", tpSelfAsserted_LocalAccountSignin_Email))
                .AddOrchestrationStep(
                    OrchestrationStepBuilder.AsClaimsExchange
                        .WithClaimsExistsPrecondition(BaseClaims.ObjectId)
                        .AddClaimsExchange("SignUpWithLogonEmailExchange", tpLocalAccountSignUpWithLogonEmail))
                .AddOrchestrationStep(
                    OrchestrationStepBuilder.AsClaimsExchange
                        .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId))
                .AddOrchestrationStep(
                    OrchestrationStepBuilder.AsClaimsExchange
                        .WithClaimsEqualsPrecondition(isTosRenewalNeeded, "False")
                        .AddClaimsExchange("RefreshTOS", tpSelfAsserted_RefreshTOS))
                .AddOrchestrationStep(
                    OrchestrationStepBuilder.AsClaimsExchange
                        .AddClaimsExchange("AAD-ReadTOS", tpAAD_ReadTOS))
                .AddOrchestrationStep(OrchestrationStepBuilder.AsJwtIssuer)
                .UsingDefaultWebClientDefinition();

            // Relying Party
            RelyingParty rp = RelyingPartyBuilder.Init("TermsOfServiceSignUpOrSignIn")
                        .SetTechnicalProfile(
                            TechnicalProfileBuilder.Init("PolicyProfile", "PolicyProfile", ProtocolName.OpenIdConnect)
                                .ReturnsClaim(BaseClaims.DisplayName)
                                .ReturnsClaim(BaseClaims.GivenName)
                                .ReturnsClaim(BaseClaims.Surname)
                                .ReturnsClaim(BaseClaims.Email)
                                .ReturnsClaim(BaseClaims.ObjectId, "sub")
                                .ReturnsClaim(BaseClaims.TenantId, alwaysUseDefaultValue: true, defaultValue: "{Policy:TenantObjectId}")
                                .ReturnsClaim(persistedToS)
                                .ReturnsClaim(isTosRenewalNeeded)
                                .ReturnsClaim(currentToS)
                                .SetSubjectNaming(BaseClaims.Subject.Id)
                        );

            // Bringing It All Together
            ThePolicy.SetBuildingBlocks(
                        BuildingBlockBuilder.Init()
                        .AddClaims(agreedToToS, persistedToS, currentToS, isTosRenewalNeeded)
                        .AddClaimsTransformations(isToSRenewalNeededTransform, assertToSSelectedTransform))
                    .SetClaimsProviders(
                        ClaimsProviderBuilder.Init("Local Account SignIn")
                            .AddTechnicalProfile(tpLocalAccountSignUpWithLogonEmail)
                            .AddTechnicalProfile(tpAAD_UserWriteUsingLogonEmail)
                            .AddTechnicalProfile(tpSelfAsserted_LocalAccountSignin_Email)
                            .AddTechnicalProfile(tpAAD_ReadTOS),
                        ClaimsProviderBuilder.Init("Self Asserted Terms And Use Refresh if Not Valid")
                            .AddTechnicalProfile(tpSelfAsserted_RefreshTOS),
                        ClaimsProviderBuilder.Init("Write Updated Terms of Service")
                            .AddTechnicalProfile(tpVerfiyTOSConsentedTo)
                            .AddTechnicalProfile(tpAAD_UserWriteProfileUsingObjectIdUpdateTOU)
                            .AddTechnicalProfile(tpCheckTOSrequirement))
                    .SetUserJourneys(susiJourney)
                    .SetRelyingParty(rp);
        }

    }
}
