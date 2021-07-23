
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile.aad
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]

    public enum Metadata
    {
        /// <remarks> The operation to be performed. Possible values: Read, Write, DeleteClaims, or DeleteClaimsPrincipal. </remarks>
        Operation,
        /// <remarks> Raise an error if the user object does not exist in the directory. Possible values: true or false. </remarks>
        RaiseErrorIfClaimsPrincipalDoesNotExist,
        /// <remarks> Raise an error if the user object already exists. Possible values: true or false. </remarks>
        RaiseErrorIfClaimsPrincipalAlreadyExists,
        /// <remarks> The application object identifier for extension attributes. Value: ObjectId of an application. For more information, see Use custom attributes. </remarks>
        ApplicationObjectId,
        /// <remarks> The client identifier for accessing the tenant as a third party. For more information, see Use custom attributes in a custom profile edit policy </remarks>
        ClientId,
        /// <remarks> For input and output claims, specifies whether claims resolution is included in the technical profile. Possible values: true, or false (default). If you want to use a claims resolver in the technical profile, set this to true. </remarks>
        IncludeClaimResolvingInClaimsHandling,
        /// <remarks> If an error is to be raised (see RaiseErrorIfClaimsPrincipalAlreadyExists attribute description), specify the message to show to the user if user object already exists. </remarks>
        UserMessageIfClaimsPrincipalAlreadyExists,
        /// <remarks> If an error is to be raised (see the RaiseErrorIfClaimsPrincipalDoesNotExist attribute description), specify the message to show to the user if user object does not exist.  </remarks>
        UserMessageIfClaimsPrincipalDoesNotExist,
    }
}