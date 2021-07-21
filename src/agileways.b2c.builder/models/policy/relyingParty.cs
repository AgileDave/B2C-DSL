using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.rp;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.models.policy
{

    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class RelyingParty
    {
        public RelyingParty() { }
        public RelyingParty(string defaultUserJourney)
        {
            DefaultUserJourney = new DefaultUserJourney { ReferenceId = defaultUserJourney };
        }
        /// <remarks/>
        public DefaultUserJourney DefaultUserJourney { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<Endpoint> Endpoints { get; set; }

        /// <remarks/>
        public UserJourneyBehaviors UserJourneyBehaviors { get; set; }

        /// <remarks/>
        [XmlElement("TechnicalProfile")]
        public TechnicalProfile TechnicalProfile { get; set; }
    }

}