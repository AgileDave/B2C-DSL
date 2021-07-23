

using System.Collections.Generic;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.techProfiles
{

    public static class BaseSessionMgtTechnicalProfiles
    {
        public static TechnicalProfile NoOp
        {
            get => new TechnicalProfile
            {
                Id = "SM-Noop",
                DisplayName = "Noop Session Management Provider",
                Protocol = new TechnicalProfileProtocol
                {
                    Handler = "Web.TPEngine.SSO.NoopSSOSessionProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
                    Name = ProtocolName.Proprietary
                }
            };
        }

        public static TechnicalProfile Aad
        {
            get => new TechnicalProfile
            {
                Id = "SM-AAD",
                DisplayName = "Session Mananagement Provider",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.SSO.DefaultSSOSessionProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                PersistedClaims = new List<PersistedClaim> {
                    new PersistedClaim { ClaimTypeReferenceId= BaseClaims.ObjectId.Id },
                    new PersistedClaim { ClaimTypeReferenceId= BaseClaims.SignInName.Id },
                    new PersistedClaim { ClaimTypeReferenceId= BaseClaims.AuthenticationSource.Id },
                    new PersistedClaim { ClaimTypeReferenceId= BaseClaims.IdentityProvider.Id },
                    new PersistedClaim { ClaimTypeReferenceId= BaseClaims.NewUser.Id },
                    new PersistedClaim { ClaimTypeReferenceId= BaseClaims.ExecutedSelfAssertedInput.Id },
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectIdFromSession.Id, DefaultValue = "true" }
                }
            };
        }

        public static TechnicalProfile SocialSignup
        {
            get => new TechnicalProfile
            {
                Id = "SM-SocialSignup",
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = Aad.Id }
            };
        }

        public static TechnicalProfile SocialLogin
        {
            get => new TechnicalProfile
            {
                Id = "SM-SocialLogin",
                DisplayName = "Session Mananagement Provider",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.SSO.ExternalLoginSSOSessionProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "AlwaysFetchClaimsFromProvider", Value = "true" }
                },
                PersistedClaims = new List<PersistedClaim> {
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.AlternativeSecurityId.Id }
                }
            };
        }

    }
}
