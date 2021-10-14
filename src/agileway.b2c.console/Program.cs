using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.policies;
using agileways.b2c.builder.models.policy;
using System;
using System.Configuration;
using System.Collections.Specialized;

namespace agileway.b2c.console
{
    class Program
    {
        private const string DESTINATION_FOLDER = @"c:\test\agileways";

        static void Main(string[] args)
        {
            string accountPolicyName = ConfigurationManager.AppSettings.Get("B2C.AccountPolicyName");
            string tenantName = ConfigurationManager.AppSettings.Get("B2C.TenantName");
            string extensionsPolicyName = ConfigurationManager.AppSettings.Get("B2C.ExtensionsPolicyName");

            string proxyIefAppId = ConfigurationManager.AppSettings.Get("B2C.ProxyIefAppId");
            string iefAppId = ConfigurationManager.AppSettings.Get("B2C.IefAppId");
            string extensionsAppId = ConfigurationManager.AppSettings.Get("B2C.ExtensionsAppId");
            string extensionsAppObjectId = ConfigurationManager.AppSettings.Get("B2C.ExtensionsAppObjectId");
            string signInSignUpPolicyName = ConfigurationManager.AppSettings.Get("B2C.SignInSignUpPolicyName");

            string id = ConfigurationManager.AppSettings.Get("Contact.Id");
            string displayName = ConfigurationManager.AppSettings.Get("Contact.DisplayName");
            string email = ConfigurationManager.AppSettings.Get("Contact.Email");
            string role = ConfigurationManager.AppSettings.Get("Contact.Role");
            string tele = ConfigurationManager.AppSettings.Get("Contact.Telephone");

            // TODO: Use Graph API to get the keys below
            // Currently, they are stored in app.config
            // They must match the Identity Experience Framework Policy Keys in the AD B2C tenant
            //string encryptionKey = "XXXXXX";
            //string signatureKey = "XXXXXX";

            TrustFrameworkPolicy tfbXml = SocialAndLocalAccounts.TrustFrameworkBase(
                accountPolicyName,
                tenantName,
                new Contact(id, displayName, email, role, tele));
            tfbXml.BuildToFile(DESTINATION_FOLDER);

            TrustFrameworkPolicy tfeXml = SocialAndLocalAccounts.TrustFrameworkExtensions(extensionsPolicyName,
                tfbXml,
                proxyIefAppId, iefAppId, extensionsAppId, extensionsAppObjectId);
            tfeXml.BuildToFile(DESTINATION_FOLDER);

            TermsOfServiceSignUpOrSignIn tos = new TermsOfServiceSignUpOrSignIn(signInSignUpPolicyName, tfeXml);
            tos.ThePolicy.BuildToFile(DESTINATION_FOLDER);

        }
    }
}
