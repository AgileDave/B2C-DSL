using System.Xml.Serialization;

namespace agileways.b2c.builder.models.transform
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimsTransformationClaimTypeReference
    {
        /// <remarks/>
        [XmlAttribute]
        public string ClaimTypeReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TransformationClaimType { get; set; }

        public ClaimsTransformationClaimTypeReference() { }
        public ClaimsTransformationClaimTypeReference(string id, string claimtype)
        {
            ClaimTypeReferenceId = id;
            TransformationClaimType = claimtype;
        }
    }
}