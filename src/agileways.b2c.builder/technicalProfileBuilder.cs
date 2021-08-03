using System.Collections.Generic;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.extensions
{

    public static class TechnicalProfileBuilder
    {
        public static TechnicalProfile Init(string id)
        {
            return new TechnicalProfile
            {
                Id = id
            };
        }

        ///<summary>
        ///initialize the TP
        ///</summary>
        ///<param name="id">The ID of the Technical Profile</param>
        public static TechnicalProfile Init(string id, string displayName, ProtocolName protocol, string description = null)
        {
            return new TechnicalProfile
            {
                Id = id,
                DisplayName = displayName,
                Protocol = new TechnicalProfileProtocol
                {
                    Name = protocol
                },
                Description = description
            };
        }

        public static TechnicalProfile ParticipatesInSso(this TechnicalProfile tp, bool includeInSso)
        {
            tp.IncludeInSso = includeInSso;
            tp.IncludeInSsoSpecified = true;
            return tp;
        }

        public static TechnicalProfile AddMetadata(this TechnicalProfile tp, System.Enum key, string value)
        {
            if (tp.Metadata == null)
            {
                tp.Metadata = new List<metadataItem>();
            }

            tp.Metadata.Add(new metadataItem
            {
                Key = System.Enum.GetName(key.GetType(), key),
                Value = value
            });
            return tp;
        }
        public static TechnicalProfile AddMetadata(this TechnicalProfile tp, string key, string value)
        {
            if (tp.Metadata == null)
            {
                tp.Metadata = new List<metadataItem>();
            }
            tp.Metadata.Add(new metadataItem
            {
                Key = key,
                Value = value
            });
            return tp;
        }

        public static TechnicalProfile AcceptsClaim(this TechnicalProfile tp, ClaimType claim,
                        string partnerClaimType = "", string defaultValue = "",
                        bool alwaysUseDefaultValue = false, bool? required = null)
        {
            if (tp.InputClaims == null)
            {
                tp.InputClaims = new List<ClaimTypeReference>();
            }

            var c = new ClaimTypeReference { ClaimTypeReferenceId = claim.Id, RequiredSpecified = false };
            if (!string.IsNullOrWhiteSpace(partnerClaimType))
            {
                c.PartnerClaimType = partnerClaimType;
            }

            if (!string.IsNullOrWhiteSpace(defaultValue))
            {
                c.DefaultValue = defaultValue;
                c.AlwaysUseDefaultValue = alwaysUseDefaultValue;
                c.AlwaysUseDefaultValueSpecified = true;
            }

            if (required.HasValue)
            {
                c.Required = required.Value;
                c.RequiredSpecified = true;
            }

            tp.InputClaims.Add(c);

            return tp;
        }

        public static TechnicalProfile SetSubjectNaming(this TechnicalProfile tp, string subjectClaim)
        {
            tp.SubjectNamingInfo = new SubjectNamingInfo
            {
                ClaimType = subjectClaim
            };
            return tp;
        }

        public static TechnicalProfile ReturnsClaim(this TechnicalProfile tp, string claimId, string partnerClaimType = "", string defaultValue = "", bool alwaysUseDefaultValue = false, bool? required = null)
        {

            if (tp.OutputClaims == null)
            {
                tp.OutputClaims = new List<ClaimTypeReference>();
            }

            var c = new ClaimTypeReference { ClaimTypeReferenceId = claimId, RequiredSpecified = false };
            if (!string.IsNullOrWhiteSpace(partnerClaimType))
            {
                c.PartnerClaimType = partnerClaimType;
            }

            if (!string.IsNullOrWhiteSpace(defaultValue))
            {
                c.DefaultValue = defaultValue;
                c.AlwaysUseDefaultValue = alwaysUseDefaultValue;
                c.AlwaysUseDefaultValueSpecified = true;
            }

            if (required.HasValue)
            {
                c.Required = required.Value;
                c.RequiredSpecified = true;
            }

            tp.OutputClaims.Add(c);

            return tp;
        }

        public static TechnicalProfile ReturnsClaim(this TechnicalProfile tp, ClaimType claim, string partnerClaimType = "", string defaultValue = "", bool alwaysUseDefaultValue = false, bool? required = null)
        {

            if (tp.OutputClaims == null)
            {
                tp.OutputClaims = new List<ClaimTypeReference>();
            }

            return ReturnsClaim(tp, claim.Id, partnerClaimType, defaultValue, alwaysUseDefaultValue, required);
        }



        public static TechnicalProfile PersistsClaim(this TechnicalProfile tp, string claimId, string partnerClaimType = "", string defaultValue = "", bool alwaysUseDefaultValue = false)
        {

            if (tp.PersistedClaims == null)
            {
                tp.PersistedClaims = new List<PersistedClaim>();
            }

            var c = new PersistedClaim { ClaimTypeReferenceId = claimId };
            if (!string.IsNullOrWhiteSpace(partnerClaimType))
            {
                c.PartnerClaimType = partnerClaimType;
            }

            if (!string.IsNullOrWhiteSpace(defaultValue))
            {
                c.DefaultValue = defaultValue;
                c.AlwaysUseDefaultValue = alwaysUseDefaultValue;
                c.AlwaysUseDefaultValueSpecified = true;
            }

            tp.PersistedClaims.Add(c);

            return tp;
        }

        public static TechnicalProfile PersistsClaim(this TechnicalProfile tp, ClaimType claim, string partnerClaimType = "", string defaultValue = "", bool alwaysUseDefaultValue = false)
        {

            if (tp.OutputClaims == null)
            {
                tp.OutputClaims = new List<ClaimTypeReference>();
            }

            return PersistsClaim(tp, claim.Id, partnerClaimType, defaultValue, alwaysUseDefaultValue);
        }




        public static TechnicalProfile AddCryptographicKey(this TechnicalProfile tp, string keyId, string storageReferenceId)
        {
            if (tp.CryptographicKeys == null)
            {
                tp.CryptographicKeys = new List<CryptographicKey>();
            }
            tp.CryptographicKeys.Add(new CryptographicKey
            {
                Id = keyId,
                StorageReferenceId = storageReferenceId
            });
            return tp;
        }

        public static TechnicalProfile UsingInputClaimsTransform(this TechnicalProfile tp, ClaimsTransformation transform)
        {
            if (tp.InputClaimsTransformations == null)
            {
                tp.InputClaimsTransformations = new List<ClaimsTransformationReference>();
            }
            tp.InputClaimsTransformations.Add(new ClaimsTransformationReference
            {
                ReferenceId = transform.Id
            });
            return tp;
        }

        public static TechnicalProfile UsingOutputClaimsTransform(this TechnicalProfile tp, ClaimsTransformation transform)
        {
            if (tp.OutputClaimsTransformations == null)
            {
                tp.OutputClaimsTransformations = new List<ClaimsTransformationReference>();
            }
            tp.OutputClaimsTransformations.Add(new ClaimsTransformationReference
            {
                ReferenceId = transform.Id
            });
            return tp;
        }

        public static TechnicalProfile UsingSessionManagementProfile(this TechnicalProfile tp, TechnicalProfile sessionMgt)
        {
            tp.UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
            {
                ReferenceId = sessionMgt.Id
            };
            return tp;
        }
    }
}