using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class EnumerationItem
    {

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Text { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Value { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool SelectByDefault { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool SelectByDefaultSpecified { get; set; }

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value1 { get; set; }
    }
}