using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.json
{
    public class ExtractSingleJsonItem : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _key, _value;

        public ExtractSingleJsonItem(string id, ClaimType inputJson, ClaimType outputKey, ClaimType outputValue)
        {
            ValidateInputs(inputJson, outputKey, outputValue);
            _id = id;
            _input = inputJson;
            _key = outputKey;
            _value = outputValue;
        }

        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "GetSingleItemFromJson")
                    .AcceptingClaim(_input, "inputJson")
                    .ReturnsClaim(_key, "key")
                    .ReturnsClaim(_value, "value");
        }

        private void ValidateInputs(ClaimType input, ClaimType key, ClaimType value)
        {

            if (input.DataType != DataType.@string)
            {
                throw new Exception($"Input json claim {input.Id} must be of type string; claim is of type {input.DataType}");
            }
            if (key.DataType != DataType.@string)
            {
                throw new Exception($"Key json claim {key.Id} must be of type string; claim is of type {key.DataType}");
            }
            if (value.DataType != DataType.@string)
            {
                throw new Exception($"Value json claim {value.Id} must be of type string; claim is of type {value.DataType}");
            }
        }
    }
}