using System.Xml.Serialization;

namespace agileways.b2c.builder.models.localization
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedString
    {
        /// <remarks/>
        [XmlAttribute]
        public string ElementType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ElementId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string StringId { get; set; }

        /// <remarks/>
        [XmlText]
        public string Value { get; set; }
    }

}