using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.transform;

namespace agileways.b2c.builder.models.policy
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class ClaimsTransformation
    {
        /// <remarks/>
        [XmlArrayItem("InputClaim", IsNullable = false)]
        public List<ClaimsTransformationClaimTypeReference> InputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("InputParameter", IsNullable = false)]
        public List<ClaimsTransformationParameter> InputParameters { get; set; }

        /// <remarks/>
        [XmlArrayItem("OutputClaim", IsNullable = false)]
        public List<ClaimsTransformationClaimTypeReference> OutputClaims { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string TransformationMethod { get; set; }

        public ClaimsTransformation() { }
        public ClaimsTransformation(string id, string transformationMethod)
        {
            Id = id;
            TransformationMethod = transformationMethod;
        }
    }

}