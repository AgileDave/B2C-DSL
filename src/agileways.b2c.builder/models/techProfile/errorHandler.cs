using System.Collections.Generic;
using System.Xml.Serialization;

namespace agileways.b2c.builder.models.techProfile
{

    /// <remarks/>
    [XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ErrorHandler
    {
        /// <remarks/>
        public ErrorResponseFormat ErrorResponseFormat { get; set; }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ErrorResponseFormatSpecified { get; set; }

        /// <remarks/>
        public string ResponseMatch { get; set; }

        /// <remarks/>
        public ErrorHandlingAction Action { get; set; }

        /// <remarks/>
        [XmlElementAttribute("AdditionalRequestParameters")]
        public List<ErrorHandlerAdditionalRequestParameters> AdditionalRequestParameters { get; set; }
    }

}