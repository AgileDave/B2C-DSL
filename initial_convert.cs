namespace Generated {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class BasePolicy {
        
        private string tenantIdField;
        
        private string policyIdField;
        
        /// <remarks/>
        public string TenantId {
            get {
                return this.tenantIdField;
            }
            set {
                this.tenantIdField = value;
            }
        }
        
        /// <remarks/>
        public string PolicyId {
            get {
                return this.policyIdField;
            }
            set {
                this.policyIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TenantListType {
        
        private TenantReferenceType[] tenantField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Tenant")]
        public TenantReferenceType[] Tenant {
            get {
                return this.tenantField;
            }
            set {
                this.tenantField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TenantReferenceType {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Item {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PersistedClaim {
        
        private string claimTypeReferenceIdField;
        
        private string partnerClaimTypeField;
        
        private string defaultValueField;
        
        private bool overwriteIfExistsField;
        
        private bool overwriteIfExistsFieldSpecified;
        
        private bool alwaysUseDefaultValueField;
        
        private bool alwaysUseDefaultValueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimTypeReferenceId {
            get {
                return this.claimTypeReferenceIdField;
            }
            set {
                this.claimTypeReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PartnerClaimType {
            get {
                return this.partnerClaimTypeField;
            }
            set {
                this.partnerClaimTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool OverwriteIfExists {
            get {
                return this.overwriteIfExistsField;
            }
            set {
                this.overwriteIfExistsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverwriteIfExistsSpecified {
            get {
                return this.overwriteIfExistsFieldSpecified;
            }
            set {
                this.overwriteIfExistsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlwaysUseDefaultValue {
            get {
                return this.alwaysUseDefaultValueField;
            }
            set {
                this.alwaysUseDefaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlwaysUseDefaultValueSpecified {
            get {
                return this.alwaysUseDefaultValueFieldSpecified;
            }
            set {
                this.alwaysUseDefaultValueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Precondition {
        
        private string[] valueField;
        
        private PreconditionActionType[] actionField;
        
        private PreconditionType typeField;
        
        private bool executeActionsIfField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Action")]
        public PreconditionActionType[] Action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PreconditionType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExecuteActionsIf {
            get {
                return this.executeActionsIfField;
            }
            set {
                this.executeActionsIfField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum PreconditionActionType {
        
        /// <remarks/>
        SkipThisOrchestrationStep,
        
        /// <remarks/>
        SkipThisValidationTechnicalProfile,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum PreconditionType {
        
        /// <remarks/>
        ClaimsExist,
        
        /// <remarks/>
        ClaimEquals,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Candidate {
        
        private string subJourneyReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubJourneyReferenceId {
            get {
                return this.subJourneyReferenceIdField;
            }
            set {
                this.subJourneyReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class OrchestrationStep {
        
        private Precondition[][] preconditionsField;
        
        private ClaimsProviderSelections[] claimsProviderSelectionsField;
        
        private ClaimsExchanges[] claimsExchangesField;
        
        private Candidate[][] journeyListField;
        
        private int orderField;
        
        private OrchestrationStepType typeField;
        
        private string contentDefinitionReferenceIdField;
        
        private string cpimIssuerTechnicalProfileReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(Precondition), IsNullable=false)]
        public Precondition[][] Preconditions {
            get {
                return this.preconditionsField;
            }
            set {
                this.preconditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClaimsProviderSelections")]
        public ClaimsProviderSelections[] ClaimsProviderSelections {
            get {
                return this.claimsProviderSelectionsField;
            }
            set {
                this.claimsProviderSelectionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClaimsExchanges")]
        public ClaimsExchanges[] ClaimsExchanges {
            get {
                return this.claimsExchangesField;
            }
            set {
                this.claimsExchangesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(Candidate), IsNullable=false)]
        public Candidate[][] JourneyList {
            get {
                return this.journeyListField;
            }
            set {
                this.journeyListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Order {
            get {
                return this.orderField;
            }
            set {
                this.orderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OrchestrationStepType Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentDefinitionReferenceId {
            get {
                return this.contentDefinitionReferenceIdField;
            }
            set {
                this.contentDefinitionReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CpimIssuerTechnicalProfileReferenceId {
            get {
                return this.cpimIssuerTechnicalProfileReferenceIdField;
            }
            set {
                this.cpimIssuerTechnicalProfileReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsProviderSelections {
        
        private ClaimsProviderSelection[] claimsProviderSelectionField;
        
        private ClaimsProviderSelectionDisplayOption displayOptionField;
        
        public ClaimsProviderSelections() {
            this.displayOptionField = ClaimsProviderSelectionDisplayOption.DoNotShowSingleProvider;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClaimsProviderSelection")]
        public ClaimsProviderSelection[] ClaimsProviderSelection {
            get {
                return this.claimsProviderSelectionField;
            }
            set {
                this.claimsProviderSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ClaimsProviderSelectionDisplayOption.DoNotShowSingleProvider)]
        public ClaimsProviderSelectionDisplayOption DisplayOption {
            get {
                return this.displayOptionField;
            }
            set {
                this.displayOptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsProviderSelection {
        
        private string targetClaimsExchangeIdField;
        
        private string validationClaimsExchangeIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetClaimsExchangeId {
            get {
                return this.targetClaimsExchangeIdField;
            }
            set {
                this.targetClaimsExchangeIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ValidationClaimsExchangeId {
            get {
                return this.validationClaimsExchangeIdField;
            }
            set {
                this.validationClaimsExchangeIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum ClaimsProviderSelectionDisplayOption {
        
        /// <remarks/>
        DoNotShowSingleProvider,
        
        /// <remarks/>
        ShowSingleProvider,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsExchanges {
        
        private ClaimsExchange[] claimsExchangeField;
        
        private bool userIdentityField;
        
        public ClaimsExchanges() {
            this.userIdentityField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClaimsExchange")]
        public ClaimsExchange[] ClaimsExchange {
            get {
                return this.claimsExchangeField;
            }
            set {
                this.claimsExchangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserIdentity {
            get {
                return this.userIdentityField;
            }
            set {
                this.userIdentityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsExchange {
        
        private string idField;
        
        private string technicalProfileReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TechnicalProfileReferenceId {
            get {
                return this.technicalProfileReferenceIdField;
            }
            set {
                this.technicalProfileReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum OrchestrationStepType {
        
        /// <remarks/>
        ConsentScreen,
        
        /// <remarks/>
        ClaimsProviderSelection,
        
        /// <remarks/>
        CombinedSignInAndSignUp,
        
        /// <remarks/>
        ClaimsExchange,
        
        /// <remarks/>
        ReviewScreen,
        
        /// <remarks/>
        SendClaims,
        
        /// <remarks/>
        GetClaims,
        
        /// <remarks/>
        UserDialog,
        
        /// <remarks/>
        InvokeSubJourney,
        
        /// <remarks/>
        Noop,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimType {
        
        private string displayNameField;
        
        private DataType dataTypeField;
        
        private bool dataTypeFieldSpecified;
        
        private ClaimTypeDefaultPartnerClaimTypesProtocol[][] defaultPartnerClaimTypesField;
        
        private claimMaskTYPE maskField;
        
        private string adminHelpTextField;
        
        private string userHelpTextField;
        
        private UserInputType userInputTypeField;
        
        private bool userInputTypeFieldSpecified;
        
        private Restriction restrictionField;
        
        private InputValidationReference inputValidationReferenceField;
        
        private PredicateValidationReference predicateValidationReferenceField;
        
        private string idField;
        
        private StatementType statementTypeField;
        
        public ClaimType() {
            this.statementTypeField = StatementType.Attribute;
        }
        
        /// <remarks/>
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public DataType DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataTypeSpecified {
            get {
                return this.dataTypeFieldSpecified;
            }
            set {
                this.dataTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Protocol", typeof(ClaimTypeDefaultPartnerClaimTypesProtocol), IsNullable=false)]
        public ClaimTypeDefaultPartnerClaimTypesProtocol[][] DefaultPartnerClaimTypes {
            get {
                return this.defaultPartnerClaimTypesField;
            }
            set {
                this.defaultPartnerClaimTypesField = value;
            }
        }
        
        /// <remarks/>
        public claimMaskTYPE Mask {
            get {
                return this.maskField;
            }
            set {
                this.maskField = value;
            }
        }
        
        /// <remarks/>
        public string AdminHelpText {
            get {
                return this.adminHelpTextField;
            }
            set {
                this.adminHelpTextField = value;
            }
        }
        
        /// <remarks/>
        public string UserHelpText {
            get {
                return this.userHelpTextField;
            }
            set {
                this.userHelpTextField = value;
            }
        }
        
        /// <remarks/>
        public UserInputType UserInputType {
            get {
                return this.userInputTypeField;
            }
            set {
                this.userInputTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserInputTypeSpecified {
            get {
                return this.userInputTypeFieldSpecified;
            }
            set {
                this.userInputTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Restriction Restriction {
            get {
                return this.restrictionField;
            }
            set {
                this.restrictionField = value;
            }
        }
        
        /// <remarks/>
        public InputValidationReference InputValidationReference {
            get {
                return this.inputValidationReferenceField;
            }
            set {
                this.inputValidationReferenceField = value;
            }
        }
        
        /// <remarks/>
        public PredicateValidationReference PredicateValidationReference {
            get {
                return this.predicateValidationReferenceField;
            }
            set {
                this.predicateValidationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StatementType.Attribute)]
        public StatementType StatementType {
            get {
                return this.statementTypeField;
            }
            set {
                this.statementTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum DataType {
        
        /// <remarks/>
        boolean,
        
        /// <remarks/>
        date,
        
        /// <remarks/>
        dateTime,
        
        /// <remarks/>
        duration,
        
        /// <remarks/>
        @int,
        
        /// <remarks/>
        @long,
        
        /// <remarks/>
        @string,
        
        /// <remarks/>
        stringCollection,
        
        /// <remarks/>
        alternativeSecurityIdCollection,
        
        /// <remarks/>
        userIdentityCollection,
        
        /// <remarks/>
        userIdentity,
        
        /// <remarks/>
        phoneNumber,
        
        /// <remarks/>
        objectIdentityCollection,
        
        /// <remarks/>
        objectIdentity,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimTypeDefaultPartnerClaimTypesProtocol {
        
        private ProtocolName nameField;
        
        private string handlerField;
        
        private string partnerClaimTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProtocolName Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Handler {
            get {
                return this.handlerField;
            }
            set {
                this.handlerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PartnerClaimType {
            get {
                return this.partnerClaimTypeField;
            }
            set {
                this.partnerClaimTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum ProtocolName {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        OAuth1,
        
        /// <remarks/>
        OAuth2,
        
        /// <remarks/>
        SAML2,
        
        /// <remarks/>
        OpenIdConnect,
        
        /// <remarks/>
        WsFed,
        
        /// <remarks/>
        WsTrust,
        
        /// <remarks/>
        UProve11,
        
        /// <remarks/>
        Proprietary,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class claimMaskTYPE {
        
        private MaskTypeTYPE typeField;
        
        private string regexField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MaskTypeTYPE Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Regex {
            get {
                return this.regexField;
            }
            set {
                this.regexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum MaskTypeTYPE {
        
        /// <remarks/>
        Simple,
        
        /// <remarks/>
        Regex,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum UserInputType {
        
        /// <remarks/>
        TextBox,
        
        /// <remarks/>
        EmailBox,
        
        /// <remarks/>
        DateTimeDropdown,
        
        /// <remarks/>
        RadioSingleSelect,
        
        /// <remarks/>
        DropdownSingleSelect,
        
        /// <remarks/>
        CheckboxMultiSelect,
        
        /// <remarks/>
        Password,
        
        /// <remarks/>
        Readonly,
        
        /// <remarks/>
        Button,
        
        /// <remarks/>
        Paragraph,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Restriction {
        
        private object[] itemsField;
        
        private MergeBehavior mergeBehaviorField;
        
        private bool mergeBehaviorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Enumeration", typeof(EnumerationItem))]
        [System.Xml.Serialization.XmlElementAttribute("Pattern", typeof(Pattern))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MergeBehavior MergeBehavior {
            get {
                return this.mergeBehaviorField;
            }
            set {
                this.mergeBehaviorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified {
            get {
                return this.mergeBehaviorFieldSpecified;
            }
            set {
                this.mergeBehaviorFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class EnumerationItem {
        
        private string textField;
        
        private string valueField;
        
        private bool selectByDefaultField;
        
        private bool selectByDefaultFieldSpecified;
        
        private string value1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SelectByDefault {
            get {
                return this.selectByDefaultField;
            }
            set {
                this.selectByDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectByDefaultSpecified {
            get {
                return this.selectByDefaultFieldSpecified;
            }
            set {
                this.selectByDefaultFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value1 {
            get {
                return this.value1Field;
            }
            set {
                this.value1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Pattern {
        
        private string regularExpressionField;
        
        private string helpTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegularExpression {
            get {
                return this.regularExpressionField;
            }
            set {
                this.regularExpressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HelpText {
            get {
                return this.helpTextField;
            }
            set {
                this.helpTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum MergeBehavior {
        
        /// <remarks/>
        Append,
        
        /// <remarks/>
        Prepend,
        
        /// <remarks/>
        ReplaceAll,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class InputValidationReference {
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PredicateValidationReference {
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum StatementType {
        
        /// <remarks/>
        Attribute,
        
        /// <remarks/>
        Authentication,
        
        /// <remarks/>
        Subject,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Parameter {
        
        private string idField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Predicate {
        
        private string userHelpTextField;
        
        private Parameter[] parametersField;
        
        private string idField;
        
        private string methodField;
        
        private string helpTextField;
        
        /// <remarks/>
        public string UserHelpText {
            get {
                return this.userHelpTextField;
            }
            set {
                this.userHelpTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Parameter[] Parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HelpText {
            get {
                return this.helpTextField;
            }
            set {
                this.helpTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class InputValidation {
        
        private PredicateReferences[] predicateReferencesField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PredicateReferences")]
        public PredicateReferences[] PredicateReferences {
            get {
                return this.predicateReferencesField;
            }
            set {
                this.predicateReferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PredicateReferences {
        
        private PredicateReference[] predicateReferenceField;
        
        private string idField;
        
        private string helpTextField;
        
        private string matchAtLeastField;
        
        private bool rejectField;
        
        private bool rejectFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PredicateReference")]
        public PredicateReference[] PredicateReference {
            get {
                return this.predicateReferenceField;
            }
            set {
                this.predicateReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HelpText {
            get {
                return this.helpTextField;
            }
            set {
                this.helpTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string MatchAtLeast {
            get {
                return this.matchAtLeastField;
            }
            set {
                this.matchAtLeastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Reject {
            get {
                return this.rejectField;
            }
            set {
                this.rejectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RejectSpecified {
            get {
                return this.rejectFieldSpecified;
            }
            set {
                this.rejectFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PredicateReference {
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PredicateGroup {
        
        private string userHelpTextField;
        
        private PredicateReferences[] predicateReferencesField;
        
        private string idField;
        
        /// <remarks/>
        public string UserHelpText {
            get {
                return this.userHelpTextField;
            }
            set {
                this.userHelpTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PredicateReferences")]
        public PredicateReferences[] PredicateReferences {
            get {
                return this.predicateReferencesField;
            }
            set {
                this.predicateReferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PredicateValidation {
        
        private PredicateGroup[][] predicateGroupsField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(PredicateGroup), IsNullable=false)]
        public PredicateGroup[][] PredicateGroups {
            get {
                return this.predicateGroupsField;
            }
            set {
                this.predicateGroupsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsTransformation {
        
        private ClaimsTransformationClaimTypeReference[] inputClaimsField;
        
        private ClaimsTransformationParameter[] inputParametersField;
        
        private ClaimsTransformationClaimTypeReference[] outputClaimsField;
        
        private string idField;
        
        private string transformationMethodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InputClaim", IsNullable=false)]
        public ClaimsTransformationClaimTypeReference[] InputClaims {
            get {
                return this.inputClaimsField;
            }
            set {
                this.inputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InputParameter", IsNullable=false)]
        public ClaimsTransformationParameter[] InputParameters {
            get {
                return this.inputParametersField;
            }
            set {
                this.inputParametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputClaim", IsNullable=false)]
        public ClaimsTransformationClaimTypeReference[] OutputClaims {
            get {
                return this.outputClaimsField;
            }
            set {
                this.outputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransformationMethod {
            get {
                return this.transformationMethodField;
            }
            set {
                this.transformationMethodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsTransformationClaimTypeReference {
        
        private string claimTypeReferenceIdField;
        
        private string transformationClaimTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimTypeReferenceId {
            get {
                return this.claimTypeReferenceIdField;
            }
            set {
                this.claimTypeReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TransformationClaimType {
            get {
                return this.transformationClaimTypeField;
            }
            set {
                this.transformationClaimTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsTransformationParameter {
        
        private string idField;
        
        private DataType dataTypeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataType DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClientDefinition {
        
        private string clientUIFilterFlagsField;
        
        private string idField;
        
        /// <remarks/>
        public string ClientUIFilterFlags {
            get {
                return this.clientUIFilterFlagsField;
            }
            set {
                this.clientUIFilterFlagsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class LocalizedCollection {
        
        private EnumerationItem[] itemField;
        
        private string elementTypeField;
        
        private string elementIdField;
        
        private string targetCollectionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public EnumerationItem[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElementType {
            get {
                return this.elementTypeField;
            }
            set {
                this.elementTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElementId {
            get {
                return this.elementIdField;
            }
            set {
                this.elementIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetCollection {
            get {
                return this.targetCollectionField;
            }
            set {
                this.targetCollectionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class LocalizedString {
        
        private string elementTypeField;
        
        private string elementIdField;
        
        private string stringIdField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElementType {
            get {
                return this.elementTypeField;
            }
            set {
                this.elementTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElementId {
            get {
                return this.elementIdField;
            }
            set {
                this.elementIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StringId {
            get {
                return this.stringIdField;
            }
            set {
                this.stringIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfile {
        
        private string[] domainsField;
        
        private string domainField;
        
        private string displayNameField;
        
        private string descriptionField;
        
        private TechnicalProfileProtocol protocolField;
        
        private TokenFormat inputTokenFormatField;
        
        private bool inputTokenFormatFieldSpecified;
        
        private TokenFormat outputTokenFormatField;
        
        private bool outputTokenFormatFieldSpecified;
        
        private string assuranceLevelOfOutputClaimsField;
        
        private string[] requiredAssuranceLevelsOfInputClaimsField;
        
        private TechnicalProfileSubjectAuthenticationRequirements subjectAuthenticationRequirementsField;
        
        private metadataItemTYPE[] metadataField;
        
        private CryptographicKeysKey[] cryptographicKeysField;
        
        private Item[] suppressionsField;
        
        private string preferredBindingField;
        
        private bool includeInSsoField;
        
        private bool includeInSsoFieldSpecified;
        
        private InputTokenSourcesTechnicalProfile[] inputTokenSourcesField;
        
        private ClaimsTransformationReference[][] inputClaimsTransformationsField;
        
        private ClaimsSchemaClaimTypeReference[] inputClaimsField;
        
        private DisplayClaimReference[] displayClaimsField;
        
        private PersistedClaim[] persistedClaimsField;
        
        private ClaimsSchemaClaimTypeReference[] outputClaimsField;
        
        private ClaimsTransformationReference[][] outputClaimsTransformationsField;
        
        private TechnicalProfileValidationTechnicalProfilesValidationTechnicalProfile[][] validationTechnicalProfilesField;
        
        private TechnicalProfileSubjectNamingInfo subjectNamingInfoField;
        
        private Extensions extensionsField;
        
        private string includeClaimsFromTechnicalProfileField;
        
        private TechnicalProfileIncludeTechnicalProfile includeTechnicalProfileField;
        
        private TechnicalProfileUseTechnicalProfileForSessionManagement useTechnicalProfileForSessionManagementField;
        
        private TechnicalProfileErrorHandler[] errorHandlersField;
        
        private EnabledForUserJourneysValues enabledForUserJourneysField;
        
        private bool enabledForUserJourneysFieldSpecified;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Domain", IsNullable=false)]
        public string[] Domains {
            get {
                return this.domainsField;
            }
            set {
                this.domainsField = value;
            }
        }
        
        /// <remarks/>
        public string Domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public TechnicalProfileProtocol Protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        
        /// <remarks/>
        public TokenFormat InputTokenFormat {
            get {
                return this.inputTokenFormatField;
            }
            set {
                this.inputTokenFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InputTokenFormatSpecified {
            get {
                return this.inputTokenFormatFieldSpecified;
            }
            set {
                this.inputTokenFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TokenFormat OutputTokenFormat {
            get {
                return this.outputTokenFormatField;
            }
            set {
                this.outputTokenFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutputTokenFormatSpecified {
            get {
                return this.outputTokenFormatFieldSpecified;
            }
            set {
                this.outputTokenFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string AssuranceLevelOfOutputClaims {
            get {
                return this.assuranceLevelOfOutputClaimsField;
            }
            set {
                this.assuranceLevelOfOutputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RequiredAssuranceLevelOfInputClaims", IsNullable=false)]
        public string[] RequiredAssuranceLevelsOfInputClaims {
            get {
                return this.requiredAssuranceLevelsOfInputClaimsField;
            }
            set {
                this.requiredAssuranceLevelsOfInputClaimsField = value;
            }
        }
        
        /// <remarks/>
        public TechnicalProfileSubjectAuthenticationRequirements SubjectAuthenticationRequirements {
            get {
                return this.subjectAuthenticationRequirementsField;
            }
            set {
                this.subjectAuthenticationRequirementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public metadataItemTYPE[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Key", IsNullable=false)]
        public CryptographicKeysKey[] CryptographicKeys {
            get {
                return this.cryptographicKeysField;
            }
            set {
                this.cryptographicKeysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Item[] Suppressions {
            get {
                return this.suppressionsField;
            }
            set {
                this.suppressionsField = value;
            }
        }
        
        /// <remarks/>
        public string PreferredBinding {
            get {
                return this.preferredBindingField;
            }
            set {
                this.preferredBindingField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeInSso {
            get {
                return this.includeInSsoField;
            }
            set {
                this.includeInSsoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeInSsoSpecified {
            get {
                return this.includeInSsoFieldSpecified;
            }
            set {
                this.includeInSsoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TechnicalProfile", IsNullable=false)]
        public InputTokenSourcesTechnicalProfile[] InputTokenSources {
            get {
                return this.inputTokenSourcesField;
            }
            set {
                this.inputTokenSourcesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InputClaimsTransformation", typeof(ClaimsTransformationReference), IsNullable=false)]
        public ClaimsTransformationReference[][] InputClaimsTransformations {
            get {
                return this.inputClaimsTransformationsField;
            }
            set {
                this.inputClaimsTransformationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InputClaim", IsNullable=false)]
        public ClaimsSchemaClaimTypeReference[] InputClaims {
            get {
                return this.inputClaimsField;
            }
            set {
                this.inputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DisplayClaim", IsNullable=false)]
        public DisplayClaimReference[] DisplayClaims {
            get {
                return this.displayClaimsField;
            }
            set {
                this.displayClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PersistedClaim[] PersistedClaims {
            get {
                return this.persistedClaimsField;
            }
            set {
                this.persistedClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputClaim", IsNullable=false)]
        public ClaimsSchemaClaimTypeReference[] OutputClaims {
            get {
                return this.outputClaimsField;
            }
            set {
                this.outputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputClaimsTransformation", typeof(ClaimsTransformationReference), IsNullable=false)]
        public ClaimsTransformationReference[][] OutputClaimsTransformations {
            get {
                return this.outputClaimsTransformationsField;
            }
            set {
                this.outputClaimsTransformationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidationTechnicalProfile", typeof(TechnicalProfileValidationTechnicalProfilesValidationTechnicalProfile), IsNullable=false)]
        public TechnicalProfileValidationTechnicalProfilesValidationTechnicalProfile[][] ValidationTechnicalProfiles {
            get {
                return this.validationTechnicalProfilesField;
            }
            set {
                this.validationTechnicalProfilesField = value;
            }
        }
        
        /// <remarks/>
        public TechnicalProfileSubjectNamingInfo SubjectNamingInfo {
            get {
                return this.subjectNamingInfoField;
            }
            set {
                this.subjectNamingInfoField = value;
            }
        }
        
        /// <remarks/>
        public Extensions Extensions {
            get {
                return this.extensionsField;
            }
            set {
                this.extensionsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeClaimsFromTechnicalProfile {
            get {
                return this.includeClaimsFromTechnicalProfileField;
            }
            set {
                this.includeClaimsFromTechnicalProfileField = value;
            }
        }
        
        /// <remarks/>
        public TechnicalProfileIncludeTechnicalProfile IncludeTechnicalProfile {
            get {
                return this.includeTechnicalProfileField;
            }
            set {
                this.includeTechnicalProfileField = value;
            }
        }
        
        /// <remarks/>
        public TechnicalProfileUseTechnicalProfileForSessionManagement UseTechnicalProfileForSessionManagement {
            get {
                return this.useTechnicalProfileForSessionManagementField;
            }
            set {
                this.useTechnicalProfileForSessionManagementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ErrorHandler", IsNullable=false)]
        public TechnicalProfileErrorHandler[] ErrorHandlers {
            get {
                return this.errorHandlersField;
            }
            set {
                this.errorHandlersField = value;
            }
        }
        
        /// <remarks/>
        public EnabledForUserJourneysValues EnabledForUserJourneys {
            get {
                return this.enabledForUserJourneysField;
            }
            set {
                this.enabledForUserJourneysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledForUserJourneysSpecified {
            get {
                return this.enabledForUserJourneysFieldSpecified;
            }
            set {
                this.enabledForUserJourneysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileProtocol {
        
        private ProtocolName nameField;
        
        private string handlerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProtocolName Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Handler {
            get {
                return this.handlerField;
            }
            set {
                this.handlerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum TokenFormat {
        
        /// <remarks/>
        JSON,
        
        /// <remarks/>
        JWT,
        
        /// <remarks/>
        SAML11,
        
        /// <remarks/>
        SAML2,
        
        /// <remarks/>
        CpimUnsigned,
        
        /// <remarks/>
        UProve11,
        
        /// <remarks/>
        OAuth2Error,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileSubjectAuthenticationRequirements {
        
        private int timeToLiveField;
        
        private bool resetExpiryWhenTokenIssuedField;
        
        private bool resetExpiryWhenTokenIssuedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int TimeToLive {
            get {
                return this.timeToLiveField;
            }
            set {
                this.timeToLiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ResetExpiryWhenTokenIssued {
            get {
                return this.resetExpiryWhenTokenIssuedField;
            }
            set {
                this.resetExpiryWhenTokenIssuedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResetExpiryWhenTokenIssuedSpecified {
            get {
                return this.resetExpiryWhenTokenIssuedFieldSpecified;
            }
            set {
                this.resetExpiryWhenTokenIssuedFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class metadataItemTYPE {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class CryptographicKeysKey {
        
        private string idField;
        
        private string storageReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StorageReferenceId {
            get {
                return this.storageReferenceIdField;
            }
            set {
                this.storageReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class InputTokenSourcesTechnicalProfile {
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsTransformationReference {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsSchemaClaimTypeReference {
        
        private FromTechnicalProfileReference[] fromField;
        
        private string claimTypeReferenceIdField;
        
        private string partnerClaimTypeField;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        private string defaultValueField;
        
        private bool alwaysUseDefaultValueField;
        
        private bool alwaysUseDefaultValueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("From")]
        public FromTechnicalProfileReference[] From {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimTypeReferenceId {
            get {
                return this.claimTypeReferenceIdField;
            }
            set {
                this.claimTypeReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PartnerClaimType {
            get {
                return this.partnerClaimTypeField;
            }
            set {
                this.partnerClaimTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlwaysUseDefaultValue {
            get {
                return this.alwaysUseDefaultValueField;
            }
            set {
                this.alwaysUseDefaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlwaysUseDefaultValueSpecified {
            get {
                return this.alwaysUseDefaultValueFieldSpecified;
            }
            set {
                this.alwaysUseDefaultValueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class FromTechnicalProfileReference {
        
        private string technicalProfileReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TechnicalProfileReferenceId {
            get {
                return this.technicalProfileReferenceIdField;
            }
            set {
                this.technicalProfileReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayClaimReference {
        
        private string claimTypeReferenceIdField;
        
        private string displayControlReferenceIdField;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimTypeReferenceId {
            get {
                return this.claimTypeReferenceIdField;
            }
            set {
                this.claimTypeReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayControlReferenceId {
            get {
                return this.displayControlReferenceIdField;
            }
            set {
                this.displayControlReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileValidationTechnicalProfilesValidationTechnicalProfile {
        
        private Precondition[][] preconditionsField;
        
        private string referenceIdField;
        
        private bool continueOnSuccessField;
        
        private bool continueOnSuccessFieldSpecified;
        
        private bool continueOnErrorField;
        
        private bool continueOnErrorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(Precondition), IsNullable=false)]
        public Precondition[][] Preconditions {
            get {
                return this.preconditionsField;
            }
            set {
                this.preconditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ContinueOnSuccess {
            get {
                return this.continueOnSuccessField;
            }
            set {
                this.continueOnSuccessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContinueOnSuccessSpecified {
            get {
                return this.continueOnSuccessFieldSpecified;
            }
            set {
                this.continueOnSuccessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ContinueOnError {
            get {
                return this.continueOnErrorField;
            }
            set {
                this.continueOnErrorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContinueOnErrorSpecified {
            get {
                return this.continueOnErrorFieldSpecified;
            }
            set {
                this.continueOnErrorFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileSubjectNamingInfo {
        
        private string claimTypeField;
        
        private string nameQualifierField;
        
        private string sPNameQualifierField;
        
        private string formatField;
        
        private string sPProvidedIDField;
        
        private bool excludeAsClaimField;
        
        private bool excludeAsClaimFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimType {
            get {
                return this.claimTypeField;
            }
            set {
                this.claimTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameQualifier {
            get {
                return this.nameQualifierField;
            }
            set {
                this.nameQualifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SPNameQualifier {
            get {
                return this.sPNameQualifierField;
            }
            set {
                this.sPNameQualifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SPProvidedID {
            get {
                return this.sPProvidedIDField;
            }
            set {
                this.sPProvidedIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ExcludeAsClaim {
            get {
                return this.excludeAsClaimField;
            }
            set {
                this.excludeAsClaimField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExcludeAsClaimSpecified {
            get {
                return this.excludeAsClaimFieldSpecified;
            }
            set {
                this.excludeAsClaimFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Extensions {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileIncludeTechnicalProfile {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileUseTechnicalProfileForSessionManagement {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileErrorHandler {
        
        private ErrorResponseFormat errorResponseFormatField;
        
        private bool errorResponseFormatFieldSpecified;
        
        private string responseMatchField;
        
        private ErrorHandlingAction actionField;
        
        private TechnicalProfileErrorHandlerAdditionalRequestParameters[] additionalRequestParametersField;
        
        /// <remarks/>
        public ErrorResponseFormat ErrorResponseFormat {
            get {
                return this.errorResponseFormatField;
            }
            set {
                this.errorResponseFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorResponseFormatSpecified {
            get {
                return this.errorResponseFormatFieldSpecified;
            }
            set {
                this.errorResponseFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ResponseMatch {
            get {
                return this.responseMatchField;
            }
            set {
                this.responseMatchField = value;
            }
        }
        
        /// <remarks/>
        public ErrorHandlingAction Action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalRequestParameters")]
        public TechnicalProfileErrorHandlerAdditionalRequestParameters[] AdditionalRequestParameters {
            get {
                return this.additionalRequestParametersField;
            }
            set {
                this.additionalRequestParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum ErrorResponseFormat {
        
        /// <remarks/>
        json,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum ErrorHandlingAction {
        
        /// <remarks/>
        Reauthenticate,
        
        /// <remarks/>
        InvalidClient,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TechnicalProfileErrorHandlerAdditionalRequestParameters {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum EnabledForUserJourneysValues {
        
        /// <remarks/>
        @true,
        
        /// <remarks/>
        @false,
        
        /// <remarks/>
        OnClaimsExistence,
        
        /// <remarks/>
        Always,
        
        /// <remarks/>
        Never,
        
        /// <remarks/>
        OnItemExistenceInStringCollectionClaim,
        
        /// <remarks/>
        OnItemAbsenceInStringCollectionClaim,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ContentDefinition {
        
        private object loadUriField;
        
        private string recoveryUriField;
        
        private string dataUriField;
        
        private metadataItemTYPE[] metadataField;
        
        private ContentDefinitionLocalizedResourcesReferences localizedResourcesReferencesField;
        
        private string idField;
        
        /// <remarks/>
        public object LoadUri {
            get {
                return this.loadUriField;
            }
            set {
                this.loadUriField = value;
            }
        }
        
        /// <remarks/>
        public string RecoveryUri {
            get {
                return this.recoveryUriField;
            }
            set {
                this.recoveryUriField = value;
            }
        }
        
        /// <remarks/>
        public string DataUri {
            get {
                return this.dataUriField;
            }
            set {
                this.dataUriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public metadataItemTYPE[] Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        
        /// <remarks/>
        public ContentDefinitionLocalizedResourcesReferences LocalizedResourcesReferences {
            get {
                return this.localizedResourcesReferencesField;
            }
            set {
                this.localizedResourcesReferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ContentDefinitionLocalizedResourcesReferences {
        
        private LocalizedResourcesReference[] localizedResourcesReferenceField;
        
        private MergeBehavior mergeBehaviorField;
        
        private bool mergeBehaviorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocalizedResourcesReference")]
        public LocalizedResourcesReference[] LocalizedResourcesReference {
            get {
                return this.localizedResourcesReferenceField;
            }
            set {
                this.localizedResourcesReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MergeBehavior MergeBehavior {
            get {
                return this.mergeBehaviorField;
            }
            set {
                this.mergeBehaviorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified {
            get {
                return this.mergeBehaviorFieldSpecified;
            }
            set {
                this.mergeBehaviorFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class LocalizedResourcesReference {
        
        private string languageField;
        
        private string urlField;
        
        private string localizedResourcesReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocalizedResourcesReferenceId {
            get {
                return this.localizedResourcesReferenceIdField;
            }
            set {
                this.localizedResourcesReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayControl {
        
        private DisplayControlClaimTypeReference[] inputClaimsField;
        
        private DisplayControlDisplayClaimReference[] displayClaimsField;
        
        private DisplayControlClaimTypeReference[] outputClaimsField;
        
        private DisplayControlAction[] actionsField;
        
        private string idField;
        
        private UserInterfaceControlType userInterfaceControlTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InputClaim", IsNullable=false)]
        public DisplayControlClaimTypeReference[] InputClaims {
            get {
                return this.inputClaimsField;
            }
            set {
                this.inputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DisplayClaim", IsNullable=false)]
        public DisplayControlDisplayClaimReference[] DisplayClaims {
            get {
                return this.displayClaimsField;
            }
            set {
                this.displayClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OutputClaim", IsNullable=false)]
        public DisplayControlClaimTypeReference[] OutputClaims {
            get {
                return this.outputClaimsField;
            }
            set {
                this.outputClaimsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Action", IsNullable=false)]
        public DisplayControlAction[] Actions {
            get {
                return this.actionsField;
            }
            set {
                this.actionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UserInterfaceControlType UserInterfaceControlType {
            get {
                return this.userInterfaceControlTypeField;
            }
            set {
                this.userInterfaceControlTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayControlClaimTypeReference {
        
        private string claimTypeReferenceIdField;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        private string defaultValueField;
        
        private bool alwaysUseDefaultValueField;
        
        private bool alwaysUseDefaultValueFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimTypeReferenceId {
            get {
                return this.claimTypeReferenceIdField;
            }
            set {
                this.claimTypeReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AlwaysUseDefaultValue {
            get {
                return this.alwaysUseDefaultValueField;
            }
            set {
                this.alwaysUseDefaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlwaysUseDefaultValueSpecified {
            get {
                return this.alwaysUseDefaultValueFieldSpecified;
            }
            set {
                this.alwaysUseDefaultValueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayControlDisplayClaimReference {
        
        private string claimTypeReferenceIdField;
        
        private string controlClaimTypeField;
        
        private bool requiredField;
        
        private bool requiredFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaimTypeReferenceId {
            get {
                return this.claimTypeReferenceIdField;
            }
            set {
                this.claimTypeReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ControlClaimType {
            get {
                return this.controlClaimTypeField;
            }
            set {
                this.controlClaimTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequiredSpecified {
            get {
                return this.requiredFieldSpecified;
            }
            set {
                this.requiredFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayControlAction {
        
        private DisplayControlActionValidationClaimsExchangeTechnicalProfile[] validationClaimsExchangeField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidationClaimsExchangeTechnicalProfile", IsNullable=false)]
        public DisplayControlActionValidationClaimsExchangeTechnicalProfile[] ValidationClaimsExchange {
            get {
                return this.validationClaimsExchangeField;
            }
            set {
                this.validationClaimsExchangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DisplayControlActionValidationClaimsExchangeTechnicalProfile {
        
        private Precondition[][] preconditionsField;
        
        private string technicalProfileReferenceIdField;
        
        private bool continueOnSuccessField;
        
        private bool continueOnSuccessFieldSpecified;
        
        private bool continueOnErrorField;
        
        private bool continueOnErrorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(typeof(Precondition), IsNullable=false)]
        public Precondition[][] Preconditions {
            get {
                return this.preconditionsField;
            }
            set {
                this.preconditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TechnicalProfileReferenceId {
            get {
                return this.technicalProfileReferenceIdField;
            }
            set {
                this.technicalProfileReferenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ContinueOnSuccess {
            get {
                return this.continueOnSuccessField;
            }
            set {
                this.continueOnSuccessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContinueOnSuccessSpecified {
            get {
                return this.continueOnSuccessFieldSpecified;
            }
            set {
                this.continueOnSuccessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ContinueOnError {
            get {
                return this.continueOnErrorField;
            }
            set {
                this.continueOnErrorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContinueOnErrorSpecified {
            get {
                return this.continueOnErrorFieldSpecified;
            }
            set {
                this.continueOnErrorFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum UserInterfaceControlType {
        
        /// <remarks/>
        VerificationControl,
        
        /// <remarks/>
        QrCodeControl,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Contact {
        
        private string displayNameField;
        
        private string telephoneNumberField;
        
        private string emailField;
        
        private string roleField;
        
        private string idField;
        
        /// <remarks/>
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        public string TelephoneNumber {
            get {
                return this.telephoneNumberField;
            }
            set {
                this.telephoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class DocumentReference {
        
        private string displayNameField;
        
        private string urlField;
        
        private string idField;
        
        /// <remarks/>
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsProvider {
        
        private string[] domainsField;
        
        private string domainField;
        
        private string displayNameField;
        
        private TechnicalProfile[] technicalProfilesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Domain", IsNullable=false)]
        public string[] Domains {
            get {
                return this.domainsField;
            }
            set {
                this.domainsField = value;
            }
        }
        
        /// <remarks/>
        public string Domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
        
        /// <remarks/>
        public string DisplayName {
            get {
                return this.displayNameField;
            }
            set {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public TechnicalProfile[] TechnicalProfiles {
            get {
                return this.technicalProfilesField;
            }
            set {
                this.technicalProfilesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class UserJourney {
        
        private string assuranceLevelField;
        
        private bool preserveOriginalAssertionField;
        
        private bool preserveOriginalAssertionFieldSpecified;
        
        private UserJourneyAuthorization authorizationField;
        
        private OrchestrationStep[] orchestrationStepsField;
        
        private UserJourneyClientDefinition clientDefinitionField;
        
        private CryptographicKeysKey[] cryptographicKeysField;
        
        private string idField;
        
        private bool nonInteractiveField;
        
        private bool nonInteractiveFieldSpecified;
        
        private string defaultCpimIssuerTechnicalProfileReferenceIdField;
        
        /// <remarks/>
        public string AssuranceLevel {
            get {
                return this.assuranceLevelField;
            }
            set {
                this.assuranceLevelField = value;
            }
        }
        
        /// <remarks/>
        public bool PreserveOriginalAssertion {
            get {
                return this.preserveOriginalAssertionField;
            }
            set {
                this.preserveOriginalAssertionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreserveOriginalAssertionSpecified {
            get {
                return this.preserveOriginalAssertionFieldSpecified;
            }
            set {
                this.preserveOriginalAssertionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public UserJourneyAuthorization Authorization {
            get {
                return this.authorizationField;
            }
            set {
                this.authorizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public OrchestrationStep[] OrchestrationSteps {
            get {
                return this.orchestrationStepsField;
            }
            set {
                this.orchestrationStepsField = value;
            }
        }
        
        /// <remarks/>
        public UserJourneyClientDefinition ClientDefinition {
            get {
                return this.clientDefinitionField;
            }
            set {
                this.clientDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Key", IsNullable=false)]
        public CryptographicKeysKey[] CryptographicKeys {
            get {
                return this.cryptographicKeysField;
            }
            set {
                this.cryptographicKeysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonInteractive {
            get {
                return this.nonInteractiveField;
            }
            set {
                this.nonInteractiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonInteractiveSpecified {
            get {
                return this.nonInteractiveFieldSpecified;
            }
            set {
                this.nonInteractiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultCpimIssuerTechnicalProfileReferenceId {
            get {
                return this.defaultCpimIssuerTechnicalProfileReferenceIdField;
            }
            set {
                this.defaultCpimIssuerTechnicalProfileReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class UserJourneyAuthorization {
        
        private UserJourneyAuthorizationAuthorizationTechnicalProfile[] authorizationTechnicalProfilesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AuthorizationTechnicalProfile", IsNullable=false)]
        public UserJourneyAuthorizationAuthorizationTechnicalProfile[] AuthorizationTechnicalProfiles {
            get {
                return this.authorizationTechnicalProfilesField;
            }
            set {
                this.authorizationTechnicalProfilesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class UserJourneyAuthorizationAuthorizationTechnicalProfile {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class UserJourneyClientDefinition {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SubJourney {
        
        private OrchestrationStep[] orchestrationStepsField;
        
        private string idField;
        
        private SubJourneyTYPE typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public OrchestrationStep[] OrchestrationSteps {
            get {
                return this.orchestrationStepsField;
            }
            set {
                this.orchestrationStepsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SubJourneyTYPE Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum SubJourneyTYPE {
        
        /// <remarks/>
        Transfer,
        
        /// <remarks/>
        Call,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Endpoint {
        
        private string idField;
        
        private string userJourneyReferenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserJourneyReferenceId {
            get {
                return this.userJourneyReferenceIdField;
            }
            set {
                this.userJourneyReferenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Inheritance {
        
        private object itemField;
        
        private string derivingPoliciesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConstraintHandler", typeof(ConstraintHandler))]
        [System.Xml.Serialization.XmlElementAttribute("Tenants", typeof(TenantListType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DerivingPolicies {
            get {
                return this.derivingPoliciesField;
            }
            set {
                this.derivingPoliciesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ConstraintHandler {
        
        private string idField;
        
        private string handlerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Handler {
            get {
                return this.handlerField;
            }
            set {
                this.handlerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class RerouteRules {
        
        private RerouteRule[] rerouteRuleField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RerouteRule")]
        public RerouteRule[] RerouteRule {
            get {
                return this.rerouteRuleField;
            }
            set {
                this.rerouteRuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class RerouteRule {
        
        private string policyIdField;
        
        private int weightField;
        
        private bool weightFieldSpecified;
        
        private string matchField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyId {
            get {
                return this.policyIdField;
            }
            set {
                this.policyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeightSpecified {
            get {
                return this.weightFieldSpecified;
            }
            set {
                this.weightFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Match {
            get {
                return this.matchField;
            }
            set {
                this.matchField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class BuildingBlocks {
        
        private ClaimType[] claimsSchemaField;
        
        private Predicate[] predicatesField;
        
        private InputValidation[] inputValidationsField;
        
        private PredicateValidation[] predicateValidationsField;
        
        private ClaimsTransformation[] claimsTransformationsField;
        
        private ClientDefinition[] clientDefinitionsField;
        
        private ContentDefinition[] contentDefinitionsField;
        
        private BuildingBlocksLocalization localizationField;
        
        private DisplayControl[] displayControlsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ClaimType[] ClaimsSchema {
            get {
                return this.claimsSchemaField;
            }
            set {
                this.claimsSchemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Predicate[] Predicates {
            get {
                return this.predicatesField;
            }
            set {
                this.predicatesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public InputValidation[] InputValidations {
            get {
                return this.inputValidationsField;
            }
            set {
                this.inputValidationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PredicateValidation[] PredicateValidations {
            get {
                return this.predicateValidationsField;
            }
            set {
                this.predicateValidationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ClaimsTransformation[] ClaimsTransformations {
            get {
                return this.claimsTransformationsField;
            }
            set {
                this.claimsTransformationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ClientDefinition[] ClientDefinitions {
            get {
                return this.clientDefinitionsField;
            }
            set {
                this.clientDefinitionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ContentDefinition[] ContentDefinitions {
            get {
                return this.contentDefinitionsField;
            }
            set {
                this.contentDefinitionsField = value;
            }
        }
        
        /// <remarks/>
        public BuildingBlocksLocalization Localization {
            get {
                return this.localizationField;
            }
            set {
                this.localizationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public DisplayControl[] DisplayControls {
            get {
                return this.displayControlsField;
            }
            set {
                this.displayControlsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class BuildingBlocksLocalization {
        
        private SupportedLanguages supportedLanguagesField;
        
        private LocalizedResources[] localizedResourcesField;
        
        private bool enabledField;
        
        private bool enabledFieldSpecified;
        
        /// <remarks/>
        public SupportedLanguages SupportedLanguages {
            get {
                return this.supportedLanguagesField;
            }
            set {
                this.supportedLanguagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocalizedResources")]
        public LocalizedResources[] LocalizedResources {
            get {
                return this.localizedResourcesField;
            }
            set {
                this.localizedResourcesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnabledSpecified {
            get {
                return this.enabledFieldSpecified;
            }
            set {
                this.enabledFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SupportedLanguages {
        
        private string[] supportedLanguageField;
        
        private string defaultLanguageField;
        
        private string policyLanguageField;
        
        private MergeBehavior mergeBehaviorField;
        
        private bool mergeBehaviorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedLanguage")]
        public string[] SupportedLanguage {
            get {
                return this.supportedLanguageField;
            }
            set {
                this.supportedLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultLanguage {
            get {
                return this.defaultLanguageField;
            }
            set {
                this.defaultLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyLanguage {
            get {
                return this.policyLanguageField;
            }
            set {
                this.policyLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MergeBehavior MergeBehavior {
            get {
                return this.mergeBehaviorField;
            }
            set {
                this.mergeBehaviorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MergeBehaviorSpecified {
            get {
                return this.mergeBehaviorFieldSpecified;
            }
            set {
                this.mergeBehaviorFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class LocalizedResources {
        
        private LocalizedCollection[] localizedCollectionsField;
        
        private LocalizedString[] localizedStringsField;
        
        private string cultureField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LocalizedCollection[] LocalizedCollections {
            get {
                return this.localizedCollectionsField;
            }
            set {
                this.localizedCollectionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LocalizedString[] LocalizedStrings {
            get {
                return this.localizedStringsField;
            }
            set {
                this.localizedStringsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Culture {
            get {
                return this.cultureField;
            }
            set {
                this.cultureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class JourneyFraming {
        
        private bool enabledField;
        
        private string sourcesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sources {
            get {
                return this.sourcesField;
            }
            set {
                this.sourcesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class JourneyOnError {
        
        private JourneyOnErrorModeType modeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public JourneyOnErrorModeType Mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum JourneyOnErrorModeType {
        
        /// <remarks/>
        ReturnToRequestor,
        
        /// <remarks/>
        DisplayInService,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class SingleSignOn {
        
        private UserJourneyBehaviorScopeType scopeField;
        
        private int keepAliveInDaysField;
        
        private bool keepAliveInDaysFieldSpecified;
        
        private bool enforceIdTokenHintOnLogoutField;
        
        private bool enforceIdTokenHintOnLogoutFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UserJourneyBehaviorScopeType Scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int KeepAliveInDays {
            get {
                return this.keepAliveInDaysField;
            }
            set {
                this.keepAliveInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeepAliveInDaysSpecified {
            get {
                return this.keepAliveInDaysFieldSpecified;
            }
            set {
                this.keepAliveInDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EnforceIdTokenHintOnLogout {
            get {
                return this.enforceIdTokenHintOnLogoutField;
            }
            set {
                this.enforceIdTokenHintOnLogoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnforceIdTokenHintOnLogoutSpecified {
            get {
                return this.enforceIdTokenHintOnLogoutFieldSpecified;
            }
            set {
                this.enforceIdTokenHintOnLogoutFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum UserJourneyBehaviorScopeType {
        
        /// <remarks/>
        Suppressed,
        
        /// <remarks/>
        TrustFramework,
        
        /// <remarks/>
        Tenant,
        
        /// <remarks/>
        Application,
        
        /// <remarks/>
        Policy,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class AzureApplicationInsights {
        
        private string instrumentationKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InstrumentationKey {
            get {
                return this.instrumentationKeyField;
            }
            set {
                this.instrumentationKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class JourneyInsights {
        
        private string instrumentationKeyField;
        
        private TelemetryEngineType telemetryEngineField;
        
        private bool developerModeField;
        
        private bool developerModeFieldSpecified;
        
        private bool clientEnabledField;
        
        private bool clientEnabledFieldSpecified;
        
        private bool serverEnabledField;
        
        private bool serverEnabledFieldSpecified;
        
        private string telemetryVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InstrumentationKey {
            get {
                return this.instrumentationKeyField;
            }
            set {
                this.instrumentationKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TelemetryEngineType TelemetryEngine {
            get {
                return this.telemetryEngineField;
            }
            set {
                this.telemetryEngineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DeveloperMode {
            get {
                return this.developerModeField;
            }
            set {
                this.developerModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeveloperModeSpecified {
            get {
                return this.developerModeFieldSpecified;
            }
            set {
                this.developerModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ClientEnabled {
            get {
                return this.clientEnabledField;
            }
            set {
                this.clientEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClientEnabledSpecified {
            get {
                return this.clientEnabledFieldSpecified;
            }
            set {
                this.clientEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ServerEnabled {
            get {
                return this.serverEnabledField;
            }
            set {
                this.serverEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServerEnabledSpecified {
            get {
                return this.serverEnabledFieldSpecified;
            }
            set {
                this.serverEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TelemetryVersion {
            get {
                return this.telemetryVersionField;
            }
            set {
                this.telemetryVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum TelemetryEngineType {
        
        /// <remarks/>
        ApplicationInsights,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ContentDefinitionParameters {
        
        private ContentDefinitionParameter[] parameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ContentDefinitionParameter[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ContentDefinitionParameter {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Preconditions {
        
        private Precondition[] preconditionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Precondition")]
        public Precondition[] Precondition {
            get {
                return this.preconditionField;
            }
            set {
                this.preconditionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class Parameters {
        
        private Parameter[] parameterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public Parameter[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PredicateGroups {
        
        private PredicateGroup[] predicateGroupField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PredicateGroup")]
        public PredicateGroup[] PredicateGroup {
            get {
                return this.predicateGroupField;
            }
            set {
                this.predicateGroupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class JourneyList {
        
        private Candidate[] candidateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Candidate")]
        public Candidate[] Candidate {
            get {
                return this.candidateField;
            }
            set {
                this.candidateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class InputTokenSources {
        
        private InputTokenSourcesTechnicalProfile[] technicalProfileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalProfile")]
        public InputTokenSourcesTechnicalProfile[] TechnicalProfile {
            get {
                return this.technicalProfileField;
            }
            set {
                this.technicalProfileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class CryptographicKeys {
        
        private CryptographicKeysKey[] keyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Key")]
        public CryptographicKeysKey[] Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class metadataTYPE {
        
        private metadataItemTYPE[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public metadataItemTYPE[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ItemGroup {
        
        private Item[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public Item[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class PolicyIdPatternType {
        
        private PatternTYPE typeField;
        
        private string patternField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PatternTYPE Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum PatternTYPE {
        
        /// <remarks/>
        Prefix,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum ScriptExecutionType {
        
        /// <remarks/>
        Disallow,
        
        /// <remarks/>
        Allow,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum CryptographicKeyType {
        
        /// <remarks/>
        UProveKey,
        
        /// <remarks/>
        X509Certificate,
        
        /// <remarks/>
        Secret,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum DeploymentModeType {
        
        /// <remarks/>
        Development,
        
        /// <remarks/>
        Production,
        
        /// <remarks/>
        Debugging,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum SessionExpiryTypeTYPE {
        
        /// <remarks/>
        Rolling,
        
        /// <remarks/>
        Absolute,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum DerivingPoliciesType {
        
        /// <remarks/>
        All,
        
        /// <remarks/>
        SameTenant,
        
        /// <remarks/>
        AllowList,
        
        /// <remarks/>
        DenyList,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TrustFrameworkPolicy {
        
        private BasePolicy basePolicyField;
        
        private TrustFrameworkPolicyPolicyConstraints policyConstraintsField;
        
        private Contact[] contactsField;
        
        private DocumentReference[] documentReferencesField;
        
        private BuildingBlocks buildingBlocksField;
        
        private ClaimsProvider[] claimsProvidersField;
        
        private UserJourney[] userJourneysField;
        
        private SubJourney[] subJourneysField;
        
        private TrustFrameworkPolicyRelyingParty relyingPartyField;
        
        private string policySchemaVersionField;
        
        private string tenantIdField;
        
        private string tenantObjectIdField;
        
        private string policyIdField;
        
        private string publicPolicyUriField;
        
        private string stateTableNameField;
        
        private DeploymentModeType deploymentModeField;
        
        private bool deploymentModeFieldSpecified;
        
        private string userJourneyRecorderEndpointField;
        
        /// <remarks/>
        public BasePolicy BasePolicy {
            get {
                return this.basePolicyField;
            }
            set {
                this.basePolicyField = value;
            }
        }
        
        /// <remarks/>
        public TrustFrameworkPolicyPolicyConstraints PolicyConstraints {
            get {
                return this.policyConstraintsField;
            }
            set {
                this.policyConstraintsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Contact[] Contacts {
            get {
                return this.contactsField;
            }
            set {
                this.contactsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public DocumentReference[] DocumentReferences {
            get {
                return this.documentReferencesField;
            }
            set {
                this.documentReferencesField = value;
            }
        }
        
        /// <remarks/>
        public BuildingBlocks BuildingBlocks {
            get {
                return this.buildingBlocksField;
            }
            set {
                this.buildingBlocksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ClaimsProvider[] ClaimsProviders {
            get {
                return this.claimsProvidersField;
            }
            set {
                this.claimsProvidersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public UserJourney[] UserJourneys {
            get {
                return this.userJourneysField;
            }
            set {
                this.userJourneysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public SubJourney[] SubJourneys {
            get {
                return this.subJourneysField;
            }
            set {
                this.subJourneysField = value;
            }
        }
        
        /// <remarks/>
        public TrustFrameworkPolicyRelyingParty RelyingParty {
            get {
                return this.relyingPartyField;
            }
            set {
                this.relyingPartyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicySchemaVersion {
            get {
                return this.policySchemaVersionField;
            }
            set {
                this.policySchemaVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TenantId {
            get {
                return this.tenantIdField;
            }
            set {
                this.tenantIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TenantObjectId {
            get {
                return this.tenantObjectIdField;
            }
            set {
                this.tenantObjectIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolicyId {
            get {
                return this.policyIdField;
            }
            set {
                this.policyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string PublicPolicyUri {
            get {
                return this.publicPolicyUriField;
            }
            set {
                this.publicPolicyUriField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateTableName {
            get {
                return this.stateTableNameField;
            }
            set {
                this.stateTableNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DeploymentModeType DeploymentMode {
            get {
                return this.deploymentModeField;
            }
            set {
                this.deploymentModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeploymentModeSpecified {
            get {
                return this.deploymentModeFieldSpecified;
            }
            set {
                this.deploymentModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserJourneyRecorderEndpoint {
            get {
                return this.userJourneyRecorderEndpointField;
            }
            set {
                this.userJourneyRecorderEndpointField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TrustFrameworkPolicyPolicyConstraints {
        
        private Inheritance inheritanceField;
        
        private RerouteRules rerouteRulesField;
        
        /// <remarks/>
        public Inheritance Inheritance {
            get {
                return this.inheritanceField;
            }
            set {
                this.inheritanceField = value;
            }
        }
        
        /// <remarks/>
        public RerouteRules RerouteRules {
            get {
                return this.rerouteRulesField;
            }
            set {
                this.rerouteRulesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TrustFrameworkPolicyRelyingParty {
        
        private TrustFrameworkPolicyRelyingPartyDefaultUserJourney defaultUserJourneyField;
        
        private Endpoint[] endpointsField;
        
        private TrustFrameworkPolicyRelyingPartyUserJourneyBehaviors userJourneyBehaviorsField;
        
        private TechnicalProfile[] technicalProfileField;
        
        /// <remarks/>
        public TrustFrameworkPolicyRelyingPartyDefaultUserJourney DefaultUserJourney {
            get {
                return this.defaultUserJourneyField;
            }
            set {
                this.defaultUserJourneyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Endpoint[] Endpoints {
            get {
                return this.endpointsField;
            }
            set {
                this.endpointsField = value;
            }
        }
        
        /// <remarks/>
        public TrustFrameworkPolicyRelyingPartyUserJourneyBehaviors UserJourneyBehaviors {
            get {
                return this.userJourneyBehaviorsField;
            }
            set {
                this.userJourneyBehaviorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalProfile")]
        public TechnicalProfile[] TechnicalProfile {
            get {
                return this.technicalProfileField;
            }
            set {
                this.technicalProfileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TrustFrameworkPolicyRelyingPartyDefaultUserJourney {
        
        private string referenceIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReferenceId {
            get {
                return this.referenceIdField;
            }
            set {
                this.referenceIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class TrustFrameworkPolicyRelyingPartyUserJourneyBehaviors {
        
        private SingleSignOn singleSignOnField;
        
        private SessionExpiryTypeTYPE sessionExpiryTypeField;
        
        private bool sessionExpiryTypeFieldSpecified;
        
        private int sessionExpiryInSecondsField;
        
        private bool sessionExpiryInSecondsFieldSpecified;
        
        private AzureApplicationInsights azureApplicationInsightsField;
        
        private JourneyInsights journeyInsightsField;
        
        private ContentDefinitionParameter[] contentDefinitionParametersField;
        
        private JourneyFraming journeyFramingField;
        
        private ScriptExecutionType scriptExecutionField;
        
        private bool scriptExecutionFieldSpecified;
        
        private JourneyOnError onErrorField;
        
        /// <remarks/>
        public SingleSignOn SingleSignOn {
            get {
                return this.singleSignOnField;
            }
            set {
                this.singleSignOnField = value;
            }
        }
        
        /// <remarks/>
        public SessionExpiryTypeTYPE SessionExpiryType {
            get {
                return this.sessionExpiryTypeField;
            }
            set {
                this.sessionExpiryTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SessionExpiryTypeSpecified {
            get {
                return this.sessionExpiryTypeFieldSpecified;
            }
            set {
                this.sessionExpiryTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int SessionExpiryInSeconds {
            get {
                return this.sessionExpiryInSecondsField;
            }
            set {
                this.sessionExpiryInSecondsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SessionExpiryInSecondsSpecified {
            get {
                return this.sessionExpiryInSecondsFieldSpecified;
            }
            set {
                this.sessionExpiryInSecondsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public AzureApplicationInsights AzureApplicationInsights {
            get {
                return this.azureApplicationInsightsField;
            }
            set {
                this.azureApplicationInsightsField = value;
            }
        }
        
        /// <remarks/>
        public JourneyInsights JourneyInsights {
            get {
                return this.journeyInsightsField;
            }
            set {
                this.journeyInsightsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable=false)]
        public ContentDefinitionParameter[] ContentDefinitionParameters {
            get {
                return this.contentDefinitionParametersField;
            }
            set {
                this.contentDefinitionParametersField = value;
            }
        }
        
        /// <remarks/>
        public JourneyFraming JourneyFraming {
            get {
                return this.journeyFramingField;
            }
            set {
                this.journeyFramingField = value;
            }
        }
        
        /// <remarks/>
        public ScriptExecutionType ScriptExecution {
            get {
                return this.scriptExecutionField;
            }
            set {
                this.scriptExecutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScriptExecutionSpecified {
            get {
                return this.scriptExecutionFieldSpecified;
            }
            set {
                this.scriptExecutionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public JourneyOnError OnError {
            get {
                return this.onErrorField;
            }
            set {
                this.onErrorField = value;
            }
        }
    }
}