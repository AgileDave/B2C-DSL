using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Precondition
    {

        /// <remarks/>
        [XmlElementAttribute("Value")]
        public string[] Value { get; set; }

        /// <remarks/>
        [XmlElementAttribute("Action")]
        public PreconditionActionType[] Action { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public PreconditionType Type { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool ExecuteActionsIf { get; set; }
    }


}