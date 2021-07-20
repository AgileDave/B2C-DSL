using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum DataType
    {

        /// <remarks/>
        boolean,

        /// <remarks/>
        date,

        /// <remarks/>
        dateTime,

        /// <remarks/>
        duration,

        /// <remarks/>
        @int,

        /// <remarks/>
        @long,

        /// <remarks/>
        @string,

        /// <remarks/>
        stringCollection,

        /// <remarks/>
        alternativeSecurityIdCollection,

        /// <remarks/>
        userIdentityCollection,

        /// <remarks/>
        userIdentity,

        /// <remarks/>
        phoneNumber,

        /// <remarks/>
        objectIdentityCollection,

        /// <remarks/>
        objectIdentity,
    }
}