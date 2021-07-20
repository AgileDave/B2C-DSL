using System.Xml.Serialization;

namespace agileways.b2c.builder.models.predicate
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Parameter
    {

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
}