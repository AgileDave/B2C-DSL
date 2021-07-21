using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SubjectAuthenticationRequirements
    {
        /// <remarks/>
        [XmlAttribute]
        public int TimeToLive { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool ResetExpiryWhenTokenIssued { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ResetExpiryWhenTokenIssuedSpecified { get; set; }
    }

}