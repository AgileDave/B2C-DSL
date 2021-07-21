using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class BasePolicy
    {
        public string TenantId { get; set; }
        public string PolicyId { get; set; }

        public BasePolicy() { }
        public BasePolicy(string policyId, string tenantId)
        {
            PolicyId = policyId;
            TenantId = tenantId;
        }
    }


}