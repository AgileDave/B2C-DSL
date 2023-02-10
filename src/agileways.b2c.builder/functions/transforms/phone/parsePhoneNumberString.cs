
using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.phone
{
    public class ParsePhoneNumberString : IProducePolicyMarkup
    {
        private readonly string _id, _countryCodeType;
        private readonly bool _throwException;
        private readonly ClaimType _input, _outputCountryCode, _outputNumber;

        public ParsePhoneNumberString(string id, ClaimType phoneString, ClaimType outputNationalPhone, ClaimType outputCountryCode,
                                        bool throwExceptionOnFailure = false, string countryCodeType = "CallingCode")
        {
            ValidateInputs(phoneString, outputNationalPhone, outputCountryCode, countryCodeType);
            _id = id;
            _input = phoneString;
            _outputNumber = outputNationalPhone;
            _outputCountryCode = outputCountryCode;
            _throwException = throwExceptionOnFailure;
            _countryCodeType = countryCodeType;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "GetNationalNumberAndCountryCodeFromPhoneNumberString")
                    .AcceptingClaim(_input, "phoneNumber")
                    .AcceptingParameter("throwExceptionOnFailure", DataType.boolean, _throwException.ToString())
                    .AcceptingParameter("countryCodeType", DataType.@string, _countryCodeType)
                    .ReturnsClaim(_outputNumber, "nationalNumber")
                    .ReturnsClaim(_outputCountryCode, "countryCode");
        }


        private void ValidateInputs(ClaimType input, ClaimType outputNumber, ClaimType outputCountryCode, string countryCodeType)
        {
            if (input.DataType != DataType.@string)
            {
                throw new Exception($"Input claim {input.Id} must be of type string; claim is of type {input.DataType}");
            }
            if (outputNumber.DataType != DataType.@string)
            {
                throw new Exception($"Output phone number claim {outputNumber.Id} must be of type string; claim is of type {outputNumber.DataType}");
            }
            if (outputCountryCode.DataType != DataType.@string)
            {
                throw new Exception($"Output phone number claim {outputCountryCode.Id} must be of type string; claim is of type {outputCountryCode.DataType}");
            }
            if (!countryCodeType.Equals("CallingCode") && !countryCodeType.Equals("ISO3166"))
            {
                throw new Exception($"Input Country Code Type parameter has invalid value {countryCodeType}. Valid values are 'CallingCode' or 'ISO3166'");
            }
        }

    }
}