using System.Xml.Serialization;

namespace agileways.b2c.builder.models.display
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControlClaimTypeReference
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool Required { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RequiredSpecified { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string DefaultValue { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool AlwaysUseDefaultValue { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool AlwaysUseDefaultValueSpecified { get; set; }
    }

}