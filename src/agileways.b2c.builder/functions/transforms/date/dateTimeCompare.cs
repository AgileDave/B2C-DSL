using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions.transforms.date
{
    public class Compare : IProducePolicyMarkup
    {
        private readonly string _id, _operator;
        private readonly ClaimType _lhs, _rhs, _result;
        private readonly int _timespanSeconds;

        public Compare(string id, ClaimType lhs, ClaimType rhs, string op, int timespan, ClaimType result)
        {
            _id = id;
            _lhs = lhs;
            _rhs = rhs;
            _operator = op;
            _timespanSeconds = timespan;
            _result = result;
        }
        public ClaimsTransformation ToMarkup()
        {
            return TransformationBuilder.Init(_id, "DateTimeComparison")
                    .AcceptingClaim(_lhs, "firstDateTime")
                    .AcceptingClaim(_rhs, "secondDateTime")
                    .AcceptingParameter("operator", DataType.@string, _operator)
                    .AcceptingParameter("timeSpanInSeconds", DataType.@int, _timespanSeconds.ToString())
                    .ReturnsClaim(_result, "result");
        }
    }
}