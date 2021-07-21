using System.Xml.Serialization;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedResources
    {
        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public LocalizedCollection[] LocalizedCollections { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public LocalizedString[] LocalizedStrings { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Culture { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }

}