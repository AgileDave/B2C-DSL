using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{

    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class BasePolicy
    {
        public string TenantId { get; set; }
        public string PolicyId { get; set; }
    }


}