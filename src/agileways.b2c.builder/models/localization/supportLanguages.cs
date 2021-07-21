using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class SupportedLanguages
    {
        /// <remarks/>
        [XmlElement("SupportedLanguage")]
        public string[] SupportedLanguage { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string DefaultLanguage { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string PolicyLanguage { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public MergeBehavior MergeBehavior { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified { get; set; }
    }

}