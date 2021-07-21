using System.Xml.Serialization;

namespace agileways.b2c.builder.models.predicate
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Parameter
    {

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlText]
        public string Value { get; set; }
    }
}