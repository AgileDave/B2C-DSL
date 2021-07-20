using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum MaskType
    {

        /// <remarks/>
        Simple,

        /// <remarks/>
        Regex,
    }
}