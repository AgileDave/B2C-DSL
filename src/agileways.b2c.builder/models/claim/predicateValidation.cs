using System.Xml.Serialization;
using agileways.b2c.builder.models.predicate;

namespace agileways.b2c.builder.models.claim
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateValidation
    {
        /// <remarks/>
        [XmlArrayItem("PredicateGroup", IsNullable = false)]
        public PredicateGroup[][] PredicateGroups { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }

}