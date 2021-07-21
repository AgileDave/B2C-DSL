using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum TokenFormat
    {

        /// <remarks/>
        JSON,

        /// <remarks/>
        JWT,

        /// <remarks/>
        SAML11,

        /// <remarks/>
        SAML2,

        /// <remarks/>
        CpimUnsigned,

        /// <remarks/>
        UProve11,

        /// <remarks/>
        OAuth2Error,
    }

}