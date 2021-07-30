using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    [XmlRoot(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class TrustFrameworkPolicy
    {
        public TrustFrameworkPolicy()
        {
            Contacts = new List<Contact>();
        }
        public TrustFrameworkPolicy(string policyId, string publicPolicyUri, string tenantId,
                                    DeploymentModeType deployMode = DeploymentModeType.Production,
                                    string policySchemaVersion = "0.3.0.0", string userJourneyRecorderEndpoint = null,
                                    string tenantObjId = null, string stateTableName = null)
        {
            PolicyId = policyId;
            PublicPolicyUri = publicPolicyUri;
            TenantId = tenantId;
            DeploymentMode = deployMode;
            DeploymentModeSpecified = true;
            PolicySchemaVersion = policySchemaVersion;
            UserJourneyRecorderEndpoint = userJourneyRecorderEndpoint;
            TenantObjectId = tenantObjId;
            StateTableName = stateTableName;
        }
        public BasePolicy BasePolicy { get; set; }
        [XmlArrayItem(IsNullable = false)]
        public List<Contact> Contacts { get; set; }
        [XmlArrayItem(IsNullable = false)]
        public List<DocumentReference> DocumentReferences { get; set; }
        [XmlAttribute]
        public string PolicySchemaVersion { get; set; }
        [XmlAttribute]
        public string TenantId { get; set; }
        [XmlAttribute]
        public string TenantObjectId { get; set; }
        [XmlAttribute]
        public string PolicyId { get; set; }
        [XmlAttribute(DataType = "anyURI")]
        public string PublicPolicyUri { get; set; }
        [XmlAttribute]
        public string StateTableName { get; set; }
        [XmlAttribute]
        public DeploymentModeType DeploymentMode { get; set; }
        [XmlIgnore]
        public bool DeploymentModeSpecified { get; set; }
        [XmlAttribute]
        public string UserJourneyRecorderEndpoint { get; set; }
        public BuildingBlocks BuildingBlocks { get; set; }
        [XmlArrayItemAttribute(IsNullable = false)]
        public List<ClaimsProvider> ClaimsProviders { get; set; }
        [XmlArrayItemAttribute(IsNullable = false)]
        public List<UserJourney> UserJourneys { get; set; }
        [XmlArrayItemAttribute(IsNullable = false)]
        public List<SubJourney> SubJourneys { get; set; }
        public RelyingParty RelyingParty { get; set; }
    }
}