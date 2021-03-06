using System;
using System.Collections.Generic;
using System.IO;
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

        public static TrustFrameworkPolicy AddContacts(this TrustFrameworkPolicy pol, params Contact[] c)
        {
            if (pol.Contacts == null)
            {
                pol.Contacts = new List<Contact>();
            }

            if (c == null || c.Length == 0)
            {
                return pol;
            }
            pol.Contacts.AddRange(c);
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

        public static TrustFrameworkPolicy SetClaimsProviders(this TrustFrameworkPolicy pol, params ClaimsProvider[] cps)
        {
            pol.ClaimsProviders = cps.ToList();
            return pol;
        }

        public static TrustFrameworkPolicy SetUserJourneys(this TrustFrameworkPolicy pol, params UserJourney[] journeys)
        {
            pol.UserJourneys = journeys.ToList();
            return pol;
        }

        public static string Build(this TrustFrameworkPolicy pol)
        {
            var xsNamespaces = new XmlSerializerNamespaces();
            xsNamespaces.Add("", "http://schemas.microsoft.com/online/cpim/schemas/2013/06");
            xsNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xsNamespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");

            var sb = new StringBuilder();
            var xmlSettings = new XmlWriterSettings { Indent = true, IndentChars = "  " };

            var w = XmlWriter.Create(sb, xmlSettings);
            var s = new XmlSerializer(typeof(TrustFrameworkPolicy));
            s.Serialize(w, pol, xsNamespaces);
            return sb.ToString();
        }

        public static string BuildToFile(this TrustFrameworkPolicy pol, string filePath)
        {
            var xsNamespaces = new XmlSerializerNamespaces();
            xsNamespaces.Add("", "http://schemas.microsoft.com/online/cpim/schemas/2013/06");
            xsNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xsNamespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");

            var fs = new FileStream($"{filePath}/{pol.PolicyId}.xml", FileMode.OpenOrCreate);
            var xmlSettings = new XmlWriterSettings { Indent = true, IndentChars = "  " };
            var w = XmlWriter.Create(fs, xmlSettings);
            var s = new XmlSerializer(typeof(TrustFrameworkPolicy));


            s.Serialize(w, pol, xsNamespaces);

            return $"{filePath}/{pol.PolicyId}.xml";
        }

        public static string BuildToFile<T>(this TrustFrameworkPolicy pol, string filePath)
        {
            var xsNamespaces = new XmlSerializerNamespaces();
            xsNamespaces.Add("", "http://schemas.microsoft.com/online/cpim/schemas/2013/06");
            xsNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xsNamespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");

            var fs = new FileStream($"{filePath}/{pol.PolicyId}.xml", FileMode.OpenOrCreate);
            var xmlSettings = new XmlWriterSettings { Indent = true, IndentChars = "  " };
            var w = XmlWriter.Create(fs, xmlSettings);
            var s = new XmlSerializer(typeof(TrustFrameworkPolicy));


            s.Serialize(w, pol, xsNamespaces);

            return $"{filePath}/{pol.PolicyId}.xml";
        }
    }
}