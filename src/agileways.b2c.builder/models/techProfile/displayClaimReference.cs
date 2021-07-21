using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayClaimReference
    {
        /// <remarks/>
        [XmlAttribute]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string DisplayControlReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool Required { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool RequiredSpecified { get; set; }
    }

}