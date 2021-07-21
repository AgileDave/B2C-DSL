using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DocumentReference
    {
        public string DisplayName { get; set; }
        [XmlElement(DataType = "anyURI")]
        public string Url { get; set; }
        [XmlAttribute]
        public string Id { get; set; }
    }
}