using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsProviderSelection
    {
        /// <remarks/>
        [XmlAttribute]
        public string TargetClaimsExchangeId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ValidationClaimsExchangeId { get; set; }
    }

}