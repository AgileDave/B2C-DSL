using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsExchange
    {
        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TechnicalProfileReferenceId { get; set; }
    }
}