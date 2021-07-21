using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Extensions
    {
        /// <remarks/>
        [XmlAnyElement]
        public List<System.Xml.XmlElement> Any { get; set; }
    }

}