using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum ProtocolName
    {

        /// <remarks/>
        None,

        /// <remarks/>
        OAuth1,

        /// <remarks/>
        OAuth2,

        /// <remarks/>
        SAML2,

        /// <remarks/>
        OpenIdConnect,

        /// <remarks/>
        WsFed,

        /// <remarks/>
        WsTrust,

        /// <remarks/>
        UProve11,

        /// <remarks/>
        Proprietary,
    }
}