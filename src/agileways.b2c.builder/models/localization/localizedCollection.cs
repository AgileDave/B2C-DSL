using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedCollection
    {
        /// <remarks/>
        [XmlElementAttribute("Item")]
        public EnumerationItem[] Item { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ElementType { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ElementId { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TargetCollection { get; set; }
    }

}