
using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.journey;

namespace agileways.b2c.builder.models.policy
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SubJourney
    {
        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<OrchestrationStep> OrchestrationSteps { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public SubJourneyType Type { get; set; }
    }

}