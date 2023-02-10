using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.date
{
    public class AssertGreaterThan : IProducePolicyMarkup
    {
        private readonly string _id;
        private readonly ClaimType _lhs, _rhs;
        private readonly bool _throwErrorIfEqual, _passIfRightMissing;
        private readonly int _allowedSkewMs;

        public AssertGreaterThan(string id, ClaimType lhs, ClaimType rhs, bool throwIfEqual = true, bool passIfRhsMissing = true, int allowedSkewMs = 30000)
        {
            ValidateInputs(lhs, rhs, allowedSkewMs);
            _id = id;
            _lhs = lhs;
            _rhs = rhs;
            _throwErrorIfEqual = throwIfEqual;
            _passIfRightMissing = passIfRhsMissing;
            _allowedSkewMs = allowedSkewMs;
        }

        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "AssertDateTimeIsGreaterThan")
                    .AcceptingClaim(_lhs, "leftOperand")
                    .AcceptingClaim(_rhs, "rightOperand")
                    .AcceptingParameter("AssertIfEqualTo", DataType.boolean, _throwErrorIfEqual.ToString().ToLower())
                    .AcceptingParameter("AssertIfRightOperandIsNotPresent", DataType.boolean, _passIfRightMissing.ToString().ToLower())
                    .AcceptingParameter("TreatAsEqualIfWithinMilliseconds", DataType.@int, _allowedSkewMs.ToString());
        }

        private void ValidateInputs(ClaimType lhs, ClaimType rhs, int skew)
        {
            if (lhs.DataType != DataType.@string)
            {
                throw new Exception($"Left-hand-side claim {lhs.Id} must be of type string");
            }
            if (rhs.DataType != DataType.@string)
            {
                throw new Exception($"Right-hand-side claim {rhs.Id} must be of type string");
            }
            if (skew < 0)
            {
                throw new Exception($"Skew value must be equal to or greater than zero. Value passed is {skew}.");
            }
        }
    }
}