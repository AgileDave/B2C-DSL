using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.boolean
{
    public class And : IProducePolicyMarkup
    {
        private readonly ClaimType _lhs, _rhs, _result;
        private readonly string _id;
        public And(string id, ClaimType lhs, ClaimType rhs, ClaimType result)
        {
            ValidateInputs(lhs, rhs, result);
            _id = id;
            _lhs = lhs;
            _rhs = rhs;
            _result = result;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "AndClaims")
                    .AcceptingClaim(_lhs, "inputClaim1")
                    .AcceptingClaim(_rhs, "inputClaim2")
                    .ReturnsClaim(_result, "outputClaim");
        }

        private void ValidateInputs(ClaimType lhs, ClaimType rhs, ClaimType outputClaim)
        {
            if (lhs.DataType != DataType.boolean)
            {
                throw new Exception($"Left-hand-side claim {lhs.Id} must be of type Boolean");
            }
            if (rhs.DataType != DataType.boolean)
            {
                throw new Exception($"Right-hand-side claim {rhs.Id} must be of type Boolean");
            }
            if (outputClaim.DataType != DataType.boolean)
            {
                throw new Exception($"Output claim {outputClaim.Id} must be of type Boolean");
            }
        }

    }
}