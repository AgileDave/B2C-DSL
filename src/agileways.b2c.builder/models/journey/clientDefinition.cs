using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{
    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class UserJourneyClientDefinition
    {
        /// <remarks/>
        [XmlAttribute]
        public string ReferenceId { get; set; }
    }


}