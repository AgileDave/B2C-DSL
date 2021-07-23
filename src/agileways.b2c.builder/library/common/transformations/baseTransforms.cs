using System.Collections.Generic;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.transform;

namespace agileways.b2c.builder.library.common.transformations
{

    public static class BaseTransforms
    {
        public static ClaimsTransformation CreateOtherMailsFromEmail
        {
            get => new ClaimsTransformation
            {
                Id = "CreateOtherMailsFromEmail",
                TransformationMethod = "AddItemToStringCollection",
                InputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.Email.Id,"item"),
                    new ClaimsTransformationClaimTypeReference(BaseClaims.OtherMails.Id, "collection")
                },
                OutputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.OtherMails.Id, "collection")
                }
            };
        }

        public static ClaimsTransformation CreateRandomUPNUserName
        {
            get => new ClaimsTransformation
            {
                Id = "CreateRandomUPNUserName",
                TransformationMethod = "CreateRandomString",
                InputParameters = new List<ClaimsTransformationParameter> {
                    new ClaimsTransformationParameter { Id = "randomGeneratorType", DataType = DataType.@string, Value = "GUID"},
                },
                OutputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.UpnUserName.Id, "outputClaim")
                }
            };
        }

        public static ClaimsTransformation CreateUserPrincipalName
        {
            get => new ClaimsTransformation
            {
                Id = "CreateUserPrincipalName",
                TransformationMethod = "FormatStringClaim",
                InputClaims = new List<ClaimsTransformationClaimTypeReference>{
                    new ClaimsTransformationClaimTypeReference(BaseClaims.UpnUserName.Id, "inputClaim")
                },
                InputParameters = new List<ClaimsTransformationParameter> {
                    new ClaimsTransformationParameter { Id = "stringFormat", DataType = DataType.@string, Value = "cpim_{0}@{RelyingPartyTenantId}" }
                },
                OutputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.UserPrincipalName.Id, "outputClaim")
                }
            };
        }

        public static ClaimsTransformation CreateAlternativeSecurityId
        {
            get => new ClaimsTransformation
            {
                Id = "CreateAlternativeSecurityId",
                TransformationMethod = "CreateAlternativeSecurityId",
                InputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.IssuerUserId.Id, "key"),
                    new ClaimsTransformationClaimTypeReference(BaseClaims.IdentityProvider.Id, "identityProvider")
                },
                OutputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.AlternativeSecurityId.Id, "alternativeSecurityId")
                }
            };
        }

        public static ClaimsTransformation CreateSubjectClaimFromAlternativeSecurityId
        {
            get => new ClaimsTransformation
            {
                Id = "CreateSubjectClaimFromAlternativeSecurityId",
                TransformationMethod = "CreateStringClaim",
                InputParameters = new List<ClaimsTransformationParameter> {
                    new ClaimsTransformationParameter {Id = "value", DataType = DataType.@string, Value = "Not supported currently. Use oid claim."}
                },
                OutputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.Subject.Id, "createdClaim")
                }
            };
        }

        public static ClaimsTransformation AssertAccountEnabledIsTrue
        {
            get => new ClaimsTransformation
            {
                Id = "AssertAccountEnabledIsTrue",
                TransformationMethod = "AssertBooleanClaimIsEqualToValue",
                InputClaims = new List<ClaimsTransformationClaimTypeReference> {
                    new ClaimsTransformationClaimTypeReference(BaseClaims.AccountEnabled.Id, "inputClaim")
                },
                InputParameters = new List<ClaimsTransformationParameter> {
                    new ClaimsTransformationParameter { Id = "valueToCompareTo", DataType = DataType.boolean, Value = "true" }
                }
            };
        }
    }
}