using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{

    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class TrustFrameworkPolicy
    {
        public BasePolicy BasePolicy { get; set; }
        [XmlArrayItemAttribute(IsNullable = false)]
        public Contact[] Contacts { get; set; }
        [XmlArrayItemAttribute(IsNullable = false)]
        public DocumentReference[] DocumentReferences { get; set; }
        [XmlAttributeAttribute()]
        public string PolicySchemaVersion { get; set; }
        [XmlAttributeAttribute()]
        public string TenantId { get; set; }
        [XmlAttributeAttribute()]
        public string TenantObjectId { get; set; }
        [XmlAttributeAttribute()]
        public string PolicyId { get; set; }
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string PublicPolicyUri { get; set; }
        [XmlAttributeAttribute()]
        public string StateTableName { get; set; }
        [XmlAttributeAttribute()]
        public DeploymentModeType DeploymentMode { get; set; }
        [XmlAttributeAttribute()]
        public bool DeploymentModeSpecified { get; set; }
        public BuildingBlocks BuildingBlocks { get; set; }
        [XmlAttributeAttribute()]
        public string UserJourneyRecorderEndpoint { get; set; }
    }
}