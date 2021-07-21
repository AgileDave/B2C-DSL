using System.Xml.Serialization;

namespace agileways.b2c.builder.models.content
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class metadataItemTYPE
    {

        /// <remarks/>
        [XmlAttribute]
        public string Key { get; set; }

        /// <remarks/>
        [XmlText]
        public string Value { get; set; }
    }
}