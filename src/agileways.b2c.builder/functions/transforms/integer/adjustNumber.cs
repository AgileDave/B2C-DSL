using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.integer
{

    public class AdjustNumber : IProducePolicyMarkup
    {
        private readonly string _id, _op;
        private readonly ClaimType _input, _output;

        public AdjustNumber(string id, ClaimType input, ClaimType output, string op = "INCREMENT")
        {
            ValidateInputs(input, output, op);
            _id = id;
            _op = op;
            _input = input;
            _output = output;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "AdjustNumber")
                    .AcceptingClaim(_input, "inputClaim")
                    .AcceptingParameter("Operator", DataType.@string, _op)
                    .ReturnsClaim(_output, "outputClaim");
        }

        private void ValidateInputs(ClaimType input, ClaimType output, string op)
        {
            if (input.DataType != DataType.@int)
            {
                throw new Exception($"Input claim {input.Id} must be of type Integer");
            }
            if (!op.Equals("INCREMENT", StringComparison.OrdinalIgnoreCase) && !op.Equals("DECREMENT", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception($"Operator {op} must be either 'INCREMENT' or 'DECREMENT'");
            }
            if (output.DataType != DataType.@int)
            {
                throw new Exception($"Output claim {output.Id} must be of type Integer");
            }
        }
    }
}