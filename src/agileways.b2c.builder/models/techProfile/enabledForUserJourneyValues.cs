using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum EnabledForUserJourneysValues
    {

        /// <remarks/>
        @true,

        /// <remarks/>
        @false,

        /// <remarks/>
        OnClaimsExistence,

        /// <remarks/>
        Always,

        /// <remarks/>
        Never,

        /// <remarks/>
        OnItemExistenceInStringCollectionClaim,

        /// <remarks/>
        OnItemAbsenceInStringCollectionClaim,
    }

}