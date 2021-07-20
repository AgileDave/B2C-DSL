using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class claimMask
    {
        [XmlAttributeAttribute()]
        public MaskType Type { get; set; }
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Regex { get; set; }
        /// <remarks/>
        [XmlTextAttribute()]
        public string Value { get; set; }
    }
}