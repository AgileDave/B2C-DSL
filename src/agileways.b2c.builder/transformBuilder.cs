using System.Collections.Generic;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.transform;

namespace agileways.b2c.builder.extensions
{
    public static class TransformationBuilder
    {
        public static ClaimsTransformation Init(string id, string method)
        {
            return new ClaimsTransformation
            {
                Id = id,
                TransformationMethod = method
            };
        }

        public static ClaimsTransformation AcceptingClaim(this ClaimsTransformation ct, ClaimType claim, string transformParameterName)
        {
            if (ct.InputClaims == null)
            {
                ct.InputClaims = new List<ClaimsTransformationClaimTypeReference>();
            }
            ct.InputClaims.Add(new ClaimsTransformationClaimTypeReference
            {
                ClaimTypeReferenceId = claim.Id,
                TransformationClaimType = transformParameterName
            });
            return ct;
        }
        public static ClaimsTransformation AcceptingParameter(this ClaimsTransformation ct, string name, DataType type, string value)
        {
            if (ct.InputParameters == null)
            {
                ct.InputParameters = new List<ClaimsTransformationParameter>();
            }
            ct.InputParameters.Add(new ClaimsTransformationParameter
            {
                Id = name,
                DataType = type,
                Value = value
            });
            return ct;
        }

        public static ClaimsTransformation ReturnsClaim(this ClaimsTransformation ct, ClaimType claim, string transformationParameterName)
        {
            if (ct.OutputClaims == null)
            {
                ct.OutputClaims = new List<ClaimsTransformationClaimTypeReference>();
            }

            ct.OutputClaims.Add(new ClaimsTransformationClaimTypeReference
            {
                ClaimTypeReferenceId = claim.Id,
                TransformationClaimType = transformationParameterName
            });
            return ct;
        }
    }
}