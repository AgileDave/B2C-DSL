using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.boolean
{
    public class Not : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _output;

        public Not(string id, ClaimType input, ClaimType output)
        {
            ValidateInputs(input, output);
            _id = id;
            _input = input;
            _output = output;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "NotClaims")
                    .AcceptingClaim(_input, "inputClaim")
                    .ReturnsClaim(_output, "outputClaim");
        }

        private void ValidateInputs(ClaimType input, ClaimType output)
        {
            if (input.DataType != DataType.boolean)
            {
                throw new Exception($"Input claim {input.Id} must be of type Boolean");
            }
            if (output.DataType != DataType.boolean)
            {
                throw new Exception($"Output claim {output.Id} must be of type Boolean");
            }
        }
    }
}