using System.Xml.Serialization;

namespace agileways.b2c.builder.models.predicate
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateReference
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id { get; set; }
    }
}