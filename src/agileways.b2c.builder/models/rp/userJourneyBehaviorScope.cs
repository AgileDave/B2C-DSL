using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum UserJourneyBehaviorScope
    {

        /// <remarks/>
        Suppressed,

        /// <remarks/>
        TrustFramework,

        /// <remarks/>
        Tenant,

        /// <remarks/>
        Application,

        /// <remarks/>
        Policy,
    }

}