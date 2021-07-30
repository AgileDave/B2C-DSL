using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Precondition
    {

        /// <remarks/>
        [XmlElement("Value")]
        public List<string> Value { get; set; }

        /// <remarks/>
        [XmlElement("Action")]
        public PreconditionActionType Action { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public PreconditionType Type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ExecuteActionsIf { get; set; }
    }


}