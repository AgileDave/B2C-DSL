using System;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.integer
{
    public enum IntegerOps
    {
        LESSTHAN,
        GREATERTHAN,
        EQUAL,
        NOTEQUAL,
        GREATERTHANOREQUAL,
        LESSTHANOREQUAL,
    }
    public class EvaluateNumber : IProducePolicyMarkup
    {
        private readonly string _id, _op;
        private readonly ClaimType _input, _output;
        private readonly int _compareTo;
        private readonly bool _throwError;
        public EvaluateNumber(string id, ClaimType input, ClaimType output, int compareTo, IntegerOps op = IntegerOps.EQUAL, bool throwError = true)
        {
            ValidateInputs(input, output);
            _id = id;
            _input = input;
            _output = output;
            _compareTo = compareTo;
            _op = op.ToString();
            _throwError = throwError;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "AssertNumber")
                    .AcceptingClaim(_input, "inputClaim")
                    .AcceptingParameter("Operator", DataType.@string, _op)
                    .AcceptingParameter("CompareToValue", DataType.@int, _compareTo.ToString())
                    .AcceptingParameter("throwError", DataType.boolean, _throwError.ToString())
                    .ReturnsClaim(_output, "outputClaim");
        }

        private void ValidateInputs(ClaimType input, ClaimType output)
        {
            if (input.DataType != DataType.@int)
            {
                throw new Exception($"Input claim {input.Id} must be of type Integer");
            }
            if (output.DataType != DataType.boolean)
            {
                throw new Exception($"Output claim {output.Id} must be of type Boolean");
            }
        }
    }
}