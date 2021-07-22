using System.Collections.Generic;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.library.common.claims
{

    public static class BaseClaims
    {
        public static ClaimType IssuerUserId
        {
            get => new ClaimType
            {
                Id = "issuerUserId",
                DisplayName = "Username",
                DataType = DataType.@string,
                UserHelpText = "",
                UserInputType = UserInputType.TextBox,
                Restriction = new Restriction
                {
                    Items = new List<object> {
                        new Pattern { HelpText = "The username you provided is not valid. It must begin with an alphabet or number and can contain alphabets, numbers and the following symbols: _ -",
                                    RegularExpression = "^[a-zA-Z0-9]+[a-zA-Z0-9_-]*$"}
                    }
                }
            };
        }
        public static ClaimType TenantId
        {
            get => new ClaimType
            {
                Id = "tenantId",
                DisplayName = "User's Object's Tenant ID",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "tid"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "tid"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.SAML2, PartnerClaimType="http://schemas.microsoft.com/identity/claims/tenantid"}
                },
                UserHelpText = "Tenant identifier (ID) of the user object in Azure AD."
            };
        }
        public static ClaimType ObjectId
        {
            get => new ClaimType
            {
                Id = "objectId",
                DisplayName = "User's Object ID",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "oid"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "oid"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.SAML2, PartnerClaimType="http://schemas.microsoft.com/identity/claims/objectidentifier"}
                },
                UserHelpText = "Object identifier (ID) of the user object in Azure AD."
            };
        }

        public static ClaimType SignInName
        {
            get => new ClaimType
            {
                Id = "signInName",
                DisplayName = "Sign in name",
                DataType = DataType.@string,
                UserInputType = UserInputType.TextBox,
                UserHelpText = ""
            };
        }
        public static ClaimType SignInNamesEmailAddress
        {
            get => new ClaimType
            {
                Id = "signInNames.emailAddress",
                DisplayName = "Email Address",
                DataType = DataType.@string,
                UserInputType = UserInputType.TextBox,
                UserHelpText = "Email address to use for signing in."
            };
        }
        public static ClaimType AccountEnabled
        {
            get => new ClaimType
            {
                Id = "accountEnabled",
                DisplayName = "Account Enabled",
                DataType = DataType.boolean,
                UserHelpText = "Specifies whether your account is enabled.",
                AdminHelpText = "Specifies whether the user's account is enabled."
            };
        }
        public static ClaimType Password
        {
            get => new ClaimType
            {
                Id = "password",
                DisplayName = "Password",
                DataType = DataType.@string,
                UserHelpText = "Enter new password",
                UserInputType = UserInputType.Password,
                Restriction = new Restriction
                {
                    Items = new List<object> {
                        new Pattern {
                            HelpText = @"8-16 characters, containing 3 out of 4 of the following: Lowercase characters, uppercase characters, digits (0-9), and one or more of the following symbols: @ # $ % ^ &amp; * - _ + = [ ] { } | \ : ' , ? / ` ~ &quot; ( ) ; .",
                            RegularExpression = @"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)|(?=.*[a-z])(?=.*[A-Z])(?=.*[^A-Za-z0-9])|(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9])|(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]))([A-Za-z\d@#$%^&amp;*\-_+=[\]{}|\\:',?/`~&quot;();!]|\.(?!@)){8,16}$"
                        }
                    }
                },
                AdminHelpText = @"^( # one of the following four combinations must appear in the password
                                    (?=.*[a-z])(?=.*[A-Z])(?=.*\d) |            # matches lower case, upper case or digit
                                    (?=.*[a-z])(?=.*[A-Z])(?=.*[^A-Za-z0-9]) |  # matches lower case, upper case or special character (i.e. non-alpha or digit)
                                    (?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9]) |     # matches lower case, digit, or special character
                                    (?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9])       # matches upper case, digit, or special character
                                    )
                                    ( # The password must match the following restrictions
                                    [A-Za-z\d@#$%^&*\-_+=[\]{}|\\:',?/`~""();!] |   # The list of all acceptable characters (without .)
                                    \.(?!@)                                        # or . can appear as long as not followed by @
                                    ) {8,16}$                                       # the length must be between 8 and 16 chars inclusive"
            };
        }
        public static ClaimType ReenterPassword
        {
            get => new ClaimType
            {
                Id = "reenterPassword",
                DisplayName = "Confirm New Password",
                DataType = DataType.@string,
                UserInputType = UserInputType.Password,
                UserHelpText = "Email address to use for signing in.",
                Restriction = new Restriction
                {
                    Items = new List<object> {
                        new Pattern {
                            HelpText = @"8-16 characters, containing 3 out of 4 of the following: Lowercase characters, uppercase characters, digits (0-9), and one or more of the following symbols: @ # $ % ^ &amp; * - _ + = [ ] { } | \ : ' , ? / ` ~ &quot; ( ) ; .",
                            RegularExpression = @"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)|(?=.*[a-z])(?=.*[A-Z])(?=.*[^A-Za-z0-9])|(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9])|(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]))([A-Za-z\d@#$%^&amp;*\-_+=[\]{}|\\:',?/`~&quot;();!]|\.(?!@)){8,16}$"
                        }
                    }
                }
            };
        }
        public static ClaimType PasswordPolicies
        {
            get => new ClaimType
            {
                Id = "passwordPolicies",
                DisplayName = "Password Policies",
                DataType = DataType.@string,
                UserHelpText = "Password policies used by Azure AD to determine password strength, expiry etc."
            };
        }
        public static ClaimType ClientId
        {
            get => new ClaimType
            {
                Id = "client_id",
                DisplayName = "client_id",
                DataType = DataType.@string,
                UserHelpText = "Special parameter passed to EvoSTS.",
                AdminHelpText = "Special parameter passed to EvoSTS."
            };
        }
        public static ClaimType ResourceId
        {
            get => new ClaimType
            {
                Id = "resource_id",
                DisplayName = "resource_id",
                DataType = DataType.@string,
                UserHelpText = "Special parameter passed to EvoSTS.",
                AdminHelpText = "Special parameter passed to EvoSTS."
            };
        }
        public static ClaimType Subject
        {
            get => new ClaimType
            {
                Id = "sub",
                DisplayName = "Subject",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OpenIdConnect, PartnerClaimType="sub"}
                },
                UserHelpText = ""
            };
        }
        public static ClaimType AlternativeSecurityId
        {
            get => new ClaimType
            {
                Id = "alternativeSecurityId",
                DisplayName = "Alternative Security Id",
                DataType = DataType.@string,
                UserHelpText = ""
            };
        }
        public static ClaimType MailNickName
        {
            get => new ClaimType
            {
                Id = "mailNickName",
                DisplayName = "MailNickName",
                DataType = DataType.@string,
                UserHelpText = "Your mail nick name as stored in the Azure Active Directory.",
                AdminHelpText = "Your mail nick name as stored in the Azure Active Directory."
            };
        }
        public static ClaimType IdentityProvider
        {
            get => new ClaimType
            {
                Id = "identityProvider",
                DisplayName = "IdentityProvider",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "idp"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "idp"},
                    new PartnerClaimTypesProtocol { Name = ProtocolName.SAML2, PartnerClaimType = "http://schemas.microsoft.com/identity/claims/identityprovider"}
                },
                UserHelpText = "",
                AdminHelpText = ""
            };
        }
        public static ClaimType DisplayName
        {
            get => new ClaimType
            {
                Id = "displayName",
                DisplayName = "Display Name",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "unique_name"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "name"},
                    new PartnerClaimTypesProtocol { Name = ProtocolName.SAML2, PartnerClaimType = "http://schemas.microsoft.com/identity/claims/name"}
                },
                UserHelpText = "Your display name.",
                UserInputType = UserInputType.TextBox,
                AdminHelpText = ""
            };
        }
        public static ClaimType Email
        {
            get => new ClaimType
            {
                Id = "email",
                DisplayName = "Email Address",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "email"},
                },
                UserHelpText = "",
                UserInputType = UserInputType.TextBox,
                Restriction = new Restriction
                {
                    Items = new List<object> {
                        new Pattern {
                            HelpText = "Please enter a valid email address.",
                            RegularExpression = @"^[a-zA-Z0-9.!#$%&amp;'^_`{}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$"
                        }
                    }
                },
                AdminHelpText = ""
            };
        }

        public static ClaimType OtherMails
        {
            get => new ClaimType
            {
                Id = "otherMails",
                DisplayName = "Alternate Email Addresses",
                DataType = DataType.stringCollection,
                UserHelpText = "Email addresses that can be used to contact the user.",
                AdminHelpText = ""
            };
        }
        public static ClaimType UserPrincipalName
        {
            get => new ClaimType
            {
                Id = "userPrincipalName",
                DisplayName = "UserPrincipalName",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "upn"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "upn"},
                    new PartnerClaimTypesProtocol { Name = ProtocolName.SAML2, PartnerClaimType = "http://schemas.microsoft.com/identity/claims/userprincipalname"}
                },
                UserHelpText = "Your user name as stored in the Azure Active Directory.",
                AdminHelpText = ""
            };
        }
        public static ClaimType UpnUserName
        {
            get => new ClaimType
            {
                Id = "upnUserName",
                DisplayName = "UPN User Name",
                DataType = DataType.@string,
                UserHelpText = "The user name for creating user principal name.",
                AdminHelpText = ""
            };
        }
        public static ClaimType NewUser
        {
            get => new ClaimType
            {
                Id = "newUser",
                DisplayName = "User is new",
                DataType = DataType.boolean,
                UserHelpText = "",
                AdminHelpText = ""
            };
        }
        public static ClaimType ExecutedSelfAssertedInput
        {
            get => new ClaimType
            {
                Id = "executed-SelfAsserted-Input",
                DisplayName = "Executed-SelfAsserted-Input",
                DataType = DataType.@string,
                UserHelpText = "A claim that specifies whether attributes were collected from the user.",
                AdminHelpText = ""
            };
        }
        public static ClaimType AuthenticationSource
        {
            get => new ClaimType
            {
                Id = "authenticationSource",
                DisplayName = "AuthenticationSource",
                DataType = DataType.@string,
                UserHelpText = "Specifies whether the user was authenticated at Social IDP or local account.",
                AdminHelpText = ""
            };
        }
        public static ClaimType Nca
        {
            get => new ClaimType
            {
                Id = "nca",
                DisplayName = "nca",
                DataType = DataType.@string,
                UserHelpText = "Special parameter passed for local account authentication to login.microsoftonline.com.",
                AdminHelpText = ""
            };
        }
        public static ClaimType GrantType
        {
            get => new ClaimType
            {
                Id = "grant_type",
                DisplayName = "grant_type",
                DataType = DataType.@string,
                UserHelpText = "Special parameter passed for local account authentication to login.microsoftonline.com.",
                AdminHelpText = ""
            };
        }
        public static ClaimType Scope
        {
            get => new ClaimType
            {
                Id = "scope",
                DisplayName = "scope",
                DataType = DataType.@string,
                UserHelpText = "Special parameter passed for local account authentication to login.microsoftonline.com.",
                AdminHelpText = ""
            };
        }
        public static ClaimType ObjectIdFromSession
        {
            get => new ClaimType
            {
                Id = "objectIdFromSession",
                DisplayName = "objectIdFromSession",
                DataType = DataType.@string,
                UserHelpText = "Parameter provided by the default session management provider to indicate that the object id has been retrieved from an SSO session.",
                AdminHelpText = ""
            };
        }
        public static ClaimType IsActiveMFASession
        {
            get => new ClaimType
            {
                Id = "isActiveMFASession",
                DisplayName = "Is Active MFA Session",
                DataType = DataType.boolean,
                UserHelpText = "Parameter provided by the MFA session management to indicate that the user has an active MFA session.",
                AdminHelpText = ""
            };
        }
        public static ClaimType GivenName
        {
            get => new ClaimType
            {
                Id = "givenName",
                DisplayName = "Given Name",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "given_name"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "given_name"},
                    new PartnerClaimTypesProtocol { Name = ProtocolName.SAML2, PartnerClaimType = "http://schemas.microsoft.com/identity/claims/givenname"}
                },
                UserHelpText = "Your given name (also known as first name).",
                UserInputType = UserInputType.TextBox,
                AdminHelpText = ""
            };
        }
        public static ClaimType Surname
        {
            get => new ClaimType
            {
                Id = "surname",
                DisplayName = "Surname",
                DataType = DataType.@string,
                DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol> {
                    new PartnerClaimTypesProtocol { Name = ProtocolName.OAuth2, PartnerClaimType = "family_name"},
                    new PartnerClaimTypesProtocol {Name = ProtocolName.OpenIdConnect, PartnerClaimType = "family_name"},
                    new PartnerClaimTypesProtocol { Name = ProtocolName.SAML2, PartnerClaimType = "http://schemas.microsoft.com/identity/claims/surname"}
                },
                UserHelpText = "Your surname (also known as family name or last name).",
                UserInputType = UserInputType.TextBox,
                AdminHelpText = ""
            };
        }
    }
}