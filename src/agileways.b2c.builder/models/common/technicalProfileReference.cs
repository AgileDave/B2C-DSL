using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileReference
    {
        /// <remarks/>
        [XmlAttribute]
        public string TechnicalProfileReferenceId { get; set; }
    }

}