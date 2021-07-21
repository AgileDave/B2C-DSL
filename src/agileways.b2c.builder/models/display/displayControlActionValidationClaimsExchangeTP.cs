using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.display
{
    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControlActionValidationClaimsExchangeTechnicalProfile
    {
        /// <remarks/>
        [XmlArrayItem("Precondition", IsNullable = false)]
        public Precondition[][] Preconditions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TechnicalProfileReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ContinueOnSuccess { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ContinueOnSuccessSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ContinueOnError { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ContinueOnErrorSpecified { get; set; }
    }
}