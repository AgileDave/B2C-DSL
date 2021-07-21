using System.Xml.Serialization;

namespace agileways.b2c.builder.models.rp
{

    [XmlType(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public partial class ContentDefinitionParameter
    {
        /// <remarks/>
        [XmlAttribute]
        public string Name { get; set; }

        /// <remarks/>
        [XmlText]
        public string Value { get; set; }
    }

}