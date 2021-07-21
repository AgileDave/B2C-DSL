using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.claim
{


    [XmlType("Protocol", AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PartnerClaimTypesProtocol
    {
        /// <remarks/>
        [XmlAttribute]
        public ProtocolName Name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Handler { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string PartnerClaimType { get; set; }

        public PartnerClaimTypesProtocol() { }
        public PartnerClaimTypesProtocol(ProtocolName name, string partnerClaimType)
        {
            Name = name;
            PartnerClaimType = partnerClaimType;
        }
    }


}