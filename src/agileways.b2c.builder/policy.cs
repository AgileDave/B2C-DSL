using agileways.b2c.builder.models.policy;

namespace agileways.b2c.builder
{
    public abstract class Policy
    {
        public TrustFrameworkPolicy BasePolicy { get; private set; }
        public string PolicyName { get; private set; }
        public string PolicyUri { get; private set; }
        public string TenantName { get; private set; }
        public TrustFrameworkPolicy ThePolicy { get; private set; }
        public Policy() { }
        public Policy(string policyName, TrustFrameworkPolicy baseTfp,
                                    DeploymentModeType deployMode = DeploymentModeType.Production,
                                    string policySchemaVersion = "0.3.0.0", string userJourneyRecorderEndpoint = null,
                                    string tenantObjId = null, string stateTableName = null)
        {
            BasePolicy = baseTfp;
            PolicyName = policyName;
            PolicyUri = $"http://{baseTfp.TenantId}/{policyName}";
            TenantName = baseTfp.TenantId;
            ThePolicy = new TrustFrameworkPolicy(PolicyName, PolicyUri, TenantName)
            {
                BasePolicy = new BasePolicy
                {
                    PolicyId = baseTfp.PolicyId,
                    TenantId = TenantName
                },
                DeploymentMode = deployMode,
                DeploymentModeSpecified = true,
                PolicySchemaVersion = policySchemaVersion,
                UserJourneyRecorderEndpoint = userJourneyRecorderEndpoint,
                TenantObjectId = tenantObjId,
                StateTableName = stateTableName
            };
        }

        public abstract void Build();
    }
}