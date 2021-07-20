using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.transform
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimsTransformationParameter
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DataType DataType { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Value { get; set; }
    }

}