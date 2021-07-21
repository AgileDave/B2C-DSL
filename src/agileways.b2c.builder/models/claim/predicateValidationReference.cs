using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateValidationReference
    {
        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }
}