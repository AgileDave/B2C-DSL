using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum PreconditionActionType
    {

        /// <remarks/>
        SkipThisOrchestrationStep,

        /// <remarks/>
        SkipThisValidationTechnicalProfile,
    }
}