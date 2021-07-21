using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.claim
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Restriction
    {


        /// <remarks/>
        [XmlElement("Enumeration", typeof(EnumerationItem))]
        [XmlElement("Pattern", typeof(Pattern))]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public MergeBehavior MergeBehavior { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified { get; set; }
    }
}