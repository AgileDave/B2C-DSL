using System.Collections.Generic;
using System.Configuration;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.techProfiles
{
    public static class BaseTokenIssuerTechnicalProfiles
    {
        public static TechnicalProfile JwtIssuer
        {
            get
            {
                string signatureKey = ConfigurationManager.AppSettings.Get("SignatureKey");
                string encryptionKey = ConfigurationManager.AppSettings.Get("EncryptionKey");
                return new TechnicalProfile
                {
                    Id = "JwtIssuer",
                    DisplayName = "JWT Issuer",
                    Protocol = new TechnicalProfileProtocol { Name = ProtocolName.None },
                    OutputTokenFormat = TokenFormat.JWT,
                    Metadata = new List<metadataItem> {
                    new metadataItem { Key = "client_id", Value = "{service:te}" },
                    new metadataItem { Key = "issuer_refresh_token_user_identity_claim_type", Value = "objectId" },
                    new metadataItem { Key = "SendTokenResponseBodyWithJsonNumbers", Value = "true" },
                },
                    CryptographicKeys = new List<CryptographicKey> {
                    new CryptographicKey { Id = "issuer_secret", StorageReferenceId = signatureKey },
                    new CryptographicKey { Id = "issuer_refresh_token_key", StorageReferenceId = encryptionKey },
                },
                    InputClaims = new List<ClaimTypeReference>(),
                    OutputClaims = new List<ClaimTypeReference>()
                };
            }
        }
    }
}