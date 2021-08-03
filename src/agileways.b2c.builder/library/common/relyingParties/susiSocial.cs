using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.journeys;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.rp;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.relyingParties
{
    public static class BaseLocalAndSocialRelyingParty
    {
        public static RelyingParty Susi
        {
            get => new RelyingParty
            {
                DefaultUserJourney = new DefaultUserJourney
                {
                    ReferenceId = BaseSocialAndLocalJourneys.Susi.Id
                },
                TechnicalProfile = TechnicalProfileBuilder.Init("PolicyProfile", "PolicyProfile", ProtocolName.OpenIdConnect)
                                    .SetSubjectNaming(BaseClaims.Subject.Id)
                                    .ReturnsClaim(BaseClaims.DisplayName)
                                    .ReturnsClaim(BaseClaims.GivenName)
                                    .ReturnsClaim(BaseClaims.Surname)
                                    .ReturnsClaim(BaseClaims.Email)
                                    .ReturnsClaim(BaseClaims.ObjectId, "sub")
                                    .ReturnsClaim(BaseClaims.IdentityProvider, defaultValue: "local")
                                    .ReturnsClaim(BaseClaims.TenantId, defaultValue: "{Policy:TenantObjectId}", alwaysUseDefaultValue: true)
            };
        }

        public static RelyingParty ProfileEdit
        {
            get => new RelyingParty
            {
                DefaultUserJourney = new DefaultUserJourney
                {
                    ReferenceId = BaseSocialAndLocalJourneys.ProfileEdit.Id
                },
                TechnicalProfile = TechnicalProfileBuilder.Init("PolicyProfile", "PolicyProfile", ProtocolName.OpenIdConnect)
                                    .SetSubjectNaming(BaseClaims.Subject.Id)
                                    .ReturnsClaim(BaseClaims.ObjectId, "sub")
                                    .ReturnsClaim(BaseClaims.TenantId, defaultValue: "{Policy:TenantObjectId}", alwaysUseDefaultValue: true)
            };
        }

        public static RelyingParty PasswordReset
        {
            get => new RelyingParty
            {
                DefaultUserJourney = new DefaultUserJourney
                {
                    ReferenceId = BaseSocialAndLocalJourneys.PasswordReset.Id
                },
                TechnicalProfile = TechnicalProfileBuilder.Init("PolicyProfile", "PolicyProfile", ProtocolName.OpenIdConnect)
                                    .SetSubjectNaming(BaseClaims.Subject.Id)
                                    .ReturnsClaim(BaseClaims.Email)
                                    .ReturnsClaim(BaseClaims.ObjectId, "sub")
                                    .ReturnsClaim(BaseClaims.TenantId, defaultValue: "{Policy:TenantObjectId}", alwaysUseDefaultValue: true)
            };
        }
    }
}