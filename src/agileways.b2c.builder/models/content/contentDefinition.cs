using System.Xml.Serialization;

namespace agileways.b2c.builder.models.content
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ContentDefinition
    {

        /// <remarks/>
        public object LoadUri { get; set; }

        /// <remarks/>
        public string RecoveryUri { get; set; }

        /// <remarks/>
        public string DataUri { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Item", IsNullable = false)]
        public metadataItemTYPE[] Metadata { get; set; }

        /// <remarks/>
        public ContentDefinitionLocalizedResourcesReferences LocalizedResourcesReferences { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }
}