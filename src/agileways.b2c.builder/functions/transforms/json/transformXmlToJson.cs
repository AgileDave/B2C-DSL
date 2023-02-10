
using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.json
{
    public class TransformXmlToJson : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _output;

        public TransformXmlToJson(string id, ClaimType xml, ClaimType json)
        {
            ValidateInputs(xml, json);
            _id = id;
            _input = xml;
            _output = json;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "XmlStringToJsonString")
                    .AcceptingClaim(_input, "xml")
                    .ReturnsClaim(_output, "json");
        }

        private void ValidateInputs(ClaimType input, ClaimType output)
        {
            if (input.DataType != DataType.@string)
            {
                throw new Exception($"Input xml claim {input.Id} must be of type string; claim is of type {input.DataType}");
            }
            if (output.DataType != DataType.@string)
            {
                throw new Exception($"Output json claim {output.Id} must be of type string; claim is of type {output.DataType}");
            }
        }

    }
}