using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class JourneyFraming
    {
        /// <remarks/>
        [XmlAttribute]
        public bool Enabled { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Sources { get; set; }
    }

}