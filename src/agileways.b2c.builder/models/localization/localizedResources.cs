using System.Xml.Serialization;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedResources
    {
        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public LocalizedCollection[] LocalizedCollections { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public LocalizedString[] LocalizedStrings { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Culture { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }

}