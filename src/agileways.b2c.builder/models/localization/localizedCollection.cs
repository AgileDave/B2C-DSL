using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedCollection
    {
        /// <remarks/>
        [XmlElement("Item")]
        public EnumerationItem[] Item { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ElementType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ElementId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TargetCollection { get; set; }
    }

}