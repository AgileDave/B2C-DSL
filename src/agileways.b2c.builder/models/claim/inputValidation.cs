using System.Xml.Serialization;
using agileways.b2c.builder.models.predicate;

namespace agileways.b2c.builder.models.claim
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class InputValidation
    {
        /// <remarks/>
        [XmlElement("PredicateReferences")]
        public PredicateReferences[] PredicateReferences { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }

}