using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.date
{
    public class GetCurrentDateTime : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _output;

        public GetCurrentDateTime(string id, ClaimType output)
        {
            ValidateInputs(output);
            _id = id;
            _output = output;
        }

        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "GetCurrentDateTime")
                    .ReturnsClaim(_output, "currentDateTime");
        }

        private void ValidateInputs(ClaimType output)
        {
            if (output.DataType != DataType.dateTime)
            {
                throw new Exception($"Output claim {output.Id} must be of type DateTime");
            }
        }
    }
}