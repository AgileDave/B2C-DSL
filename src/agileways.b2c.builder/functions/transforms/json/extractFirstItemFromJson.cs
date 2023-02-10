using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.json
{
    public class ExtractFirstItemFromJson : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _outputKey, _outputValue;

        public ExtractFirstItemFromJson(string id, ClaimType input, ClaimType outputKey, ClaimType outputValue)
        {
            ValidateInputs(input, outputKey, outputValue);
            _id = id;
            _input = input;
            _outputKey = outputKey;
            _outputValue = outputValue;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "GetSingleItemFromJson")
                    .AcceptingClaim(_input, "inputJson")
                    .ReturnsClaim(_outputKey, "key")
                    .ReturnsClaim(_outputValue, "value");
        }

        private void ValidateInputs(ClaimType input, ClaimType key, ClaimType value)
        {
            if (input.DataType != DataType.@string)
            {
                throw new Exception($"Input json claim {input.Id} must be of type string; claim is of type {input.DataType}");
            }
            if (key.DataType != DataType.@string)
            {
                throw new Exception($"Output key claim {key.Id} must be of type string; claim is of type {key.DataType}");
            }
            if (value.DataType != DataType.@string)
            {
                throw new Exception($"Output value claim {value.Id} must be of type string; claim is of type {value.DataType}");
            }
        }
    }
}