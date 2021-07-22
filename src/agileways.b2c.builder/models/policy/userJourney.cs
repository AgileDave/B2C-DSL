using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.journey;

namespace agileways.b2c.builder.models.policy
{
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class UserJourney
    {
        /// <remarks/>
        public string AssuranceLevel { get; set; }

        /// <remarks/>
        public bool PreserveOriginalAssertion { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool PreserveOriginalAssertionSpecified { get; set; }

        /// <remarks/>
        public Authorization Authorization { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public List<OrchestrationStep> OrchestrationSteps { get; set; }

        /// <remarks/>
        public UserJourneyClientDefinition ClientDefinition { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("Key", IsNullable = false)]
        public List<CryptographicKey> CryptographicKeys { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool NonInteractive { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool NonInteractiveSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string DefaultCpimIssuerTechnicalProfileReferenceId { get; set; }

    }
}