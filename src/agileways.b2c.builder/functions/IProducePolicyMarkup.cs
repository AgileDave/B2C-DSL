using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.functions
{

    public interface IProducePolicyMarkup
    {
        ClaimsTransformation ToMarkup();
    }
}