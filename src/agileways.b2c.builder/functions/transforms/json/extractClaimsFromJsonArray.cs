using System;
using System.Linq;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.json
{
    public class ExtractClaimsFromJsonArray : IProducePolicyMarkup
    {
        private readonly string _id, _sourceKeyName, _sourceValueName;
        private readonly bool _errorOnMissingClaims, _includeEmptyClaims;
        private readonly ClaimType _inputJsonArray;
        private readonly ClaimType[] _outputs;

        public ExtractClaimsFromJsonArray(string id, ClaimType jsonSource, bool errorOnMissingClaims = false, bool includeEmptyClaims = false,
                                            string jsonSourceKey = "key", string jsonSourceValue = "value",
                                            params ClaimType[] outputClaims)
        {
            ValidateInputs(jsonSource, outputClaims);
            _id = id;
            _inputJsonArray = jsonSource;
            _errorOnMissingClaims = errorOnMissingClaims;
            _includeEmptyClaims = includeEmptyClaims;
            _sourceKeyName = jsonSourceKey;
            _sourceValueName = jsonSourceValue;
            _outputs = outputClaims;
        }

        public ClaimsTransformation ToMarkup()
        {
            var transform = TransformationBuilder.Init(_id, "GetClaimsFromJsonArray")
                    .AcceptingClaim(_inputJsonArray, "jsonSourceClaim")
                    .AcceptingParameter("errorOnMissingClaims", DataType.boolean, _errorOnMissingClaims.ToString())
                    .AcceptingParameter("includeEmptyClaims", DataType.@string, _includeEmptyClaims.ToString())
                    .AcceptingParameter("jsonSourceKeyName", DataType.@string, _sourceKeyName)
                    .AcceptingParameter("jsonSourceValueName", DataType.@string, _sourceValueName);
            _outputs.Select(o => transform.ReturnsClaim(o));
            return transform;
        }

        private void ValidateInputs(ClaimType source, ClaimType[] outputs)
        {
            if (source.DataType != DataType.@string)
            {
                throw new Exception($"Input claim {source.Id} must be of type string; source claim was type {source.DataType}");
            }
            foreach (var output in outputs)
            {
                switch (output.DataType)
                {
                    case DataType.boolean:
                    case DataType.dateTime:
                    case DataType.@int:
                    case DataType.@string:
                        break;
                    default:
                        throw new Exception($"Output claim {output.Id} must be of type bool, datetime, int, or string. Output claim was of type {output.DataType}");
                        break;
                }
            }
        }
    }
}