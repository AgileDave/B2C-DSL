using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SingleSignOn
    {
        /// <remarks/>
        [XmlAttribute()]
        public UserJourneyBehaviorScope Scope { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public int KeepAliveInDays { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool KeepAliveInDaysSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public bool EnforceIdTokenHintOnLogout { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool EnforceIdTokenHintOnLogoutSpecified { get; set; }
    }
}