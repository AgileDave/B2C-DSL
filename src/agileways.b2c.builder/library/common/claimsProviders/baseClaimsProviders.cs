using System.Collections.Generic;
using agileways.b2c.builder.library.common.techProfiles;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.claimsProviders
{

    public static class BaseClaimsProviders
    {

        public static ClaimsProvider LocalAccountSignin
        {
            get => new ClaimsProvider
            {
                DisplayName = "Local Account SignIn",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseLocalAccountTechnicalProfiles.LoginNonInteractive
                }
            };
        }

        public static ClaimsProvider AzureActiveDirectory
        {
            get => new ClaimsProvider
            {
                DisplayName = "Azure Active Directory",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseAadTechnicalProfiles.AadCommon,
                    BaseAadTechnicalProfiles.AadUserWriteUsingAlternativeSecurityId,
                    BaseAadTechnicalProfiles.AadUserReadUsingAlternativeSecurityId,
                    BaseAadTechnicalProfiles.AadUserReadUsingAlternativeSecurityIdNoError,
                    BaseAadTechnicalProfiles.AadUserWriteUsingLogonEmail,
                    BaseAadTechnicalProfiles.AadUserReadUsingEmailAddress,
                    BaseAadTechnicalProfiles.AadUserWritePasswordUsingObjectId,
                    BaseAadTechnicalProfiles.AadUserWriteProfileUsingObjectId,
                    BaseAadTechnicalProfiles.AadaUserReadUsingObjectId
                }
            };
        }

        public static ClaimsProvider SelfAsserted
        {
            get => new ClaimsProvider
            {
                DisplayName = "Self Asserted",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseSelfAssertedTechnicalProfiles.SelfAssertedSocial,
                    BaseSelfAssertedTechnicalProfiles.SelfAssertedProfileUpdate
                }
            };
        }

        public static ClaimsProvider LocalAccount
        {
            get => new ClaimsProvider
            {
                DisplayName = "Local Account",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseLocalAccountTechnicalProfiles.LocalAccountSignUpWithLogonEmail,
                    BaseLocalAccountTechnicalProfiles.SelfAssertedLocalAccountSigninEmail,
                    BaseLocalAccountTechnicalProfiles.LocalAccountDiscoveryUsingEmailAddress,
                    BaseLocalAccountTechnicalProfiles.LocalAccountWritePasswordUsingObjectId
                }
            };
        }

        public static ClaimsProvider SessionManagement
        {
            get => new ClaimsProvider
            {
                DisplayName = "Session Management",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseSessionMgtTechnicalProfiles.NoOp,
                    BaseSessionMgtTechnicalProfiles.Aad,
                    BaseSessionMgtTechnicalProfiles.SocialSignup,
                    BaseSessionMgtTechnicalProfiles.SocialLogin
                }
            };
        }

        public static ClaimsProvider TPEngine
        {
            get => new ClaimsProvider
            {
                DisplayName = "Trustframework Policy Engine TechnicalProfiles",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseTpEngineTechnicalProfiles.TpEngine
                }
            };
        }

        public static ClaimsProvider TokenIssuer
        {
            get => new ClaimsProvider
            {
                DisplayName = "Token Issuer",
                TechnicalProfiles = new List<TechnicalProfile> {
                    BaseTokenIssuerTechnicalProfiles.JwtIssuer
                }
            };
        }
    }
}