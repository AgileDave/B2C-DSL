using System.Xml.Serialization;

namespace agileways.b2c.builder.models.predicate
{


    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Predicate
    {

        /// <remarks/>
        public string UserHelpText { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public Parameter[] Parameters { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Method { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string HelpText { get; set; }
    }
}