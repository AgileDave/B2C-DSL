using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.general
{
    public class CopyClaim : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _output;
        public CopyClaim(string id, ClaimType sourceClaim, ClaimType destClaim)
        {
            if (!(sourceClaim.DataType == DataType.@string || sourceClaim.DataType == DataType.@int))
            {
                throw new Exception($"Source claim {sourceClaim.Id} must be of type String or Int");
            }

            if (!(destClaim.DataType == DataType.@string || destClaim.DataType == DataType.@int))
            {
                throw new Exception($"Destination claim {destClaim.Id} must be of type String or Int");
            }

            _input = sourceClaim;
            _output = destClaim;
            _id = id;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "CopyClaim")
                    .AcceptingClaim(_input, "inputClaim")
                    .ReturnsClaim(_output, "outputClaim");
        }
    }
}