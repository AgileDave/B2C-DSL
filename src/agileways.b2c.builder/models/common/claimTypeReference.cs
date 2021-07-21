using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimTypeReference
    {
        /// <remarks/>
        [XmlElementAttribute("From")]
        public TechnicalProfileReference[] From { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string PartnerClaimType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool Required { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool RequiredSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string DefaultValue { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool AlwaysUseDefaultValue { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool AlwaysUseDefaultValueSpecified { get; set; }
    }

}