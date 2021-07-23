using System.Collections.Generic;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.transformations;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.techProfiles
{

    public static class BaseAadTechnicalProfiles
    {

        public static TechnicalProfile AadCommon
        {
            get => new TechnicalProfile
            {
                Id = "AAD-Common",
                DisplayName = "Azure Active Directory",
                Protocol = new TechnicalProfileProtocol { Name = ProtocolName.Proprietary, Handler = "Web.TPEngine.Providers.AzureActiveDirectoryProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" },
                CryptographicKeys = new List<CryptographicKey> {
                    new CryptographicKey { Id = "issuer_secret", StorageReferenceId = "B2C_1A_TokenSigningKeyContainer" }
                },
                IncludeInSso = false,
                UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
                {
                    ReferenceId = BaseSessionMgtTechnicalProfiles.NoOp.Id
                }
            };
        }

        public static TechnicalProfile AadUserWriteUsingAlternativeSecurityId
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserWriteUsingAlternativeSecurityId",
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Write" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalAlreadyExists", Value = "true" },
                    new metadataItem { Key = "UserMessageIfClaimsPrincipalAlreadyExists", Value = "You are already registered, please press the back button and sign in instead." },
                },
                IncludeInSso = false,
                InputClaimsTransformations = new List<ClaimsTransformationReference> {
                    new ClaimsTransformationReference { ReferenceId = BaseTransforms.CreateOtherMailsFromEmail.Id }
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AlternativeSecurityId.Id, PartnerClaimType = "alternativeSecurityId", Required = true }
                },
                PersistedClaims = new List<PersistedClaim> {
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.AlternativeSecurityId.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.UserPrincipalName.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.MailNickName.Id, DefaultValue = "unknown" },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.DisplayName.Id , DefaultValue = "unknown"},
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.OtherMails.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.NewUser.Id, PartnerClaimType="newClaimsPrincipalCreated" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.OtherMails.Id },
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id },
                UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
                {
                    ReferenceId = BaseSessionMgtTechnicalProfiles.Aad.Id
                }
            };
        }

        public static TechnicalProfile AadUserReadUsingAlternativeSecurityId
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserReadUsingAlternativeSecurityId",
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Read" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalDoesNotExist", Value = "true" },
                    new metadataItem { Key = "UserMessageIfClaimsPrincipalDoesNotExist", Value = "User does not exist. Please sign up before you can sign in." },
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AlternativeSecurityId.Id, PartnerClaimType = "alternativeSecurityId", Required = true }
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.UserPrincipalName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.DisplayName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.OtherMails.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.GivenName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.Surname.Id },
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id }
            };
        }

        public static TechnicalProfile AadUserReadUsingAlternativeSecurityIdNoError
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserReadUsingAlternativeSecurityId-NoError",
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalDoesNotExist", Value = "false" }
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadUserReadUsingAlternativeSecurityId.Id }
            };
        }

        public static TechnicalProfile AadUserWriteUsingLogonEmail
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserWriteUsingLogonEmail",
                IncludeInSso = false,
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Write" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalAlreadyExists", Value = "true" }
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Email.Id, PartnerClaimType = "signInNames.emailAddress", Required = true }
                },
                PersistedClaims = new List<PersistedClaim> {
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.Email.Id, PartnerClaimType="signInNames.emailAddress" },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.NewPassword.Id, PartnerClaimType="password" },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.DisplayName.Id, DefaultValue="unknown" },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.PasswordPolicies.Id, DefaultValue="DisablePasswordExpiration" },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.NewUser.Id, PartnerClaimType="newClaimsPrincipalCreated" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AuthenticationSource.Id, DefaultValue="localAccountAuthentication" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.UserPrincipalName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.SignInNamesEmailAddress.Id },
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id },
                UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
                {
                    ReferenceId = BaseSessionMgtTechnicalProfiles.Aad.Id
                }
            };
        }

        public static TechnicalProfile AadUserReadUsingEmailAddress
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserReadUsingEmailAddress",
                IncludeInSso = false,
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Read" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalDoesNotExist", Value = "true" },
                    new metadataItem { Key = "UserMessageIfClaimsPrincipalDoesNotExist", Value = "An account could not be found for the provided user ID." },
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Email.Id, PartnerClaimType = "signInNames.emailAddress", Required = true }
                },
                OutputClaims = new List<ClaimTypeReference>{
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AuthenticationSource.Id, DefaultValue="localAccountAuthentication" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.UserPrincipalName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.DisplayName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AccountEnabled.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.OtherMails.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.SignInNamesEmailAddress.Id },
                },
                OutputClaimsTransformations = new List<ClaimsTransformationReference> {
                    new ClaimsTransformationReference { ReferenceId = BaseTransforms.AssertAccountEnabledIsTrue.Id }
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id }
            };
        }

        public static TechnicalProfile AadUserWritePasswordUsingObjectId
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserWritePasswordUsingObjectId",
                IncludeInSso = false,
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Write" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalDoesNotExist", Value = "true" }
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id, Required = true }
                },
                PersistedClaims = new List<PersistedClaim> {
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.NewPassword.Id, PartnerClaimType = "password" }
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id }
            };
        }

        public static TechnicalProfile AadUserWriteProfileUsingObjectId
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserWriteProfileUsingObjectId",
                IncludeInSso = false,
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Write" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalAlreadyExists", Value = "false" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalDoesNotExist", Value = "true" },
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id, Required = true }
                },
                PersistedClaims = new List<PersistedClaim> {
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new PersistedClaim { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id }
            };
        }

        public static TechnicalProfile AadaUserReadUsingObjectId
        {
            get => new TechnicalProfile
            {
                Id = "AAD-UserReadUsingObjectId",
                IncludeInSso = false,
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "Operation", Value = "Read" },
                    new metadataItem { Key = "RaiseErrorIfClaimsPrincipalDoesNotExist", Value = "true" },
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id, Required = true }
                },
                OutputClaims = new List<ClaimTypeReference>{
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.SignInNamesEmailAddress.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.DisplayName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.OtherMails.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.GivenName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Surname.Id },
                },
                IncludeTechnicalProfile = new IncludeTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadCommon.Id }
            };
        }
    }
}