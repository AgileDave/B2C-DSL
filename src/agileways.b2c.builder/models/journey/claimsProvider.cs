using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.models.policy
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsProvider
    {
        /// <remarks/>
        [XmlArrayItem("Domain", IsNullable = false)]
        public List<string> Domains { get; set; }

        /// <remarks/>
        public string Domain { get; set; }

        /// <remarks/>
        public string DisplayName { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<TechnicalProfile> TechnicalProfiles { get; set; }
    }

}