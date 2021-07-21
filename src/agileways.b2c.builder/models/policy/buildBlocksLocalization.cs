using System.Xml.Serialization;
using agileways.b2c.builder.models.localization;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class BuildingBlocksLocalization
    {
        /// <remarks/>
        public SupportedLanguages SupportedLanguages { get; set; }

        /// <remarks/>
        [XmlElement("LocalizedResources")]
        public LocalizedResources[] LocalizedResources { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool Enabled { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EnabledSpecified { get; set; }
    }


}