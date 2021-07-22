
using System.Collections.Generic;
using agileways.b2c.builder.models.content;

namespace agileways.b2c.builder.library.common.contentDefinitions
{

    public static class BaseContentDefinitions
    {
        public static ContentDefinition ApiError
        {
            get => new ContentDefinition
            {
                Id = "api.error",
                LoadUri = "~/tenant/templates/AzureBlue/exception.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:globalexception:1.1.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Error page" }
                }
            };
        }
        public static ContentDefinition ApiIdpSelections
        {
            get => new ContentDefinition
            {
                Id = "api.idpselections",
                LoadUri = "~/tenant/templates/AzureBlue/idpSelector.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:idpselection:1.0.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Idp selection page" },
                    new MetadataItemType { Key = "language.intro", Value = "Sign in" }
                }
            };
        }
        public static ContentDefinition ApiIdpSelectionsSignUp
        {
            get => new ContentDefinition
            {
                Id = "api.idpselections.signup",
                LoadUri = "~/tenant/templates/AzureBlue/idpSelector.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:idpselection:1.0.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Idp selection page" },
                    new MetadataItemType { Key = "language.intro", Value = "Sign up" }
                }
            };
        }
        public static ContentDefinition ApiSignUpOrSignIn
        {
            get => new ContentDefinition
            {
                Id = "api.signuporsignin",
                LoadUri = "~/tenant/templates/AzureBlue/unified.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:unifiedssp:1.0.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Signin and Signup" }
                }
            };
        }
        public static ContentDefinition ApiSelfAsserted
        {
            get => new ContentDefinition
            {
                Id = "api.selfasserted",
                LoadUri = "~/tenant/templates/AzureBlue/selfAsserted.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:selfasserted:1.1.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Collect information from user page" }
                }
            };
        }
        public static ContentDefinition ApiSelfAssertedProfileUpdate
        {
            get => new ContentDefinition
            {
                Id = "api.selfasserted.profileupdate",
                LoadUri = "~/tenant/templates/AzureBlue/selfAsserted.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:selfasserted:1.1.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Collect information from user page" }
                }
            };
        }
        public static ContentDefinition ApiLocalAccountSignUp
        {
            get => new ContentDefinition
            {
                Id = "api.localaccountsignup",
                LoadUri = "~/tenant/templates/AzureBlue/selfAsserted.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:selfasserted:1.1.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Local account sign up page" }
                }
            };
        }
        public static ContentDefinition ApiLocalAccountPasswordReset
        {
            get => new ContentDefinition
            {
                Id = "api.localaccountpasswordreset",
                LoadUri = "~/tenant/templates/AzureBlue/selfAsserted.cshtml",
                RecoveryUri = "~/common/default_page_error.html",
                DataUri = "urn:com:microsoft:aad:b2c:elements:selfasserted:1.1.0",
                Metadata = new List<MetadataItemType> {
                    new MetadataItemType { Key = "DisplayName", Value = "Local account change password page" }
                }
            };
        }
    }
}
