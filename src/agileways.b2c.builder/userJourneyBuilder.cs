using System.Collections.Generic;
using agileways.b2c.builder.library.common.clientDefinitions;
using agileways.b2c.builder.models.journey;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.extensions
{
    public static class UserJourneyBuilder
    {
        public static UserJourney Init(string name)
        {
            return new UserJourney
            {
                Id = name,
                OrchestrationSteps = new List<OrchestrationStep>()
            };
        }

        public static UserJourney AddOrchestrationSteps(this UserJourney uj, params OrchestrationStep[] steps)
        {
            if (uj.OrchestrationSteps == null)
            {
                uj.OrchestrationSteps = new List<OrchestrationStep>();
            }
            uj.OrchestrationSteps.AddRange(steps);
            return uj;
        }

        public static UserJourney AddClientDefinition(this UserJourney uj, ClientDefinition def)
        {
            uj.ClientDefinition = new UserJourneyClientDefinition
            {
                ReferenceId = def.Id
            };
            return uj;
        }

        public static UserJourney AddOrchestrationStep(this UserJourney uj, OrchestrationStep step, bool inferOrder = true)
        {

            if (uj.OrchestrationSteps == null)
            {
                uj.OrchestrationSteps = new List<OrchestrationStep>();
            }

            int stepOrder = uj.OrchestrationSteps.Count + 1;

            if (inferOrder)
            {
                step.Order = stepOrder;
            }

            uj.OrchestrationSteps.Add(step);

            return uj;
        }

        public static UserJourney UsingDefaultWebClientDefinition(this UserJourney uj)
        {
            uj.ClientDefinition = new UserJourneyClientDefinition
            {
                ReferenceId = BaseClientDefinitions.DefaultWeb.Id
            };
            return uj;
        }
    }
}