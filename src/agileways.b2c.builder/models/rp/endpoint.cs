using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Endpoint
    {
        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string UserJourneyReferenceId { get; set; }
    }


}