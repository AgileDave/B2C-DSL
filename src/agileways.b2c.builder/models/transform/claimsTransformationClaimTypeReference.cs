using System.Xml.Serialization;

namespace agileways.b2c.builder.models.transform
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimsTransformationClaimTypeReference
    {
        /// <remarks/>
        [XmlAttributeAttribute()]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TransformationClaimType { get; set; }
    }
}