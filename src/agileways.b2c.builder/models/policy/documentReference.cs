using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class DocumentReference
    {
        public string DisplayName { get; set; }
        [XmlElementAttribute(DataType = "anyURI")]
        public string Url { get; set; }
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }
}