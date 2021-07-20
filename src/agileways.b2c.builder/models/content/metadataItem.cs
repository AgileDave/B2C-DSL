using System.Xml.Serialization;

namespace agileways.b2c.builder.models.content
{

    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class metadataItemTYPE
    {

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Key { get; set; }

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
}