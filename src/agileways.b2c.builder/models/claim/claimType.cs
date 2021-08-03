using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.claim
{
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimType
    {
        public string DisplayName { get; set; }
        public DataType DataType { get; set; }
        // [XmlIgnoreAttribute()]
        // public bool DataTypeSpecified { get; set; }
        [XmlArrayItem("Protocol", IsNullable = false)]
        public List<PartnerClaimTypesProtocol> DefaultPartnerClaimTypes { get; set; }
        public claimMask Mask { get; set; }
        public string AdminHelpText { get; set; }
        public string UserHelpText { get; set; }
        [XmlElement]
        public UserInputType UserInputType { get; set; }
        [XmlIgnoreAttribute()]
        public bool UserInputTypeSpecified { get; set; }
        public Restriction Restriction { get; set; }
        public InputValidationReference InputValidationReference { get; set; }
        public PredicateValidationReference PredicateValidationReference { get; set; }
        [XmlAttribute]
        public string Id { get; set; }
        [XmlAttribute]
        [DefaultValueAttribute(StatementType.Attribute)]
        public StatementType StatementType { get; set; }

        public ClaimType()
        {
            this.StatementType = StatementType.Attribute;
        }

        public ClaimType(string id, string displayName, string userHelpText, DataType dataType = DataType.@string, UserInputType userInputType = UserInputType.TextBox)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.DataType = dataType;
            this.UserHelpText = userHelpText;
            this.UserInputType = userInputType;
        }
    }
}