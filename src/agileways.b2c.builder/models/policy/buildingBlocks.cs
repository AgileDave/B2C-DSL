using System.Xml.Serialization;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.content;
using agileways.b2c.builder.models.predicate;

namespace agileways.b2c.builder.models.policy
{

    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class BuildingBlocks
    {
        [XmlArrayItemAttribute(IsNullable = false)]
        public ClaimType[] ClaimsSchema { get; set; }


        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public Predicate[] Predicates { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public InputValidation[] InputValidations { get; set; }


        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public PredicateValidation[] PredicateValidations { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public ClaimsTransformation[] ClaimsTransformations { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public ClientDefinition[] ClientDefinitions { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public ContentDefinition[] ContentDefinitions { get; set; }

        /// <remarks/>
        public BuildingBlocksLocalization Localization { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute(IsNullable = false)]
        public DisplayControl[] DisplayControls { get; set; }



    }
}