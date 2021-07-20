using System.Xml.Serialization;

namespace agileways.b2c.builder.models.display
{
    /// <remarks/>
    [XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum UserInterfaceControlType
    {
        /// <remarks/>
        VerificationControl,

        /// <remarks/>
        QrCodeControl,
    }
}