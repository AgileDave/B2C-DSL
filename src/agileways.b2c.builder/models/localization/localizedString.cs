using System.Xml.Serialization;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedString
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ElementType { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ElementId { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string StringId { get; set; }

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value { get; set; }
    }

}