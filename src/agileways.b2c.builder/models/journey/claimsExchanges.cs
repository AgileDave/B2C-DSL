using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsExchanges
    {
        /// <remarks/>
        [XmlElement("ClaimsExchange")]
        public List<ClaimsExchange> ClaimsExchange { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        [DefaultValue(false)]
        public bool UserIdentity { get; set; }
    }

}