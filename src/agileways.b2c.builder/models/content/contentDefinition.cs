using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.content
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ContentDefinition
    {

        /// <remarks/>
        public object LoadUri { get; set; }

        /// <remarks/>
        public string RecoveryUri { get; set; }

        /// <remarks/>
        public string DataUri { get; set; }

        /// <remarks/>
        [XmlArrayItem("Item", IsNullable = false)]
        public List<MetadataItemType> Metadata { get; set; }

        /// <remarks/>
        public ContentDefinitionLocalizedResourcesReferences LocalizedResourcesReferences { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }
}