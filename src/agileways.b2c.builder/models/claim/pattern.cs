using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Pattern
    {

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RegularExpression { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string HelpText { get; set; }
    }
}