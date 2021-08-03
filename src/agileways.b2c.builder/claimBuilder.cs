
using System.Collections.Generic;
using agileways.b2c.builder.models.claim;
using agileways.b2c.builder.models.common;

namespace agileways.b2c.builder.extensions
{
    public static class ClaimBuilder
    {

        public static ClaimType AsString { get => new ClaimType { DataType = DataType.@string, UserInputTypeSpecified = false }; }
        public static ClaimType AsAltSecurityId { get => new ClaimType { DataType = DataType.alternativeSecurityIdCollection, UserInputTypeSpecified = false }; }
        public static ClaimType AsBool { get => new ClaimType { DataType = DataType.boolean, UserInputTypeSpecified = false }; }
        public static ClaimType AsDate { get => new ClaimType { DataType = DataType.date, UserInputTypeSpecified = false }; }
        public static ClaimType AsDateTime { get => new ClaimType { DataType = DataType.dateTime, UserInputTypeSpecified = false }; }
        public static ClaimType AsDuration { get => new ClaimType { DataType = DataType.duration, UserInputTypeSpecified = false }; }
        public static ClaimType AsInt { get => new ClaimType { DataType = DataType.@int, UserInputTypeSpecified = false }; }
        public static ClaimType AsLong { get => new ClaimType { DataType = DataType.@long, UserInputTypeSpecified = false }; }
        public static ClaimType AsObjectId { get => new ClaimType { DataType = DataType.objectIdentity, UserInputTypeSpecified = false }; }
        public static ClaimType AsObjIdCollection { get => new ClaimType { DataType = DataType.objectIdentityCollection, UserInputTypeSpecified = false }; }
        public static ClaimType AsPhoneNum { get => new ClaimType { DataType = DataType.phoneNumber, UserInputTypeSpecified = false }; }
        public static ClaimType AsStringCollection { get => new ClaimType { DataType = DataType.stringCollection, UserInputTypeSpecified = false }; }
        public static ClaimType AsUserId { get => new ClaimType { DataType = DataType.userIdentity, UserInputTypeSpecified = false }; }
        public static ClaimType AsUserIdCollection { get => new ClaimType { DataType = DataType.userIdentityCollection, UserInputTypeSpecified = false }; }

        public static ClaimType WithId(this ClaimType claim, string id)
        {
            claim.Id = id;
            return claim;
        }

        public static ClaimType WithDisplayName(this ClaimType claim, string displayName)
        {
            claim.DisplayName = displayName;
            return claim;
        }

        public static ClaimType WithUserHelpText(this ClaimType claim, string helpText)
        {
            claim.UserHelpText = helpText;
            return claim;
        }

        public static ClaimType AddPartnerClaimType(this ClaimType claim, PartnerClaimTypesProtocol p)
        {
            if (claim.DefaultPartnerClaimTypes == null)
            {
                claim.DefaultPartnerClaimTypes = new List<PartnerClaimTypesProtocol>();
            }
            claim.DefaultPartnerClaimTypes.Add(p);
            return claim;
        }

        public static ClaimType UseMask(this ClaimType claim, claimMask mask)
        {
            claim.Mask = mask;
            return claim;
        }

        public static ClaimType AddAdminHelpText(this ClaimType claim, string adminHelpText)
        {
            claim.AdminHelpText = adminHelpText;
            return claim;
        }

        public static ClaimType DisplayClaimAsTextBox(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.TextBox;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsButton(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.Button;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsMultiSelectCheckbox(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.CheckboxMultiSelect;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsDateTime(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.DateTimeDropdown;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsDropdown(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.DropdownSingleSelect;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsEmail(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.EmailBox;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsParagraph(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.Paragraph;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsRadioSelect(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.RadioSingleSelect;
            claim.UserInputTypeSpecified = true;
            return claim;
        }
        public static ClaimType DisplayClaimAsReadOnly(this ClaimType claim)
        {
            claim.UserInputType = UserInputType.Readonly;
            claim.UserInputTypeSpecified = true;
            return claim;
        }

        public static ClaimType RestrictWith(this ClaimType claim, Restriction restrict)
        {
            claim.Restriction = restrict;
            return claim;
        }

        public static ClaimType InputValidatedBy(this ClaimType claim, InputValidationReference input)
        {
            claim.InputValidationReference = input;
            return claim;
        }
        public static ClaimType UsePredicate(this ClaimType claim, PredicateValidationReference pred)
        {
            claim.PredicateValidationReference = pred;
            return claim;
        }
        public static ClaimType AsStatementType(this ClaimType claim, StatementType stmt)
        {
            claim.StatementType = stmt;
            return claim;
        }
    }
}