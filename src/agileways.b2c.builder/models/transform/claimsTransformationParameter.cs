using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.transform
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimsTransformationParameter
    {
        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public DataType DataType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Value { get; set; }
    }

}