
using System.Collections.Generic;
using System.Configuration;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.techProfiles
{

    public static class BaseSelfAssertedTechnicalProfiles
    {
        public static TechnicalProfile SelfAssertedSocial
        {
            get
            {
                string signatureKey = ConfigurationManager.AppSettings.Get("SignatureKey");
                return new TechnicalProfile
                {
                    Id = "SelfAsserted-Social",
                    DisplayName = "User ID signup",
                    Protocol = new TechnicalProfileProtocol
                    {
                        Name = ProtocolName.Proprietary,
                        Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                    },
                    Metadata = new List<metadataItem> {
                    new metadataItem { Key = "ContentDefinitionReferenceId", Value = BaseContentDefinitions.ApiSelfAsserted.Id }
                },
                    CryptographicKeys = new List<CryptographicKey> {
                    new CryptographicKey { Id = "issuer_secret", StorageReferenceId = signatureKey }
                },
                    InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.DisplayName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Surname.Id }
                },
                    OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.NewUser.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ExecutedSelfAssertedInput.Id, DefaultValue = "true" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.DisplayName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                    ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                    new ValidationTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadUserWriteUsingAlternativeSecurityId.Id }
                },
                    UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
                    {
                        ReferenceId = BaseSessionMgtTechnicalProfiles.SocialSignup.Id
                    }
                };
            }
        }

        public static TechnicalProfile SelfAssertedProfileUpdate
        {
            get => new TechnicalProfile
            {
                Id = "SelfAsserted-ProfileUpdate",
                DisplayName = "User ID signup",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "ContentDefinitionReferenceId", Value = BaseContentDefinitions.ApiSelfAssertedProfileUpdate.Id}
                },
                IncludeInSso = false,
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AlternativeSecurityId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.UserPrincipalName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ExecutedSelfAssertedInput.Id, DefaultValue = "true" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                    new ValidationTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadUserWriteProfileUsingObjectId.Id }
                }
            };
        }
    }
}