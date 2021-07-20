using System.Xml.Serialization;
using agileways.b2c.builder.models.display;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControl
    {

        /// <remarks/>
        [XmlArrayItemAttribute("InputClaim", IsNullable = false)]
        public DisplayControlClaimTypeReference[] InputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("DisplayClaim", IsNullable = false)]
        public DisplayControlDisplayClaimReference[] DisplayClaims { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("OutputClaim", IsNullable = false)]
        public DisplayControlClaimTypeReference[] OutputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Action", IsNullable = false)]
        public DisplayControlAction[] Actions { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public UserInterfaceControlType UserInterfaceControlType { get; set; }
    }
}