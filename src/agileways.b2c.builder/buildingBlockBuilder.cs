
using System.Collections.Generic;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.content;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.extensions
{

    public static class BuildingBlockBuilder
    {
        public static BuildingBlocks Init()
        {
            return new BuildingBlocks();
        }

        public static BuildingBlocks AddClaimType(this BuildingBlocks bb, ClaimType claim)
        {
            if (bb.ClaimsSchema == null)
            {
                bb.ClaimsSchema = new List<ClaimType>();
            }
            bb.ClaimsSchema.Add(claim);
            return bb;
        }

        public static BuildingBlocks AddClaimType(this BuildingBlocks bb, string id, string displayName, DataType dataType, string userHelpText = "", string adminHelpText = "")
        {
            if (bb.ClaimsSchema == null)
            {
                bb.ClaimsSchema = new List<ClaimType>();
            }
            var claim = new ClaimType
            {
                Id = id,
                DisplayName = displayName,
                DataType = dataType,
                UserHelpText = userHelpText,
                AdminHelpText = adminHelpText
            };
            bb.ClaimsSchema.Add(claim);
            return bb;
        }

        public static BuildingBlocks AddClaimType(this BuildingBlocks bb, string id, string displayName, DataType dataType, List<PartnerClaimTypesProtocol> partnerClaims, string userHelpText = "", string adminHelpText = "")
        {
            if (bb.ClaimsSchema == null)
            {
                bb.ClaimsSchema = new List<ClaimType>();
            }
            var claim = new ClaimType
            {
                Id = id,
                DisplayName = displayName,
                DataType = dataType,
                DefaultPartnerClaimTypes = partnerClaims,
                UserHelpText = userHelpText,
                AdminHelpText = adminHelpText
            };
            bb.ClaimsSchema.Add(claim);
            return bb;
        }

        public static BuildingBlocks AddClaimType(this BuildingBlocks bb, string id, string displayName, DataType dataType, Restriction restriction, string userHelpText = "", string adminHelpText = "")
        {
            if (bb.ClaimsSchema == null)
            {
                bb.ClaimsSchema = new List<ClaimType>();
            }
            var claim = new ClaimType
            {
                Id = id,
                DisplayName = displayName,
                DataType = dataType,
                Restriction = restriction,
                UserHelpText = userHelpText,
                AdminHelpText = adminHelpText
            };
            bb.ClaimsSchema.Add(claim);
            return bb;
        }

        public static BuildingBlocks AddClaimType(this BuildingBlocks bb, string id, string displayName, DataType dataType, List<PartnerClaimTypesProtocol> partnerClaims, Restriction restriction, string userHelpText = "", string adminHelpText = "")
        {
            if (bb.ClaimsSchema == null)
            {
                bb.ClaimsSchema = new List<ClaimType>();
            }
            var claim = new ClaimType
            {
                Id = id,
                DisplayName = displayName,
                DataType = dataType,
                DefaultPartnerClaimTypes = partnerClaims,
                Restriction = restriction,
                UserHelpText = userHelpText,
                AdminHelpText = adminHelpText
            };
            bb.ClaimsSchema.Add(claim);
            return bb;
        }

        public static BuildingBlocks AddClaimsTransformation(this BuildingBlocks bb, ClaimsTransformation ct)
        {
            if (bb.ClaimsTransformations == null)
            {
                bb.ClaimsTransformations = new List<ClaimsTransformation>();
            }
            bb.ClaimsTransformations.Add(ct);
            return bb;
        }

        public static BuildingBlocks AddClientDefinition(this BuildingBlocks bb, ClientDefinition cd)
        {
            if (bb.ClientDefinitions == null)
            {
                bb.ClientDefinitions = new List<ClientDefinition>();
            }
            bb.ClientDefinitions.Add(cd);
            return bb;
        }

        public static BuildingBlocks AddContentDefinition(this BuildingBlocks bb, ContentDefinition cd)
        {
            if (bb.ContentDefinitions == null)
            {
                bb.ContentDefinitions = new List<ContentDefinition>();
            }
            bb.ContentDefinitions.Add(cd);
            return bb;
        }
    }
}
