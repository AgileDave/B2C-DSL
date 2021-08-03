using System;
using System.Collections.Generic;
using System.Linq;
using agileways.b2c.builder.library.common.techProfiles;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.content;
using agileways.b2c.builder.models.journey;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.extensions
{
    public static class OrchestrationStepBuilder
    {

        public static OrchestrationStep AsClaimsExchange { get => new OrchestrationStep { Type = OrchestrationStepType.ClaimsExchange }; }
        public static OrchestrationStep AsJwtIssuer
        {
            get => new OrchestrationStep
            {
                Type = OrchestrationStepType.SendClaims,
                CpimIssuerTechnicalProfileReferenceId = BaseTokenIssuerTechnicalProfiles.JwtIssuer.Id
            };
        }
        public static OrchestrationStep AsCombinedSignInSignUp { get => new OrchestrationStep { Type = OrchestrationStepType.CombinedSignInAndSignUp }; }

        public static OrchestrationStep UsingContentDefinition(this OrchestrationStep step, ContentDefinition definition)
        {
            step.ContentDefinitionReferenceId = definition.Id;
            return step;
        }

        public static OrchestrationStep Init(OrchestrationStepType type)
        {
            return new OrchestrationStep
            {
                Type = type
            };
        }

        public static OrchestrationStep Init(OrchestrationStepType type, ContentDefinition contentDefinition)
        {
            return new OrchestrationStep
            {
                Type = type,
                ContentDefinitionReferenceId = contentDefinition.Id
            };
        }

        public static OrchestrationStep Init(OrchestrationStepType type, ContentDefinition contentDefinition, int order)
        {
            return new OrchestrationStep
            {
                Order = order,
                Type = type,
                ContentDefinitionReferenceId = contentDefinition.Id
            };
        }

        public static OrchestrationStep InitIssuerStep(OrchestrationStepType type, TechnicalProfile issuer)
        {
            return new OrchestrationStep
            {
                Type = type,
                CpimIssuerTechnicalProfileReferenceId = issuer.Id
            };
        }

        public static OrchestrationStep InitIssuerStep(OrchestrationStepType type, TechnicalProfile issuer, int order)
        {
            return new OrchestrationStep
            {
                Order = order,
                Type = type,
                CpimIssuerTechnicalProfileReferenceId = issuer.Id
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

        public static OrchestrationStep AddClaimsExchange(this OrchestrationStep step, string id, TechnicalProfile technicalProfile)
        {
            if (step.ClaimsExchanges == null)
            {
                step.ClaimsExchanges = new ClaimsExchanges();
                step.ClaimsExchanges.ClaimsExchange = new List<ClaimsExchange>();
            }

            step.ClaimsExchanges.ClaimsExchange.Add(new ClaimsExchange
            {
                Id = id,
                TechnicalProfileReferenceId = technicalProfile.Id
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

        public static OrchestrationStep WithClaimsEqualsPrecondition(this OrchestrationStep step,
                                                                    bool executeActionIf = true,
                                                                    PreconditionActionType actionType = PreconditionActionType.SkipThisOrchestrationStep,
                                                                    params string[] values)
        {
            if (step.Preconditions == null)
            {
                step.Preconditions = new List<Precondition>();
            }
            step.Preconditions.Add(new Precondition
            {
                Action = actionType,
                ExecuteActionsIf = executeActionIf,
                Type = PreconditionType.ClaimEquals,
                Value = values.ToList()
            });
            return step;
        }

        public static OrchestrationStep WithClaimsExistsPrecondition(this OrchestrationStep step,
                                                                    bool executeActionIf = true,
                                                                    PreconditionActionType actionType = PreconditionActionType.SkipThisOrchestrationStep,
                                                                    params string[] values)
        {
            if (step.Preconditions == null)
            {
                step.Preconditions = new List<Precondition>();
            }
            step.Preconditions.Add(new Precondition
            {
                Action = actionType,
                ExecuteActionsIf = executeActionIf,
                Type = PreconditionType.ClaimsExist,
                Value = values.ToList()
            });
            return step;
        }

        public static OrchestrationStep WithClaimsEqualsPrecondition(this OrchestrationStep step,
                                                                    ClaimType claim, string value)
        {
            return WithClaimsEqualsPrecondition(step, new string[] { claim.Id, value });
        }

        public static OrchestrationStep WithClaimsEqualsPrecondition(this OrchestrationStep step,
                                                                    params string[] values)
        {
            if (step.Preconditions == null)
            {
                step.Preconditions = new List<Precondition>();
            }
            step.Preconditions.Add(new Precondition
            {
                Action = PreconditionActionType.SkipThisOrchestrationStep,
                ExecuteActionsIf = true,
                Type = PreconditionType.ClaimEquals,
                Value = values.ToList()
            });
            return step;
        }

        public static OrchestrationStep WithClaimsExistsPrecondition(this OrchestrationStep step,
                                                                    params ClaimType[] claims)
        {
            return WithClaimsExistsPrecondition(step, claims.Select(c => c.Id).ToArray());
        }

        public static OrchestrationStep WithClaimsExistsPrecondition(this OrchestrationStep step,
                                                                    params string[] values)
        {
            if (step.Preconditions == null)
            {
                step.Preconditions = new List<Precondition>();
            }
            step.Preconditions.Add(new Precondition
            {
                Action = PreconditionActionType.SkipThisOrchestrationStep,
                ExecuteActionsIf = true,
                Type = PreconditionType.ClaimsExist,
                Value = values.ToList()
            });
            return step;
        }

        public static OrchestrationStep xAddClaimsEqualsPrecondition(this OrchestrationStep step,
            bool executeActionIf, PreconditionActionType actionType, params string[] values)
        {
            if (step.Preconditions == null)
            {
                step.Preconditions = new List<Precondition>();
            }
            step.Preconditions.Add(new Precondition
            {
                Action = actionType,
                ExecuteActionsIf = executeActionIf,
                Type = PreconditionType.ClaimEquals,
                Value = values.ToList()
            });
            return step;
        }
    }
}