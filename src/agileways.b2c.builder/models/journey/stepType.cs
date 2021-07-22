using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum OrchestrationStepType
    {

        /// <remarks/>
        ConsentScreen,

        /// <remarks/>
        ClaimsProviderSelection,

        /// <remarks/>
        CombinedSignInAndSignUp,

        /// <remarks/>
        ClaimsExchange,

        /// <remarks/>
        ReviewScreen,

        /// <remarks/>
        SendClaims,

        /// <remarks/>
        GetClaims,

        /// <remarks/>
        UserDialog,

        /// <remarks/>
        InvokeSubJourney,

        /// <remarks/>
        Noop,
    }

}