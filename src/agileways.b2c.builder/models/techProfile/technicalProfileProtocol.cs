using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileProtocol
    {
        /// <remarks/>
        [XmlAttribute]
        public ProtocolName Name { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Handler { get; set; }
    }

}