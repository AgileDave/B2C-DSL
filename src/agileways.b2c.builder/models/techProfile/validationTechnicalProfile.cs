using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ValidationTechnicalProfile
    {
        /// <remarks/>
        [XmlArrayItemAttribute("Precondition", IsNullable = false)]
        public List<Precondition> Preconditions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string ReferenceId { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ContinueOnSuccess { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ContinueOnSuccessSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ContinueOnError { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ContinueOnErrorSpecified { get; set; }
    }

}