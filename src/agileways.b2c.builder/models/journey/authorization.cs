using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{
    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Authorization
    {
        /// <remarks/>
        [XmlArrayItem("AuthorizationTechnicalProfile", IsNullable = false)]
        public List<AuthorizationTechnicalProfile> AuthorizationTechnicalProfiles { get; set; }
    }
}