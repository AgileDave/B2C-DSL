
using System.Collections.Generic;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.clientDefinitions;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.library.common.techProfiles;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.journey;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.library.common.journeys
{
    public static class BaseSocialAndLocalJourneys
    {
        public static UserJourney Susi
        {
            get => UserJourneyBuilder.Init("SignUpOrSignIn")
                        .AddClientDefinition(BaseClientDefinitions.DefaultWeb)
                        .AddOrchestrationSteps(OrchestrationStepBuilder.Init(1, OrchestrationStepType.CombinedSignInAndSignUp, BaseContentDefinitions.ApiSignUpOrSignIn.Id)
                                                    .AddClaimsProviderSelection("LocalAccountSigninEmailExchange")
                                                    .AddClaimsExchange("LocalAccountSigninEmailExchange", BaseLocalAccountTechnicalProfiles.SelfAssertedLocalAccountSigninEmail.Id),
                                                OrchestrationStepBuilder.Init(2, OrchestrationStepType.ClaimsExchange)
                                                    .AddPrecondition(PreconditionType.ClaimsExist, true, PreconditionActionType.SkipThisOrchestrationStep, BaseClaims.ObjectId.Id)
                                                    .AddClaimsExchange("SignUpWithLogonEmailExchange", BaseLocalAccountTechnicalProfiles.LocalAccountSignUpWithLogonEmail.Id),
                                                OrchestrationStepBuilder.Init(3, OrchestrationStepType.ClaimsExchange)
                                                    .AddPrecondition(PreconditionType.ClaimEquals, true, PreconditionActionType.SkipThisOrchestrationStep, BaseClaims.AuthenticationSource.Id, "socialIdpAuthentication")
                                                    .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId.Id),
                                                OrchestrationStepBuilder.InitIssuerStep(4, OrchestrationStepType.SendClaims, BaseTokenIssuerTechnicalProfiles.JwtIssuer.Id)
                    );
        }

        public static UserJourney ProfileEdit
        {
            get => UserJourneyBuilder.Init("ProfileEdit")
                        .AddOrchestrationSteps(
                            OrchestrationStepBuilder.Init(1, OrchestrationStepType.ClaimsProviderSelection, BaseContentDefinitions.ApiIdpSelections.Id)
                                .AddClaimsProviderSelection("LocalAccountSigninEmailExchange"),
                            OrchestrationStepBuilder.Init(2, OrchestrationStepType.ClaimsExchange)
                                .AddClaimsExchange("LocalAccountSigninEmailExchange", BaseLocalAccountTechnicalProfiles.SelfAssertedLocalAccountSigninEmail.Id),
                            OrchestrationStepBuilder.Init(3, OrchestrationStepType.ClaimsExchange)
                                .AddPrecondition(PreconditionType.ClaimEquals, true, PreconditionActionType.SkipThisOrchestrationStep, BaseClaims.AuthenticationSource.Id, "localAccountAuthentication")
                                .AddClaimsExchange("AADUserRead", BaseAadTechnicalProfiles.AadUserReadUsingAlternativeSecurityId.Id),
                            OrchestrationStepBuilder.Init(4, OrchestrationStepType.ClaimsExchange)
                                .AddPrecondition(PreconditionType.ClaimEquals, true, PreconditionActionType.SkipThisOrchestrationStep, BaseClaims.AuthenticationSource.Id, "socialIdpAuthentication")
                                .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId.Id),
                            OrchestrationStepBuilder.Init(5, OrchestrationStepType.ClaimsExchange)
                                .AddClaimsExchange("B2CUserProfileUpdateExchange", BaseSelfAssertedTechnicalProfiles.SelfAssertedProfileUpdate.Id),
                            OrchestrationStepBuilder.InitIssuerStep(6, OrchestrationStepType.SendClaims, BaseTokenIssuerTechnicalProfiles.JwtIssuer.Id)
                        )
                        .AddClientDefinition(BaseClientDefinitions.DefaultWeb);
        }

        public static UserJourney PasswordReset
        {
            get => UserJourneyBuilder.Init("PasswordReset")
                    .AddOrchestrationSteps(
                        OrchestrationStepBuilder.Init(1, OrchestrationStepType.ClaimsExchange)
                            .AddClaimsExchange("PasswordResetUsingEmailAddressExchange", BaseLocalAccountTechnicalProfiles.LocalAccountDiscoveryUsingEmailAddress.Id),
                        OrchestrationStepBuilder.Init(2, OrchestrationStepType.ClaimsExchange)
                            .AddClaimsExchange("NewCredentials", BaseLocalAccountTechnicalProfiles.LocalAccountWritePasswordUsingObjectId.Id),
                        OrchestrationStepBuilder.InitIssuerStep(3, OrchestrationStepType.SendClaims, BaseTokenIssuerTechnicalProfiles.JwtIssuer.Id)
                    )
                    .AddClientDefinition(BaseClientDefinitions.DefaultWeb);
        }
    }
}