using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.general
{
    public class Hash : IProducePolicyMarkup
    {
        private readonly string _id, _secretPolicyKey;
        private readonly ClaimType _claimToHash, _claimAsSalt, _outputClaim;
        public Hash(string id, ClaimType claimToHash, ClaimType claimAsSalt, ClaimType outputClaim, string secretPolicyKey)
        {
            ValidateInputs(claimToHash, claimAsSalt, outputClaim);

            _id = id;
            _claimToHash = claimToHash;
            _claimAsSalt = claimAsSalt;
            _outputClaim = outputClaim;
            _secretPolicyKey = secretPolicyKey;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "Hash")
                    .AcceptingClaim(_claimToHash, "plaintext")
                    .AcceptingClaim(_claimAsSalt, "salt")
                    .AcceptingParameter("randomizerSecret", DataType.@string, _secretPolicyKey)
                    .ReturnsClaim(_outputClaim, "hash");
        }

        private void ValidateInputs(ClaimType claimToHash, ClaimType claimAsSalt, ClaimType outputClaim)
        {
            if (claimToHash.DataType != DataType.@string)
            {
                throw new Exception($"Claim to hash {claimToHash.Id} must be of type String");
            }
            if (claimAsSalt.DataType != DataType.@string)
            {
                throw new Exception($"Salt claim {claimAsSalt.Id} must be of type String");
            }
            if (outputClaim.DataType != DataType.@string)
            {
                throw new Exception($"Output claim {outputClaim.Id} must be of type String");
            }
        }
    }
}