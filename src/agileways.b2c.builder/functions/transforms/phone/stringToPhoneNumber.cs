
using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.phone
{
    public class StringToPhoneNumber : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _input, _inputCountryCode, _output;

        public StringToPhoneNumber(string id, ClaimType phoneString, ClaimType countryCode, ClaimType output)
        {
            ValidateInputs(phoneString, countryCode, output);
            _id = id;
            _input = phoneString;
            _inputCountryCode = countryCode;
            _output = output;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "ConvertStringToPhoneNumberClaim")
                    .AcceptingClaim(_input, "phoneNumberString")
                    .AcceptingClaim(_inputCountryCode, "country")
                    .ReturnsClaim(_output, "phoneNumber");
        }

        private void ValidateInputs(ClaimType phoneString, ClaimType countryCode, ClaimType output)
        {
            if (output.DataType != DataType.phoneNumber)
            {
                throw new Exception($"Output claim {output.Id} must be of type phoneNumber; claim is of type {output.DataType}");
            }
            if (phoneString.DataType != DataType.@string)
            {
                throw new Exception($"Output phone number claim {phoneString.Id} must be of type string; claim is of type {phoneString.DataType}");
            }
            if (countryCode.DataType != DataType.@string)
            {
                throw new Exception($"Output country code claim {countryCode.Id} must be of type string; claim is of type {countryCode.DataType}");
            }
        }

    }
}