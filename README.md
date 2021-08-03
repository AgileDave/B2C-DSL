# B2C-DSL

## Sample Usage

Until a NuGet package is created for this library, you will have to compile this project and then include it in your C# project. In this example, this library is included as a project reference:

```xml
  <ItemGroup>
    <ProjectReference Include="<relative_path>\agileways.b2c.builder.csproj" />
  </ItemGroup>
```

After that, you can create a class that inherits from `Policy`. The ctor can take in any number of arguments, but you should pass the name of your policy along with the base policy object that it inherits from.

```csharp
public class TermsOfServiceSignUpOrSignIn : Policy {

    public TermsOfServiceSignUpOrSignIn(string policyName, TrustFrameworkPolicy tfpBase) : base(policyName, tfpBase) => this.Build();
    
    public override void Build() { ... }

}
```

`Policy` is an abstract class with a single method - `Build()`. Implement this method by creating various policy objects and attach them to the built-in `ThePolicy` property (which is an instance of `TrustFrameworkPolicy`). The following sections can all reside within `Build()`:

### Create Claims
```csharp

            var agreedToToS = ClaimBuilder.AsString
                .WithId("AgreedToTermsOfService")
                .WithDisplayName("Agreed To Terms Of Service")
                .DisplayClaimAsMultiSelectCheckbox()
                .RestrictWith(new Restriction
                {
                    Items = new List<object> {
                        new EnumerationItem { Text = "", Value = CURRENT_TOS_VERSION}
                    }
                });

            var persistedToS = ClaimBuilder.AsString
                .WithId("extension_AgreedToTermsOfService")
                .WithDisplayName("This is the current business Terms of Service version")
                .AddAdminHelpText("This is the current business Terms of Service version");

            var currentToS = ClaimBuilder.AsString
                .WithId("policyTOSversion")
                .WithDisplayName("This is the current business Terms of Service version")
                .AddAdminHelpText("This is the current business Terms of Service version");

            var isTosRenewalNeeded = ClaimBuilder.AsBool
                .WithId("renewalTOSrequired")
                .WithDisplayName("This variable states whether TOS requires to be renewed")
                .AddAdminHelpText("This variable states whether TOS requires to be renewed");

```

### Claims Transformations

```csharp

            var isToSRenewalNeededTransform = TransformationBuilder.Init("IsTermsOfServiceRequired", "CompareClaims")
                .AcceptingClaim(currentToS, "inputClaim1")
                .AcceptingClaim(persistedToS, "inputClaim2")
                .AcceptingParameter("operator", DataType.@string, "NOT EQUAL")
                .AcceptingParameter("ignoreCase", DataType.@string, "true")
                .ReturnsClaim(isTosRenewalNeeded, "outputClaim");

            var assertToSSelectedTransform = TransformationBuilder.Init("AssertTOSHasBeenSelected", "AssertStringClaimsAreEqual")
                .AcceptingClaim(agreedToToS, "inputClaim1")
                .AcceptingClaim(currentToS, "inputClaim2")
                .AcceptingParameter("stringComparison", DataType.@string, "ordinalIgnoreCase");

```

### Technical Profiles

```csharp

    var tpLocalAccountSignUpWithLogonEmail = TechnicalProfileBuilder.Init("LocalAccountSignUpWithLogonEmail")
        .ReturnsClaim(agreedToToS, required: true)
        .ReturnsClaim(isTosRenewalNeeded, defaultValue: "false");

    var tpAAD_UserWriteUsingLogonEmail = TechnicalProfileBuilder.Init("AAD-UserWriteUsingLogonEmail")
        .PersistsClaim(agreedToToS, persistedToS.Id);


    var tpAAD_ReadTOS = TechnicalProfileBuilder.Init("AAD-ReadTOS")
        .AddMetadata("Operation", "Read")
        .AddMetadata("RaiseErrorIfClaimsPrincipalDoesNotExist", "true")
        .ParticipatesInSso(false)
        .AcceptsClaim(BaseClaims.ObjectId, required: true)
        .ReturnsClaim(persistedToS);
    tpAAD_ReadTOS.IncludeTechnicalProfile = new IncludeTechnicalProfile
    {
        ReferenceId = "AAD-Common"
    };

    var tpSelfAsserted_LocalAccountSignin_Email =
        TechnicalProfileBuilder.Init("SelfAsserted-LocalAccountSignin-Email")
            .AddMetadata("SignUpTarget", "SignUpWithLogonEmailExchange")
            .AddMetadata("setting.operatingMode", "Email")
            .AddMetadata("ContentDefinitionReferenceId", BaseContentDefinitions.ApiSelfAsserted.Id)
            .AcceptsClaim(BaseClaims.SignInName)
            .AcceptsClaim(currentToS, defaultValue: CURRENT_TOS_VERSION)
            .ReturnsClaim(currentToS, defaultValue: CURRENT_TOS_VERSION)
            .ReturnsClaim(BaseClaims.SignInName, required: true)
            .ReturnsClaim(BaseClaims.Password, required: true)
            .ReturnsClaim(BaseClaims.ObjectId)
            .ReturnsClaim(BaseClaims.AuthenticationSource)
            .ReturnsClaim(persistedToS)
            .ParticipatesInSso(false)
            .UsingOutputClaimsTransform(isToSRenewalNeededTransform)
            .UsingSessionManagementProfile(BaseSessionMgtTechnicalProfiles.Aad);
    tpSelfAsserted_LocalAccountSignin_Email.DisplayName = "Local Account Signin";
    tpSelfAsserted_LocalAccountSignin_Email.Protocol = new TechnicalProfileProtocol
    {
        Name = ProtocolName.Proprietary,
        Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
    };
    tpSelfAsserted_LocalAccountSignin_Email.ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
        new ValidationTechnicalProfile { ReferenceId = "login-NonInteractive"},
        new ValidationTechnicalProfile { ReferenceId = tpAAD_ReadTOS.Id }
    };


    var tpVerfiyTOSConsentedTo = TechnicalProfileBuilder.Init("VerfiyTOSConsentedTo")
        .ReturnsClaim(persistedToS)
        .UsingOutputClaimsTransform(assertToSSelectedTransform);
    tpVerfiyTOSConsentedTo.DisplayName = "Verifies TOS has been Accepted";
    tpVerfiyTOSConsentedTo.Protocol = new TechnicalProfileProtocol
    {
        Name = ProtocolName.Proprietary,
        Handler = "Web.TPEngine.Providers.ClaimsTransformationProtocolProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
    };

    var tpAAD_UserWriteProfileUsingObjectIdUpdateTOU = TechnicalProfileBuilder.Init("AAD-UserWriteProfileUsingObjectIdUpdateTOU")
        .AddMetadata("Operation", "Write")
        .AddMetadata("RaiseErrorIfClaimsPrincipalAlreadyExists", "false")
        .AddMetadata("RaiseErrorIfClaimsPrincipalDoesNotExist", "true")
        .AcceptsClaim(BaseClaims.ObjectId, required: true)
        .ParticipatesInSso(false)
        .PersistsClaim(BaseClaims.ObjectId)
        .PersistsClaim(agreedToToS, persistedToS.Id);
    tpAAD_UserWriteProfileUsingObjectIdUpdateTOU.IncludeTechnicalProfile = new IncludeTechnicalProfile
    {
        ReferenceId = "AAD-Common"
    };

    var tpCheckTOSrequirement = TechnicalProfileBuilder.Init("CheckTOSrequirement")
        .AcceptsClaim(currentToS, required: true)
        .AcceptsClaim(persistedToS, required: true)
        .ReturnsClaim(isTosRenewalNeeded)
        .ReturnsClaim(currentToS)
        .ReturnsClaim(persistedToS)
        .UsingOutputClaimsTransform(isToSRenewalNeededTransform);
    tpCheckTOSrequirement.DisplayName = "Check TOS Requirement";
    tpCheckTOSrequirement.Protocol = new TechnicalProfileProtocol
    {
        Name = ProtocolName.Proprietary,
        Handler = "Web.TPEngine.Providers.ClaimsTransformationProtocolProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
    };


    var tpSelfAsserted_RefreshTOS = TechnicalProfileBuilder.Init("SelfAsserted-RefreshTOS")
        .AddMetadata("ContentDefinitionReferenceId", BaseContentDefinitions.ApiSelfAsserted.Id)
        .AddMetadata("UserMessageIfClaimsTransformationStringsAreNotEqual", "You need to accept the TOS")
        .ParticipatesInSso(false)
        .AcceptsClaim(agreedToToS)
        .ReturnsClaim(agreedToToS);
    tpSelfAsserted_RefreshTOS.DisplayName = "Terms And Use Update";
    tpSelfAsserted_RefreshTOS.Protocol = new TechnicalProfileProtocol
    {
        Name = ProtocolName.Proprietary,
        Handler = "Web.TPEngine.Providers.SelfAssertedAttributeProvider, Web.TPEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
    };
    tpSelfAsserted_RefreshTOS.ValidationTechnicalProfiles = new List<ValidationTechnicalProfile> {
        new ValidationTechnicalProfile { ReferenceId = tpVerfiyTOSConsentedTo.Id },
        new ValidationTechnicalProfile { ReferenceId = tpAAD_UserWriteProfileUsingObjectIdUpdateTOU.Id }
    };

```

### User Journeys

```csharp

var susiJourney = UserJourneyBuilder.Init("TermsOfServiceSignUpOrSignIn")
    .AddOrchestrationStep(
        OrchestrationStepBuilder.AsCombinedSignInSignUp
            .UsingContentDefinition(BaseContentDefinitions.ApiSignUpOrSignIn)
            .AddClaimsProviderSelection(validationClaimsExchangeId: "LocalAccountSigninEmailExchange")
            .AddClaimsExchange("LocalAccountSigninEmailExchange", tpSelfAsserted_LocalAccountSignin_Email))
    .AddOrchestrationStep(
        OrchestrationStepBuilder.AsClaimsExchange
            .WithClaimsExistsPrecondition(BaseClaims.ObjectId)
            .AddClaimsExchange("SignUpWithLogonEmailExchange", tpLocalAccountSignUpWithLogonEmail))
    .AddOrchestrationStep(
        OrchestrationStepBuilder.AsClaimsExchange
            .AddClaimsExchange("AADUserReadWithObjectId", BaseAadTechnicalProfiles.AadaUserReadUsingObjectId))
    .AddOrchestrationStep(
        OrchestrationStepBuilder.AsClaimsExchange
            .WithClaimsEqualsPrecondition(isTosRenewalNeeded, "False")
            .AddClaimsExchange("RefreshTOS", tpSelfAsserted_RefreshTOS))
    .AddOrchestrationStep(
        OrchestrationStepBuilder.AsClaimsExchange
            .AddClaimsExchange("AAD-ReadTOS", tpAAD_ReadTOS))
    .AddOrchestrationStep(OrchestrationStepBuilder.AsJwtIssuer)
    .UsingDefaultWebClientDefinition();

```

### Relying Party

```csharp

var rp = RelyingPartyBuilder.Init("TermsOfServiceSignUpOrSignIn")
            .SetTechnicalProfile(
                TechnicalProfileBuilder.Init("PolicyProfile", "PolicyProfile", ProtocolName.OpenIdConnect)
                    .ReturnsClaim(BaseClaims.DisplayName)
                    .ReturnsClaim(BaseClaims.GivenName)
                    .ReturnsClaim(BaseClaims.Surname)
                    .ReturnsClaim(BaseClaims.Email)
                    .ReturnsClaim(BaseClaims.ObjectId, "sub")
                    .ReturnsClaim(BaseClaims.TenantId, alwaysUseDefaultValue: true, defaultValue: "{Policy:TenantObjectId}")
                    .ReturnsClaim(persistedToS)
                    .ReturnsClaim(isTosRenewalNeeded)
                    .ReturnsClaim(currentToS)
                    .SetSubjectNaming(BaseClaims.Subject.Id)
            );

```

### Bringing It All Together

```csharp

ThePolicy.SetBuildingBlocks(
            BuildingBlockBuilder.Init()
            .AddClaims(agreedToToS, persistedToS, currentToS, isTosRenewalNeeded)
            .AddClaimsTransformations(isToSRenewalNeededTransform, assertToSSelectedTransform))
        .SetClaimsProviders(
            ClaimsProviderBuilder.Init("Local Account SignIn")
                .AddTechnicalProfile(tpLocalAccountSignUpWithLogonEmail)
                .AddTechnicalProfile(tpAAD_UserWriteUsingLogonEmail)
                .AddTechnicalProfile(tpSelfAsserted_LocalAccountSignin_Email)
                .AddTechnicalProfile(tpAAD_ReadTOS),
            ClaimsProviderBuilder.Init("Self Asserted Terms And Use Refresh if Not Valid")
                .AddTechnicalProfile(tpSelfAsserted_RefreshTOS),
            ClaimsProviderBuilder.Init("Write Updated Terms of Service")
                .AddTechnicalProfile(tpVerfiyTOSConsentedTo)
                .AddTechnicalProfile(tpAAD_UserWriteProfileUsingObjectIdUpdateTOU)
                .AddTechnicalProfile(tpCheckTOSrequirement))
        .SetUserJourneys(susiJourney)
        .SetRelyingParty(rp);

```

## Invoking The Policy To Build The XML

This step would be done outside the `Policy` derived file, usually a `Program` type of console app.

The `tfbXml` and `tfeXml` objects are pre-built, parameterized representations of the TrustFrameworkBase and TrustFrameworkExtensions policies that you would find in the SocialAndLocalAccounts starter pack.

```csharp

var tfbXml = SocialAndLocalAccounts.TrustFrameworkBase("B2C_1A_TrustFrameworkBase2",
    "<TENANT>.onmicrosoft.com",
    new Contact("<ID>", "<NAME>", "<EMAIL>", "<ROLE>", "<PHONE>"));
var tfeXml = SocialAndLocalAccounts.TrustFrameworkExtensions("B2C_1A_TrustFrameworkExtensions2",
    tfbXml,
    "f90819e3-5bf8-47d3-a3ba-ef1cdb881001", "23325ef3-abd9-4b61-a181-2fcb3f091308",
    "c25a5888-69c3-4cb4-8d8d-87dbbce4816b", "5befcf9a-7198-4d88-af33-e5a5b906eaa2");

var tos = new TermsOfServiceSignUpOrSignIn("B2C_1A_TermsOfServiceSignUpOrSignIn", tfeXml);
tos.ThePolicy.BuildToFile(@"c:\temp");

```

Once you build the TermsOfService policy, you can inspect the XML and it should be very close to the sample XML that you can find [here](https://github.com/azure-ad-b2c/samples/blob/master/policies/terms-of-service/policy/terms-of-service.xml). 