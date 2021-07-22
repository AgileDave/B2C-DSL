using System.ComponentModel;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.journey
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ClaimsProviderSelections
    {
        /// <remarks/>
        [XmlElement("ClaimsProviderSelection")]
        public ClaimsProviderSelection[] ClaimsProviderSelection { get; set; }

        /// <remarks/>
        [XmlAttribute]
        [DefaultValue(ClaimsProviderSelectionDisplayOption.DoNotShowSingleProvider)]
        public ClaimsProviderSelectionDisplayOption DisplayOption { get; set; }

    }
}