using System.ComponentModel;
using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.claim
{
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimType
    {
        public string DisplayName { get; set; }
        public DataType DataType { get; set; }
        [XmlIgnoreAttribute()]
        public bool DataTypeSpecified { get; set; }
        [XmlArrayItemAttribute("Protocol", typeof(ClaimTypeDefaultPartnerClaimTypesProtocol), IsNullable = false)]
        public ClaimTypeDefaultPartnerClaimTypesProtocol[][] DefaultPartnerClaimTypes { get; set; }
        public claimMask Mask { get; set; }
        public string AdminHelpText { get; set; }
        public string UserHelpText { get; set; }
        public UserInputType UserInputType { get; set; }
        [XmlIgnoreAttribute()]
        public bool UserInputTypeSpecified { get; set; }
        public Restriction Restriction { get; set; }
        public InputValidationReference InputValidationReference { get; set; }
        public PredicateValidationReference PredicateValidationReference { get; set; }
        [XmlAttributeAttribute()]
        public string Id { get; set; }
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(StatementType.Attribute)]
        public StatementType StatementType { get; set; }

        public ClaimType()
        {
            this.StatementType = StatementType.Attribute;
        }
    }
}