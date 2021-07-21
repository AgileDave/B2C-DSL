using System.Xml.Serialization;

namespace agileways.b2c.builder.models.display
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DisplayControlAction
    {
        /// <remarks/>
        [XmlArrayItem("ValidationClaimsExchangeTechnicalProfile", IsNullable = false)]
        public DisplayControlActionValidationClaimsExchangeTechnicalProfile[] ValidationClaimsExchange { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }
}