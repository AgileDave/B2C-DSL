using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum UserInputType
    {

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
}