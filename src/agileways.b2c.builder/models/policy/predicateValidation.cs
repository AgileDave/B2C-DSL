using System.Xml.Serialization;
using agileways.b2c.builder.models.predicate;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateValidation
    {
        /// <remarks/>
        [XmlArrayItemAttribute(typeof(PredicateGroup), IsNullable = false)]
        public PredicateGroup[][] PredicateGroups { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }

}