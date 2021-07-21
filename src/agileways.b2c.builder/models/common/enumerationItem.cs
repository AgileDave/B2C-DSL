using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class EnumerationItem
    {

        /// <remarks/>
        [XmlAttribute]
        public string Text { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Value { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool SelectByDefault { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SelectByDefaultSpecified { get; set; }

        /// <remarks/>
        [XmlText]
        public string Value1 { get; set; }
    }
}