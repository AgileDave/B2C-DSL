using System.Xml.Serialization;

namespace agileways.b2c.builder.models.display
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControlClaimTypeReference
    {
        /// <remarks/>
        [XmlAttribute]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool Required { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RequiredSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string DefaultValue { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool AlwaysUseDefaultValue { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AlwaysUseDefaultValueSpecified { get; set; }
    }

}