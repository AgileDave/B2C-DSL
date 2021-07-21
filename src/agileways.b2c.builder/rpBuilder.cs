using System.Collections.Generic;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.rp;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.extensions
{
    public static class RelyingPartyBuilder
    {
        public static RelyingParty Init(string defaultUserJourney)
        {
            return new RelyingParty
            {
                DefaultUserJourney = new DefaultUserJourney
                {
                    ReferenceId = defaultUserJourney
                }
            };
        }
        public static RelyingParty SetJourneyInsights(this RelyingParty rp, string key, bool developerMode,
                                    TelemetryEngine engine = TelemetryEngine.ApplicationInsights,
                                    bool clientEnabled = false, bool serverEnabled = true,
                                    string telemetryVersion = "1.0.0")
        {
            if (rp.UserJourneyBehaviors == null)
            {
                rp.UserJourneyBehaviors = new UserJourneyBehaviors();
            }

            rp.UserJourneyBehaviors.JourneyInsights = new JourneyInsights
            {
                InstrumentationKey = key,
                TelemetryEngine = engine,
                ClientEnabled = clientEnabled,
                ClientEnabledSpecified = true,
                ServerEnabled = serverEnabled,
                ServerEnabledSpecified = true,
                DeveloperMode = developerMode,
                DeveloperModeSpecified = true,
                TelemetryVersion = telemetryVersion
            };

            return rp;
        }

        public static RelyingParty AddEndpoint(this RelyingParty rp, string id, string userJourneyReferenceId)
        {
            if (rp.Endpoints == null)
            {
                rp.Endpoints = new List<Endpoint>();
            }

            rp.Endpoints.Add(new Endpoint { Id = id, UserJourneyReferenceId = userJourneyReferenceId });

            return rp;
        }

        public static RelyingParty SetBasicJourneyBehaviors(this RelyingParty rp, SessionExpiryType expiryType = SessionExpiryType.Rolling,
                                                        int expiryInSeconds = 86400,
                                                        ScriptExecution scriptExecution = ScriptExecution.Disallow)
        {
            if (rp.UserJourneyBehaviors == null)
            {
                rp.UserJourneyBehaviors = new UserJourneyBehaviors();
            }

            rp.UserJourneyBehaviors.SessionExpiryType = expiryType;
            rp.UserJourneyBehaviors.SessionExpiryTypeSpecified = true;
            rp.UserJourneyBehaviors.SessionExpiryInSeconds = expiryInSeconds;
            rp.UserJourneyBehaviors.SessionExpiryInSecondsSpecified = true;
            rp.UserJourneyBehaviors.ScriptExecution = scriptExecution;
            rp.UserJourneyBehaviors.ScriptExecutionSpecified = true;

            return rp;
        }

        public static RelyingParty SetSsoJourneyBehavior(this RelyingParty rp, UserJourneyBehaviorScope scope = UserJourneyBehaviorScope.Tenant,
                                                            int keepAliveDays = 0,
                                                            bool enforceTokenHintLogout = false)
        {
            if (rp.UserJourneyBehaviors == null)
            {
                rp.UserJourneyBehaviors = new UserJourneyBehaviors();
            }

            rp.UserJourneyBehaviors.SingleSignOn = new SingleSignOn
            {
                Scope = scope,
                KeepAliveInDays = keepAliveDays,
                EnforceIdTokenHintOnLogout = enforceTokenHintLogout,
                KeepAliveInDaysSpecified = true,
                EnforceIdTokenHintOnLogoutSpecified = true
            };

            return rp;
        }

        public static RelyingParty SetTechnicalProfile(this RelyingParty rp, TechnicalProfile tp)
        {
            rp.TechnicalProfile = tp;
            return rp;
        }
    }
}