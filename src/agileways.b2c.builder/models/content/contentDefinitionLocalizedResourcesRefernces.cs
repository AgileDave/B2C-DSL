using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.content
{


    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ContentDefinitionLocalizedResourcesReferences
    {

        /// <remarks/>
        [XmlElement("LocalizedResourcesReference")]
        public LocalizedResourcesReference[] LocalizedResourcesReference { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public MergeBehavior MergeBehavior { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified { get; set; }
    }

}