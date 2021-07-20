using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Contact
    {
        public string DisplayName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }
}