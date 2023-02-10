using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.boolean
{
    public class CompareToValue : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _output;
        private readonly bool _valueToCompareTo;

        public CompareToValue(string id, ClaimType input, bool value, ClaimType output)
        {
            ValidateInputs(input, output);
            _id = id;
            _input = input;
            _valueToCompareTo = value;
            _output = output;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "CompareBooleanClaimToValue")
                    .AcceptingClaim(_input, "inputClaim")
                    .AcceptingParameter("valueToCompareTo", DataType.boolean, _valueToCompareTo.ToString().ToLower())
                    .ReturnsClaim(_output, "compareResult");
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