using System.Collections.Generic;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.extensions
{

    public static class TechnicalProfileBuilder
    {

        public static TechnicalProfile Init(string id, string displayName, ProtocolName protocol)
        {
            return new TechnicalProfile
            {
                Id = id,
                DisplayName = displayName,
                Protocol = new TechnicalProfileProtocol
                {
                    Name = protocol
                }
            };
        }

        public static TechnicalProfile SetSubjectNaming(this TechnicalProfile tp, string subjectClaim)
        {
            tp.SubjectNamingInfo = new SubjectNamingInfo
            {
                ClaimType = subjectClaim
            };
            return tp;
        }

        public static TechnicalProfile AddOutputClaim(this TechnicalProfile tp, string claimReferenceType, string partnerClaimType = "", string defaultValue = "", bool alwaysUseDefaultValue = false)
        {

            if (tp.OutputClaims == null)
            {
                tp.OutputClaims = new List<ClaimTypeReference>();
            }

            var claim = new ClaimTypeReference { ClaimTypeReferenceId = claimReferenceType };
            if (!string.IsNullOrWhiteSpace(partnerClaimType))
            {
                claim.PartnerClaimType = partnerClaimType;
            }

            if (!string.IsNullOrWhiteSpace(defaultValue))
            {
                claim.DefaultValue = defaultValue;
                claim.AlwaysUseDefaultValue = alwaysUseDefaultValue;
                claim.AlwaysUseDefaultValueSpecified = true;
            }

            tp.OutputClaims.Add(claim);

            return tp;
        }
    }
}