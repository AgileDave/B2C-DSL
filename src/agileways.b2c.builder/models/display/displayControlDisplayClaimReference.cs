using System.Xml.Serialization;

namespace agileways.b2c.builder.models.display
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControlDisplayClaimReference
    {

        /// <remarks/>
        [XmlAttribute]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ControlClaimType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool Required { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool RequiredSpecified { get; set; }
    }

}