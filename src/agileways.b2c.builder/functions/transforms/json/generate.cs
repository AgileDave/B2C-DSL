using System;
using System.Collections.Generic;
using System.Linq;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.json
{
    public class Generate : IProducePolicyMarkup
    {
        private readonly ClaimType _output;
        private Dictionary<string, ClaimType> _claims;
        private Dictionary<string, string> _params;
        private readonly string _id;
        public Generate(string id, ClaimType output)
        {
            ValidateInput(output);
            _id = id;
            _output = output;
            _claims = new Dictionary<string, ClaimType>();
            _params = new Dictionary<string, string>();
        }

        public Generate AddInputClaim(ClaimType input, string jsonPath)
        {
            ValidateInput(input, jsonPath);
            _claims.Add(jsonPath, input);
            return this;
        }
        public Generate AddInputParam(string value, string jsonPath)
        {
            ValidateInput(value, jsonPath);
            _params.Add(jsonPath, value);
            return this;
        }
        public ClaimsTransformation ToMarkup()
        {
            var transform = TransformationBuilder.Init(_id, "GenerateJson");
            _claims.Select(kvp => transform.AcceptingClaim(kvp.Value, kvp.Key));
            _params.Select(kvp => transform.AcceptingParameter(kvp.Key, DataType.@string, kvp.Value));
            transform.ReturnsClaim(_output, "outputClaim");
            return transform;
        }

        private void ValidateInput(ClaimType output)
        {
            if (output.DataType != DataType.@string)
            {
                throw new Exception($"Output claim {output.Id} must be of type string");
            }
        }
        private void ValidateInput(ClaimType input, string json)
        {
            if (String.IsNullOrWhiteSpace(json))
            {
                throw new Exception($"JSON Path for claim {input.Id} must not be null or empty");
            }
            if (input.DataType != DataType.@string)
            {
                throw new Exception($"Input claim {input.Id} must be of type string");
            }
        }
        private void ValidateInput(string input, string json)
        {
            if (String.IsNullOrWhiteSpace(json))
            {
                throw new Exception($"JSON Path for value {input} must not be null or empty");
            }
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new Exception($"Input param for json path {json} must not be null or empty");
            }
        }
    }
}