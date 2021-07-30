using System.Collections.Generic;
using System.Linq;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.journey;

namespace agileways.b2c.builder.extensions
{
    public static class OrchestrationStepBuilder
    {

        public static OrchestrationStep Init(int order, OrchestrationStepType type)
        {
            return new OrchestrationStep
            {
                Order = order,
                Type = type
            };
        }

        public static OrchestrationStep Init(int order, OrchestrationStepType type, string contentDefinitionRefId)
        {
            return new OrchestrationStep
            {
                Order = order,
                Type = type,
                ContentDefinitionReferenceId = contentDefinitionRefId
            };
        }

        public static OrchestrationStep InitIssuerStep(int order, OrchestrationStepType type, string issuerTechnicalRefId)
        {
            return new OrchestrationStep
            {
                Order = order,
                Type = type,
                CpimIssuerTechnicalProfileReferenceId = issuerTechnicalRefId
            };
        }

        public static OrchestrationStep AddClaimsProviderSelection(this OrchestrationStep step, string validationClaimsExchangeId = "", string targetClaimsExchangeId = "")
        {
            if (step.ClaimsProviderSelections == null)
            {
                step.ClaimsProviderSelections = new ClaimsProviderSelections();
                step.ClaimsProviderSelections.ClaimsProviderSelection = new List<ClaimsProviderSelection>();
            }

            if (!string.IsNullOrWhiteSpace(validationClaimsExchangeId))
            {
                step.ClaimsProviderSelections.ClaimsProviderSelection.Add(new ClaimsProviderSelection
                {
                    ValidationClaimsExchangeId = validationClaimsExchangeId
                });
            }

            if (!string.IsNullOrWhiteSpace(targetClaimsExchangeId))
            {
                step.ClaimsProviderSelections.ClaimsProviderSelection.Add(new ClaimsProviderSelection
                {
                    TargetClaimsExchangeId = targetClaimsExchangeId
                });
            }

            return step;
        }

        public static OrchestrationStep AddClaimsExchange(this OrchestrationStep step, string id, string technicalProfileRefId)
        {
            if (step.ClaimsExchanges == null)
            {
                step.ClaimsExchanges = new ClaimsExchanges();
                step.ClaimsExchanges.ClaimsExchange = new List<ClaimsExchange>();
            }

            step.ClaimsExchanges.ClaimsExchange.Add(new ClaimsExchange
            {
                Id = id,
                TechnicalProfileReferenceId = technicalProfileRefId
            });

            return step;
        }

        public static OrchestrationStep AddPrecondition(this OrchestrationStep step,
                        PreconditionType type,
                        bool executeActionIf,
                        PreconditionActionType action,
                        params string[] values)
        {

            if (step.Preconditions == null)
            {
                step.Preconditions = new List<Precondition>();
            }

            step.Preconditions.Add(new Precondition
            {
                Action = action,
                ExecuteActionsIf = executeActionIf,
                Type = type,
                Value = values.ToList()
            });

            return step;
        }
    }
}