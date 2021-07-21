using System.Xml.Serialization;

namespace agileways.b2c.builder.models.claim
{
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum StatementType
    {

        /// <remarks/>
        Attribute,

        /// <remarks/>
        Authentication,

        /// <remarks/>
        Subject,
    }
}