using System.Xml.Serialization;
using agileways.b2c.builder.models.transform;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimsTransformation
    {
        /// <remarks/>
        [XmlArrayItemAttribute("InputClaim", IsNullable = false)]
        public ClaimsTransformationClaimTypeReference[] InputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("InputParameter", IsNullable = false)]
        public ClaimsTransformationParameter[] InputParameters { get; set; }

        /// <remarks/>
        [XmlArrayItemAttribute("OutputClaim", IsNullable = false)]
        public ClaimsTransformationClaimTypeReference[] OutputClaims { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string TransformationMethod { get; set; }
    }

}