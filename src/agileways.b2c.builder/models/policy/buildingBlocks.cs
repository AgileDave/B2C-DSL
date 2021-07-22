using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.content;
using agileways.b2c.builder.models.predicate;

namespace agileways.b2c.builder.models.policy
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class BuildingBlocks
    {
        [XmlArrayItem(IsNullable = false)]
        public List<ClaimType> ClaimsSchema { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<Predicate> Predicates { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<InputValidation> InputValidations { get; set; }


        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<PredicateValidation> PredicateValidations { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<ClaimsTransformation> ClaimsTransformations { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<ClientDefinition> ClientDefinitions { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<ContentDefinition> ContentDefinitions { get; set; }

        /// <remarks/>
        public BuildingBlocksLocalization Localization { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<DisplayControl> DisplayControls { get; set; }
    }
}