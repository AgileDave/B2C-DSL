using System.Xml.Serialization;

namespace agileways.b2c.builder.models.content
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class LocalizedResourcesReference
    {

        /// <remarks/>
        [XmlAttribute]
        public string Language { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Url { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string LocalizedResourcesReferenceId { get; set; }
    }

}