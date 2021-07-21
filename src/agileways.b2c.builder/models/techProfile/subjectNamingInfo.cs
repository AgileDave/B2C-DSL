using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SubjectNamingInfo
    {
        /// <remarks/>
        [XmlAttribute]
        public string ClaimType { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string NameQualifier { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string SPNameQualifier { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Format { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string SPProvidedID { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ExcludeAsClaim { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ExcludeAsClaimSpecified { get; set; }
    }

}