using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.policies;
using agileways.b2c.builder.models.policy;
using System;

namespace agileway.b2c.console
{
    class Program
    {
        private const string ACCOUNT_POLICY_NAME = "B2C_1A_TrustFrameworkBase2";
        private const string TENANT_NAME = "dgtestsb2ctenant.onmicrosoft.com";
        private const string EXTENSIONS_POLICY_NAME = "B2C_1A_TrustFrameworkExtensions2";

        private const string PROXY_IEF_APP_ID = "f90819e3-5bf8-47d3-a3ba-ef1cdb881001";
        private const string IEF_APP_ID = "23325ef3-abd9-4b61-a181-2fcb3f091308";
        private const string EXTENSION_APP_ID= "c25a5888-69c3-4cb4-8d8d-87dbbce4816b";
        private const string EXTENSION_APP_OBJECT_ID = "5befcf9a-7198-4d88-af33-e5a5b906eaa2";
        private const string SIGNIN_SIGNUP_POLICY_NAME = "B2C_1A_TermsOfServiceSignUpOrSignIn";

        private const string DESTINATION_FOLDER = @"c:\test\agileways";

        static void Main(string[] args)
        {
            string id = "0001";
            string displayName = "David";
            string email = "dgiard@microsoft.com";
            string role = "User";
            string tele = "312-555-1212";

            // TODO: Use Graph API to get the keys below
            string signatureKey = "B2C_1A_dgtestb2csignaturekey";
            string encryptionKey = "B2C_1A_dgtestb2cencryptionkey";


            TrustFrameworkPolicy tfbXml = SocialAndLocalAccounts.TrustFrameworkBase(
                ACCOUNT_POLICY_NAME,
                TENANT_NAME,
                new Contact(id, displayName, email, role, tele));
            tfbXml.BuildToFile(DESTINATION_FOLDER);

            TrustFrameworkPolicy tfeXml = SocialAndLocalAccounts.TrustFrameworkExtensions(EXTENSIONS_POLICY_NAME,
                tfbXml,
                PROXY_IEF_APP_ID, IEF_APP_ID, EXTENSION_APP_ID, EXTENSION_APP_OBJECT_ID);
            tfeXml.BuildToFile(DESTINATION_FOLDER);

            TermsOfServiceSignUpOrSignIn tos = new TermsOfServiceSignUpOrSignIn(SIGNIN_SIGNUP_POLICY_NAME, tfeXml);
            tos.ThePolicy.BuildToFile(DESTINATION_FOLDER);

        }
    }
}
