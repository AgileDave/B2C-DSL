using System.Xml.Serialization;

namespace agileways.b2c.builder.models.predicate
{


    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Predicate
    {

        /// <remarks/>
        public string UserHelpText { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public Parameter[] Parameters { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Method { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string HelpText { get; set; }
    }
}