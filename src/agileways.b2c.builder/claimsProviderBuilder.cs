
using System.Collections.Generic;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.extensions
{

    public static class ClaimsProviderBuilder
    {
        public static ClaimsProvider Init(string displayName, string domain = "")
        {
            var cp = new ClaimsProvider
            {
                DisplayName = displayName
            };
            if (!string.IsNullOrWhiteSpace(domain))
            {
                cp.Domain = domain;
            }
            return cp;
        }

        public static ClaimsProvider AddTechnicalProfile(this ClaimsProvider cp, TechnicalProfile tp)
        {
            cp.TechnicalProfiles.Add(tp);
            return cp;
        }
    }
}