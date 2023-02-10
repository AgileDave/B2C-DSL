
using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.phone
{
    public class PhoneNumberToString : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _output;

        public PhoneNumberToString(string id, ClaimType input, ClaimType output)
        {
            ValidateInputs(input, output);
            _id = id;
            _input = input;
            _output = output;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "ConvertPhoneNumberClaimToString")
                    .AcceptingClaim(_input, "phoneNumber")
                    .ReturnsClaim(_output, "phoneNumberString");
        }

        private void ValidateInputs(ClaimType input, ClaimType output)
        {
            if (input.DataType != DataType.phoneNumber)
            {
                throw new Exception($"Input claim {input.Id} must be of type phoneNumber; claim is of type {input.DataType}");
            }
            if (output.DataType != DataType.@string)
            {
                throw new Exception($"Output claim {output.Id} must be of type string; claim is of type {output.DataType}");
            }
        }

    }
}