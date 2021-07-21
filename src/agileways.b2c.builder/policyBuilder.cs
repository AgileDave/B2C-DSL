using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder.extensions
{

    public static class PolicyBuilder
    {

        public static TrustFrameworkPolicy Init(string policyId, string publicPolicyUri, string tenantId,
                                    DeploymentModeType deployMode = DeploymentModeType.Production,
                                    string policySchemaVersion = "0.3.0.0", string userJourneyRecorderEndpoint = null,
                                    string tenantObjId = null, string stateTableName = null)
        {
            return new TrustFrameworkPolicy(policyId, publicPolicyUri, tenantId, deployMode, policySchemaVersion, userJourneyRecorderEndpoint, tenantObjId, stateTableName);
        }
        public static TrustFrameworkPolicy InheritFrom(this TrustFrameworkPolicy pol, BasePolicy basePol)
        {
            pol.BasePolicy = basePol;
            return pol;
        }

        public static TrustFrameworkPolicy InheritFrom(this TrustFrameworkPolicy pol, TrustFrameworkPolicy basePolicy)
        {
            pol.BasePolicy = new BasePolicy
            {
                PolicyId = basePolicy.PolicyId,
                TenantId = basePolicy.TenantId
            };
            return pol;
        }

        public static TrustFrameworkPolicy AddContact(this TrustFrameworkPolicy pol, Contact c)
        {
            if (pol.Contacts == null)
            {
                pol.Contacts = new List<Contact>();
            }
            pol.Contacts.Add(c);
            return pol;
        }

        public static TrustFrameworkPolicy SetBuildingBlocks(this TrustFrameworkPolicy pol, BuildingBlocks bb)
        {
            pol.BuildingBlocks = bb;
            return pol;
        }

        public static TrustFrameworkPolicy SetRelyingParty(this TrustFrameworkPolicy policy, RelyingParty rp)
        {
            policy.RelyingParty = rp;
            return policy;
        }

        public static string Build(this TrustFrameworkPolicy pol)
        {
            var sb = new StringBuilder();
            XmlWriter w = XmlWriter.Create(sb);
            XmlSerializer s = new XmlSerializer(typeof(TrustFrameworkPolicy));
            s.Serialize(w, pol);
            return sb.ToString();
        }
    }
}