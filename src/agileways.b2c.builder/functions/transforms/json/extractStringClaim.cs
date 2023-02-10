using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.json
{
    public class ExtractStringClaim : IProducePolicyMarkup
    {
        private readonly string _id, _elementToExtract;
        private readonly ClaimType _input, _output;
        public ExtractStringClaim(string id, ClaimType input, string elementToExtract, ClaimType output)
        {
            ValidateInputs(input, output, elementToExtract);
            _id = id;
            _input = input;
            _output = output;
            _elementToExtract = elementToExtract;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "GetClaimFromJson")
                    .AcceptingClaim(_input, "inputJson")
                    .AcceptingParameter("claimToExtract", DataType.@string, _elementToExtract)
                    .ReturnsClaim(_output, "extractedClaim");
        }

        private void ValidateInputs(ClaimType input, ClaimType output, string elem)
        {
            if (string.IsNullOrWhiteSpace(elem))
            {
                throw new Exception($"JSON element name to extract must not be null or empty");
            }
            if (input.DataType != DataType.@string)
            {
                throw new Exception($"Input json claim {input.Id} must be of type string; claim is of type {input.DataType}");
            }
            if (output.DataType != DataType.@string)
            {
                throw new Exception($"Output claim {output.Id} must be of type string; claim is of type {output.DataType}");
            }
        }
    }
}