using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class metadataItem
    {
        /// <remarks/>
        [XmlAttribute]
        public string Key { get; set; }

        /// <remarks/>
        [XmlText]
        public string Value { get; set; }
    }

}