using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClientDefinition
    {

        /// <remarks/>
        public string ClientUIFilterFlags { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }
    }

}