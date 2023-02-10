using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.boolean
{

    public class AssertEqualToValue : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input;
        private readonly bool _valueToCompare;
        public AssertEqualToValue(string id, ClaimType input, bool value)
        {
            ValidateInputs(input);
            _id = id;
            _input = input;
            _valueToCompare = value;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "AssertBooleanClaimIsEqualToValue")
                    .AcceptingClaim(_input, "inputClaim")
                    .AcceptingParameter("valueToCompareTo", DataType.boolean, _valueToCompare.ToString().ToLower());
        }

        private void ValidateInputs(ClaimType input)
        {
            if (input.DataType != DataType.boolean)
            {
                throw new Exception($"Claim {input.Id} must be of type Boolean");
            }
        }
    }
}