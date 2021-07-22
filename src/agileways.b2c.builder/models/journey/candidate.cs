using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Candidate
    {
        /// <remarks/>
        [XmlAttribute]
        public string SubJourneyReferenceId { get; set; }
    }

}