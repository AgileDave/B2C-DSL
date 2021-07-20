using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class SupportedLanguages
    {
        /// <remarks/>
        [XmlElementAttribute("SupportedLanguage")]
        public string[] SupportedLanguage { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string DefaultLanguage { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string PolicyLanguage { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public MergeBehavior MergeBehavior { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified { get; set; }
    }

}