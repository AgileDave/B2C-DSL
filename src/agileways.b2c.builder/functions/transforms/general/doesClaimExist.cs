using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.general
{
    public class DoesClaimExist : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _output;
        public DoesClaimExist(string id, ClaimType claimToCheck, ClaimType resultClaim)
        {
            if (resultClaim.DataType != DataType.boolean)
            {
                throw new Exception($"Output claim {resultClaim.Id} must be of Boolean type");
            }

            _input = claimToCheck;
            _output = resultClaim;
            _id = id;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "DoesClaimExist")
                    .AcceptingClaim(_input, "inputClaim")
                    .ReturnsClaim(_output, "outputClaim");
        }
    }
}