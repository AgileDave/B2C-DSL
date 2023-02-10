using System;
using System.Collections.Generic;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.library.common.claims;
using agileways.b2c.builder.library.common.claimsProviders;
using agileways.b2c.builder.library.common.clientDefinitions;
using agileways.b2c.builder.library.common.contentDefinitions;
using agileways.b2c.builder.library.common.transformations;
using agileways.b2c.builder.library.policies;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.content;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.models.rp;
using agileways.b2c.builder.models.techProfile;
using agileways.b2c.builder.models.transform;
using agileways.b2c.builder.runner.Samples;
using agileways.b2c.builder.runner.Samples.TermsOfService;

namespace agileways.b2c.builder.runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var bb = new BuildingBlocks
            {
                ClaimsSchema = new List<ClaimType> {
                    new ClaimType("claim1", "sample claim 1", "this is help text", DataType.@string, UserInputType.TextBox),
                    new ClaimType ("claim2", "sample Claim 2", "more help text", DataType.@string, UserInputType.TextBox) {
                        DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol>{
                            new PartnerClaimTypesProtocol(ProtocolName.SAML2, "issuer"),
                            new PartnerClaimTypesProtocol(ProtocolName.OAuth2, "iss")
                        }
                    },
                    BaseClaims.IssuerUserId,
                    BaseClaims.TenantId
                },
                ClaimsTransformations = new List<ClaimsTransformation> {
                    new ClaimsTransformation ("CreateOtherMailsFromEmail","AddItemToStringCollection") {
                        InputClaims = new List<ClaimsTransformationClaimTypeReference> {
                            new ClaimsTransformationClaimTypeReference("email", "item"),
                            new ClaimsTransformationClaimTypeReference("otherMails", "collection")
                        },
                        OutputClaims = new List<ClaimsTransformationClaimTypeReference> {
                            new ClaimsTransformationClaimTypeReference("otherMails", "collection")
                        }
                    }
                }
            };

            var pol = PolicyBuilder.Init("B2C_1A_Test1", "https://policy.com", "123", DeploymentModeType.Development, "0.3",
                                stateTableName: "unknown", tenantObjId: "123")
                    .InheritFrom(new BasePolicy("asdf", "sdfg"))
                    .AddContact(new Contact("asdf", "dave", "name_server.com", "dev", "123-234-3455"))
                    .AddContact(new Contact("sfg", "will", "will_server.com", "mgr", "234-345-4567"))
                    .SetBuildingBlocks(bb);

            // Console.WriteLine($"{pol.Build()}");

            // Console.WriteLine("");

            var rpXml = PolicyBuilder.Init("B2C_1A_BearerToken_SignUpSignIn",
                                        "http://kubedave.onmicrosoft.com/B2C_1A_BearerToken_SignUpSignIn",
                                        "kubedave.onmicrosoft.com",
                                        DeploymentModeType.Development,
                                        userJourneyRecorderEndpoint: "urn:journeyrecorder:applicationinsights")
                                   .InheritFrom(new BasePolicy("B2C_1A_BearerToken_UserJourneys", "kubedave.onmicrosoft.com"))
                                   .AddContact(new Contact("dave", "David Hoerster", "david.hoerster@microsoft.com", "Principal PM", "412.322.6777"))
                                   .SetRelyingParty(RelyingPartyBuilder
                                                        .Init("BearerTokenSignUpOrSignIn")
                                                        .SetJourneyInsights("c68362e9-167a-490d-8001-fbecd8428bdc", true)
                                                        .SetTechnicalProfile(TechnicalProfileBuilder.Init("PolicyProfile", "Policy Profile", ProtocolName.OpenIdConnect)
                                                                                                    .SetSubjectNaming("sub")
                                                                                                    .ReturnsClaim(BaseClaims.DisplayName)
                                                                                                    .ReturnsClaim(BaseClaims.GivenName)
                                                                                                    .ReturnsClaim(BaseClaims.Surname)
                                                                                                    .ReturnsClaim(BaseClaims.Email)
                                                                                                    .ReturnsClaim("groups")
                                                                                                    .ReturnsClaim("role")
                                                                                                    .ReturnsClaim(BaseClaims.ObjectId, "sub")
                                                                                                    .ReturnsClaim(BaseClaims.IdentityProvider, defaultValue: "local")))
                                   .Build();


            var tfbXml = SocialAndLocalAccounts.TrustFrameworkBase("B2C_1A_TrustFrameworkBase2",
                                                                    "davedemob2c.onmicrosoft.com",
                                                                    new Contact("Lead", "David Hoerster", "david.hoerster@microsoft.com", "Principal PM", "412.322.6777"));
            var tfeXml = SocialAndLocalAccounts.TrustFrameworkExtensions("B2C_1A_TrustFrameworkExtensions2",
                                                                            tfbXml,
                                                                            "f90819e3-5bf8-47d3-a3ba-ef1cdb881001", "23325ef3-abd9-4b61-a181-2fcb3f091308",
                                                                            "c25a5888-69c3-4cb4-8d8d-87dbbce4816b", "5befcf9a-7198-4d88-af33-e5a5b906eaa2");

            var tfjXml = SocialAndLocalAccounts.UserJourneys("B2C_1A_TrustFrameworkJourneys2", tfeXml);

            var tfSusiXml = SocialAndLocalAccounts.RelyingPartySusi("B2C_1A_SUSI2", tfjXml);
            var tfProfEditXml = SocialAndLocalAccounts.RelyingPartyProfileEdit("B2C_1A_PROFEDIT2", tfjXml);
            var tfPassResetXml = SocialAndLocalAccounts.RelyingPartyProfileEdit("B2C_1A_PASSRESET2", tfjXml);


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{tfbXml.BuildToFile(@"c:\temp")}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{tfeXml.BuildToFile(@"c:\temp")}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{tfjXml.BuildToFile(@"c:\temp")}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{tfSusiXml.BuildToFile(@"c:\temp")}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{tfProfEditXml.BuildToFile(@"c:\temp")}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"{tfPassResetXml.BuildToFile(@"c:\temp")}");


            var ce = new CommonEndpoint("B2C_1A_CommonEndpoint", tfeXml);
            var ceSusi = new CommonEndpointSusi(ce, "B2C_1A_CommonEndpointSusi", "c68362e9-167a-490d-8001-fbecd8428bdc", DeploymentModeType.Development, "urn:journeyrecorder:applicationinsights");

            Console.WriteLine($"{ce.ThePolicy.PolicyId} has {ce.ThePolicy.BuildingBlocks.ClaimsSchema.Count} custom claims");
            PolicyBuilder.BuildToFile(ce.ThePolicy, @"c:\temp");
            PolicyBuilder.BuildToFile(ceSusi.ThePolicy, @"c:\temp");

            var tos = new TermsOfServiceSignUpOrSignIn("B2C_1A_TermsOfServiceSignUpOrSignIn", tfeXml);
            tos.ThePolicy.BuildToFile(@"c:\temp");
        }
    }
}
