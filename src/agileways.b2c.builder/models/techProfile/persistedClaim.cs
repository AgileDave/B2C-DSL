using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PersistedClaim
    {
        /// <remarks/>
        [XmlAttribute]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string PartnerClaimType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string DefaultValue { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool OverwriteIfExists { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool OverwriteIfExistsSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool AlwaysUseDefaultValue { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool AlwaysUseDefaultValueSpecified { get; set; }
    }

}