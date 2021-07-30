using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.journey
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class OrchestrationStep
    {
        /// <remarks/>
        [XmlArrayItem("Precondition", IsNullable = false)]
        public List<Precondition> Preconditions { get; set; }

        /// <remarks/>
        [XmlElement("ClaimsProviderSelections")]
        public ClaimsProviderSelections ClaimsProviderSelections { get; set; }

        /// <remarks/>
        [XmlElement("ClaimsExchanges")]
        public ClaimsExchanges ClaimsExchanges { get; set; }

        /// <remarks/>
        [XmlArrayItem("Candidate", IsNullable = false)]
        public List<Candidate> JourneyList { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public int Order { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public OrchestrationStepType Type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ContentDefinitionReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string CpimIssuerTechnicalProfileReferenceId { get; set; }
    }

}