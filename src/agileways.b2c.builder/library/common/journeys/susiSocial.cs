using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.library.common.techProfiles;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.library.common.journeys
{
    public static class BaseSocialAndLocalJourneys
    {
        public static UserJourney Susi
        {
            get => UserJourneyBuilder.Init("SignUpOrSignIn")
                        .UsingDefaultWebClientDefinition()
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsCombinedSignInSignUp
                                .UsingContentDefinition(BaseContentDefinitions.ApiSignUpOrSignIn)
                                .AddClaimsProviderSelection("LocalAccountSigninEmailExchange")
                                .AddClaimsExchange("LocalAccountSigninEmailExchange", BaseLocalAccountTechnicalProfiles.SelfAssertedLocalAccountSigninEmail))
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsClaimsExchange
                                .WithClaimsExistsPrecondition(BaseClaims.ObjectId)
                                .AddClaimsExchange("SignUpWithLogonEmailExchange", BaseLocalAccountTechnicalProfiles.LocalAccountSignUpWithLogonEmail))
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsClaimsExchange
                                .WithClaimsEqualsPrecondition(BaseClaims.AuthenticationSource, "socialIdpAuthentication")
                                .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId))
                        .AddOrchestrationStep(OrchestrationStepBuilder.AsJwtIssuer);
        }

        public static UserJourney ProfileEdit
        {
            get => UserJourneyBuilder.Init("ProfileEdit")
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsCombinedSignInSignUp
                                .UsingContentDefinition(BaseContentDefinitions.ApiIdpSelections)
                                .AddClaimsProviderSelection("LocalAccountSigninEmailExchange"))
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsClaimsExchange
                                .AddClaimsExchange("LocalAccountSigninEmailExchange", BaseLocalAccountTechnicalProfiles.SelfAssertedLocalAccountSigninEmail))
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsClaimsExchange
                                .WithClaimsEqualsPrecondition(BaseClaims.AuthenticationSource, "localAccountAuthentication")
                                .AddClaimsExchange("AADUserRead", BaseAadTechnicalProfiles.AadUserReadUsingAlternativeSecurityId))
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsClaimsExchange
                                .WithClaimsEqualsPrecondition(BaseClaims.AuthenticationSource, "socialIdpAuthentication")
                                .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId))
                        .AddOrchestrationStep(
                            OrchestrationStepBuilder.AsClaimsExchange
                                .AddClaimsExchange("B2CUserProfileUpdateExchange", BaseSelfAssertedTechnicalProfiles.SelfAssertedProfileUpdate))
                        .AddOrchestrationStep(OrchestrationStepBuilder.AsJwtIssuer)
                        .UsingDefaultWebClientDefinition();
        }

        public static UserJourney PasswordReset
        {
            get => UserJourneyBuilder.Init("PasswordReset")
                    .AddOrchestrationStep(
                        OrchestrationStepBuilder.AsClaimsExchange
                            .AddClaimsExchange("PasswordResetUsingEmailAddressExchange", BaseLocalAccountTechnicalProfiles.LocalAccountDiscoveryUsingEmailAddress))
                    .AddOrchestrationStep(
                        OrchestrationStepBuilder.AsClaimsExchange
                            .AddClaimsExchange("NewCredentials", BaseLocalAccountTechnicalProfiles.LocalAccountWritePasswordUsingObjectId))
                    .AddOrchestrationStep(OrchestrationStepBuilder.AsJwtIssuer)
                    .UsingDefaultWebClientDefinition();
        }
    }
}