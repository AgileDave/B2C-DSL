using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{

    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class UserJourneyBehaviors
    {
        /// <remarks/>
        public SingleSignOn SingleSignOn { get; set; }

        /// <remarks/>
        public SessionExpiryType SessionExpiryType { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SessionExpiryTypeSpecified { get; set; }

        /// <remarks/>
        public int SessionExpiryInSeconds { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SessionExpiryInSecondsSpecified { get; set; }

        /// <remarks/>
        public AzureApplicationInsights AzureApplicationInsights { get; set; }

        /// <remarks/>
        public JourneyInsights JourneyInsights { get; set; }

        /// <remarks/>
        [XmlArrayItem("Parameter", IsNullable = false)]
        public List<ContentDefinitionParameter> ContentDefinitionParameters { get; set; }

        /// <remarks/>
        public JourneyFraming JourneyFraming { get; set; }

        /// <remarks/>
        public ScriptExecution ScriptExecution { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool ScriptExecutionSpecified { get; set; }

        /// <remarks/>
        public JourneyOnError OnError { get; set; }
    }

}