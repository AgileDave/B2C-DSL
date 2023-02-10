using System.Xml.Serialization;
using agileways.b2c.builder.models.policy;
using agileways.b2c.builder.extensions;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.library.common.claims;

namespace agileways.b2c.builder.runner.Samples
{
    public class CommonEndpointSusi : Policy
    {
        private readonly string _appInsightsKey, _userJourneyRecorderEndpoint;
        private readonly DeploymentModeType _deployMode;
        private CommonEndpoint _basePolicy;
        public CommonEndpointSusi(CommonEndpoint basePolicy, string policyName, string appInsightsKey, DeploymentModeType deployMode,
                                    string userJourneyRecorderEndpoint) :
            base(policyName, basePolicy.ThePolicy, deployMode: deployMode, userJourneyRecorderEndpoint: userJourneyRecorderEndpoint)
        {
            _appInsightsKey = appInsightsKey;
            _userJourneyRecorderEndpoint = userJourneyRecorderEndpoint;
            _deployMode = deployMode;
            _basePolicy = basePolicy;

            this.Build();
        }
        public override void Build()
        {
            ThePolicy.RelyingParty = RelyingPartyBuilder.Init(_basePolicy.CommonEndpointSignUpOrSignIn)
                    .SetJourneyInsights(_appInsightsKey, true)
                    .SetTechnicalProfile(TechnicalProfileBuilder.Init("PolicyProfile", "PolicyProfile", ProtocolName.OpenIdConnect)
                        .ReturnsClaim(BaseClaims.DisplayName)
                        .ReturnsClaim(BaseClaims.GivenName)
                        .ReturnsClaim(BaseClaims.Surname)
                        .ReturnsClaim(BaseClaims.Email)
                        .ReturnsClaim(BaseClaims.ObjectId, "sub")
                        .ReturnsClaim(BaseClaims.IdentityProvider, defaultValue: "local")
                        .ReturnsClaim(_basePolicy.Groups)
                        .ReturnsClaim(_basePolicy.Role)
                        .ReturnsClaim(_basePolicy.IpAddress)
                        .SetSubjectNaming("sub")
                    );
        }
    }
}