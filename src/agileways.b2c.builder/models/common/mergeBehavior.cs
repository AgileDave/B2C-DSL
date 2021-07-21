using System.Xml.Serialization;

namespace agileways.b2c.builder.models.common
{
    /// <remarks/>
    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public enum MergeBehavior
    {

        /// <remarks/>
        Append,

        /// <remarks/>
        Prepend,

        /// <remarks/>
        ReplaceAll,
    }
}