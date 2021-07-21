using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class Contact
    {
        public string DisplayName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        [XmlAttribute]
        public string Id { get; set; }
        public Contact() { }
        public Contact(string id, string displayName, string email, string role = "", string tele = "")
        {
            Id = id;
            DisplayName = displayName;
            Email = email;
            Role = role;
            TelephoneNumber = tele;
        }
    }
}