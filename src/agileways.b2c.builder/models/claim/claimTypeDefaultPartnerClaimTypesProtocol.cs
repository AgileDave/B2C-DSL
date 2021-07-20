using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimTypeDefaultPartnerClaimTypesProtocol
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public ProtocolName Name { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Handler { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string PartnerClaimType { get; set; }
    }


}