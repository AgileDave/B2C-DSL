using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateValidationReference
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }
}