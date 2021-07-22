
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.library.common.clientDefinitions
{

    public static class BaseClientDefinitions
    {
        public static ClientDefinition DefaultWeb
        {
            get => new ClientDefinition
            {
                Id = "DefaultWeb",
                ClientUIFilterFlags = "LineMarkers, MetaRefresh"
            };
        }
    }
}
