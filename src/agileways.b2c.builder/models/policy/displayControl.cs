using System.Xml.Serialization;
using agileways.b2c.builder.models.display;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControl
    {

        /// <remarks/>
        [XmlArrayItem("InputClaim", IsNullable = false)]
        public DisplayControlClaimTypeReference[] InputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("DisplayClaim", IsNullable = false)]
        public DisplayControlDisplayClaimReference[] DisplayClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("OutputClaim", IsNullable = false)]
        public DisplayControlClaimTypeReference[] OutputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("Action", IsNullable = false)]
        public DisplayControlAction[] Actions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public UserInterfaceControlType UserInterfaceControlType { get; set; }
    }
}