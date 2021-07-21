using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class JourneyOnError
    {
        /// <remarks/>
        [XmlAttribute]
        public JourneyOnErrorMode Mode { get; set; }
    }

}