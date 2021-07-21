using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{


    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class JourneyInsights
    {
        /// <remarks/>
        [XmlAttribute]
        public string InstrumentationKey { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public TelemetryEngine TelemetryEngine { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool DeveloperMode { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DeveloperModeSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ClientEnabled { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ClientEnabledSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ServerEnabled { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ServerEnabledSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TelemetryVersion { get; set; }
    }

}