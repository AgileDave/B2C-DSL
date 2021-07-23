
using System.Collections.Generic;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.techProfiles
{

    public static class BaseLocalAccountTechnicalProfiles
    {
        public static TechnicalProfile LoginNonInteractive
        {
            get => new TechnicalProfile
            {
                Id = "login-NonInteractive",
                DisplayName = "Local Account SignIn",
                Protocol = new TechnicalProfileProtocol { Name = ProtocolName.OpenIdConnect },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "UserMessageIfClaimsPrincipalDoesNotExist", Value = "We can't seem to find your account"},
                    new metadataItem { Key = "UserMessageIfInvalidPassword", Value = "Your password is incorrect"},
                    new metadataItem { Key = "UserMessageIfOldPasswordUsed", Value = "Looks like you used an old password"},
                    new metadataItem { Key = "ProviderName", Value = "https://sts.windows.net/<"},
                    new metadataItem { Key = "METADATA", Value = "https://login.microsoftonline.com/{tenant}/.well-known/openid-configuration"},
                    new metadataItem { Key = "authorization_endpoint", Value = "https://login.microsoftonline.com/{tenant}/oauth2/token"},
                    new metadataItem { Key = "response_types", Value = "id_token"},
                    new metadataItem { Key = "response_mode", Value = "query"},
                    new metadataItem { Key = "scope", Value = "email openid"},
                    new metadataItem { Key = "grant_type", Value = "password"},
                    new metadataItem { Key = "UsePolicyInRedirectUri", Value = "false"},
                    new metadataItem { Key = "HttpBinding", Value = "POST"},
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.SignInName.Id, PartnerClaimType = "username", Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Password.Id, Required= true },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.GrantType.Id,DefaultValue = "password" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Scope.Id, DefaultValue= "openid" },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Nca.Id, PartnerClaimType = "nca", DefaultValue = "1" },
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.ObjectId.Id, PartnerClaimType="oid" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.TenantId.Id, PartnerClaimType="tid" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.GivenName.Id, PartnerClaimType="given_name" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.Surname.Id, PartnerClaimType="family_name" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.DisplayName.Id, PartnerClaimType="name" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.UserPrincipalName.Id, PartnerClaimType="upn" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.AuthenticationSource.Id, DefaultValue="localAccountAuthentication" },
                }
            };
        }

        public static TechnicalProfile LocalAccountSignUpWithLogonEmail
        {
            get => new TechnicalProfile
            {
                Id = "LocalAccountSignUpWithLogonEmail",
                DisplayName = "Email signup",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "IpAddressClaimReferenceId", Value = "IpAddress" },
                    new metadataItem { Key = "ContentDefinitionReferenceId", Value = BaseContentDefinitions.ApiLocalAccountSignUp.Id },
                    new metadataItem { Key = "language.button_continue", Value = "Create" },
                },
                CryptographicKeys = new List<CryptographicKey> {
                    new CryptographicKey { Id = "issuer_secret", StorageReferenceId = "B2C_1A_TokenSigningKeyContainer" }
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Email.Id }
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.Email.Id, PartnerClaimType="Verified.Email", Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.NewPassword.Id, Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.ReenterPassword.Id, Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.ExecutedSelfAssertedInput.Id, DefaultValue = "true" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.AuthenticationSource.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.NewUser.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.DisplayName.Id, PartnerClaimType="name" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.GivenName.Id, PartnerClaimType="given_name" },
                    new ClaimTypeReference { ClaimTypeReferenceId= BaseClaims.Surname.Id, PartnerClaimType="family_name" },
                },
                ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                    new ValidationTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadUserWriteUsingLogonEmail.Id }
                },
                UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
                {
                    ReferenceId = BaseSessionMgtTechnicalProfiles.Aad.Id
                }
            };
        }

        public static TechnicalProfile SelfAssertedLocalAccountSigninEmail
        {
            get => new TechnicalProfile
            {
                Id = "SelfAsserted-LocalAccountSignin-Email",
                DisplayName = "Local Account Signin",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "SignUpTarget", Value = "SignUpWithLogonEmailExchange" },
                    new metadataItem { Key = "setting.operatingMode", Value = "Email" },
                    new metadataItem { Key = "ContentDefinitionReferenceId", Value = BaseContentDefinitions.ApiSelfAsserted.Id },
                },
                IncludeInSso = false,
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.SignInName.Id }
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.SignInName.Id, Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Password.Id, Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AuthenticationSource.Id },
                },
                ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                    new ValidationTechnicalProfile { ReferenceId = BaseLocalAccountTechnicalProfiles.LoginNonInteractive.Id }
                },
                UseTechnicalProfileForSessionManagement = new TechnicalProfileUseTechnicalProfileForSessionManagement
                {
                    ReferenceId = BaseSessionMgtTechnicalProfiles.Aad.Id
                }
            };
        }

        public static TechnicalProfile LocalAccountDiscoveryUsingEmailAddress
        {
            get => new TechnicalProfile
            {
                Id = "LocalAccountDiscoveryUsingEmailAddress",
                DisplayName = "Reset password using email address",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                Metadata = new List<metadataItem> {
                    new metadataItem{Key = "IpAddressClaimReferenceId", Value = "IpAddress" },
                    new metadataItem{Key = "ContentDefinitionReferenceId", Value = BaseContentDefinitions.ApiLocalAccountPasswordReset.Id },
                    new metadataItem{Key = "UserMessageIfClaimsTransformationBooleanValueIsNotEqual", Value = "Your account has been locked. Contact your support person to unlock it, then try again." },
                },
                CryptographicKeys = new List<CryptographicKey> {
                    new CryptographicKey { Id = "issuer_secret", StorageReferenceId = "B2C_1A_TokenSigningKeyContainer" }
                },
                IncludeInSso = false,
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.Email.Id, PartnerClaimType = "Verified.Email", Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.UserPrincipalName.Id },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.AuthenticationSource.Id },
                },
                ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                    new ValidationTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadUserReadUsingEmailAddress.Id }
                }
            };
        }

        public static TechnicalProfile LocalAccountWritePasswordUsingObjectId
        {
            get => new TechnicalProfile
            {
                Id = "LocalAccountWritePasswordUsingObjectId",
                DisplayName = "Change password (username)",
                Protocol = new TechnicalProfileProtocol
                {
                    Name = ProtocolName.Proprietary,
                    Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
                },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "ContentDefinitionReferenceId", Value = BaseContentDefinitions.ApiLocalAccountPasswordReset.Id }
                },
                CryptographicKeys = new List<CryptographicKey> {
                    new CryptographicKey { Id = "issuer_secret", StorageReferenceId = "B2C_1A_TokenSigningKeyContainer" }
                },
                InputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ObjectId.Id }
                },
                OutputClaims = new List<ClaimTypeReference> {
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.NewPassword.Id, Required = true },
                    new ClaimTypeReference { ClaimTypeReferenceId = BaseClaims.ReenterPassword.Id, Required = true }
                },
                ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
                    new ValidationTechnicalProfile { ReferenceId = BaseAadTechnicalProfiles.AadUserWritePasswordUsingObjectId.Id }
                }
            };
        }
    }
}