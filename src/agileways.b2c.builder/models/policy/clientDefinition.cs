using System.Xml.Serialization;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClientDefinition
    {

        /// <remarks/>
        public string ClientUIFilterFlags { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }

}