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
                                    .AddOutputClaim(BaseClaims.DisplayName.Id)
                                    .AddOutputClaim(BaseClaims.GivenName.Id)
                                    .AddOutputClaim(BaseClaims.Surname.Id)
                                    .AddOutputClaim(BaseClaims.Email.Id)
                                    .AddOutputClaim(BaseClaims.ObjectId.Id, "sub")
                                    .AddOutputClaim(BaseClaims.IdentityProvider.Id, defaultValue: "local")
                                    .AddOutputClaim(BaseClaims.TenantId.Id, defaultValue: "{Policy:TenantObjectId}", alwaysUseDefaultValue: true)
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
                                    .AddOutputClaim(BaseClaims.ObjectId.Id, "sub")
                                    .AddOutputClaim(BaseClaims.TenantId.Id, defaultValue: "{Policy:TenantObjectId}", alwaysUseDefaultValue: true)
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
                                    .AddOutputClaim(BaseClaims.Email.Id)
                                    .AddOutputClaim(BaseClaims.ObjectId.Id, "sub")
                                    .AddOutputClaim(BaseClaims.TenantId.Id, defaultValue: "{Policy:TenantObjectId}", alwaysUseDefaultValue: true)
            };
        }
    }
}