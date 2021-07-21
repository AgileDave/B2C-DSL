using System.Collections.Generic;
using System.Xml.Serialization;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.models.techProfile
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfile
    {
        /// <remarks/>
        [XmlArrayItem("Domain", IsNullable = false)]
        public List<string> Domains { get; set; }

        /// <remarks/>
        public string Domain { get; set; }

        /// <remarks/>
        public string DisplayName { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public TechnicalProfileProtocol Protocol { get; set; }

        /// <remarks/>
        public TokenFormat InputTokenFormat { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool InputTokenFormatSpecified { get; set; }

        /// <remarks/>
        public TokenFormat OutputTokenFormat { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool OutputTokenFormatSpecified { get; set; }

        /// <remarks/>
        public string AssuranceLevelOfOutputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("RequiredAssuranceLevelOfInputClaims", IsNullable = false)]
        public List<string> RequiredAssuranceLevelsOfInputClaims { get; set; }

        /// <remarks/>
        public SubjectAuthenticationRequirements SubjectAuthenticationRequirements { get; set; }

        /// <remarks/>
        [XmlArrayItem("Item", IsNullable = false)]
        public List<metadataItem> Metadata { get; set; }

        /// <remarks/>
        [XmlArrayItem("Key", IsNullable = false)]
        public List<CryptographicKey> CryptographicKeys { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<Item> Suppressions { get; set; }

        /// <remarks/>
        public string PreferredBinding { get; set; }

        /// <remarks/>
        public bool IncludeInSso { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool IncludeInSsoSpecified { get; set; }

        /// <remarks/>
        [XmlArrayItem("TechnicalProfile", IsNullable = false)]
        public InputTokenSourcesTechnicalProfile[] InputTokenSources { get; set; }

        /// <remarks/>
        [XmlArrayItem("InputClaimsTransformation", typeof(ClaimsTransformationReference), IsNullable = false)]
        public List<ClaimsTransformationReference> InputClaimsTransformations { get; set; }

        /// <remarks/>
        [XmlArrayItem("InputClaim", IsNullable = false)]
        public List<ClaimTypeReference> InputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("DisplayClaim", IsNullable = false)]
        public List<DisplayClaimReference> DisplayClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem(IsNullable = false)]
        public List<PersistedClaim> PersistedClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("OutputClaim", IsNullable = false)]
        public List<ClaimTypeReference> OutputClaims { get; set; }

        /// <remarks/>
        [XmlArrayItem("OutputClaimsTransformation", IsNullable = false)]
        public List<ClaimsTransformationReference> OutputClaimsTransformations { get; set; }

        /// <remarks/>
        [XmlArrayItem("ValidationTechnicalProfile", IsNullable = false)]
        public List<ValidationTechnicalProfile> ValidationTechnicalProfiles { get; set; }

        /// <remarks/>
        public SubjectNamingInfo SubjectNamingInfo { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        public string IncludeClaimsFromTechnicalProfile { get; set; }

        /// <remarks/>
        public IncludeTechnicalProfile IncludeTechnicalProfile { get; set; }

        /// <remarks/>
        public TechnicalProfileUseTechnicalProfileForSessionManagement UseTechnicalProfileForSessionManagement { get; set; }

        /// <remarks/>
        [XmlArrayItem("ErrorHandler", IsNullable = false)]
        public List<ErrorHandler> ErrorHandlers { get; set; }

        /// <remarks/>
        public EnabledForUserJourneysValues EnabledForUserJourneys { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool EnabledForUserJourneysSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Id { get; set; }
    }

}