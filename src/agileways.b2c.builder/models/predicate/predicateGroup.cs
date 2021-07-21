using System.Xml.Serialization;

namespace agileways.b2c.builder.models.predicate
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateGroup
    {
        /// <remarks/>
        public string UserHelpText { get; set; }

        /// <remarks/>
        [XmlElement("PredicateReferences")]
        public PredicateReferences[] PredicateReferences { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }

}