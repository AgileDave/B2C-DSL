using System.Xml.Serialization;

namespace agileways.b2c.builder.models.content
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedResourcesReference
    {

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Language { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Url { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string LocalizedResourcesReferenceId { get; set; }
    }

}