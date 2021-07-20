namespace agileways.b2c.builder.models.predicate
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/online/cpim/schemas/2013/06")]
    public class PredicateReferences
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PredicateReference")]
        public PredicateReference[] PredicateReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HelpText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MatchAtLeast { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Reject { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RejectSpecified { get; set; }
    }

}