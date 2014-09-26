using Gedcomx.Model.Rt;
using Newtonsoft.Json;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Source
{

    /// <remarks>
    ///  An attributable reference to a description of a source.
    /// </remarks>
    /// <summary>
    ///  An attributable reference to a description of a source.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "SourceReference")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "SourceReference")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "sourceReference")]
    public partial class SourceReference : Gx.Links.HypermediaEnabledData
    {

        private string _descriptionRef;
        private Gx.Common.Attribution _attribution;
        private System.Collections.Generic.List<Gx.Common.Qualifier> _qualifiers;
        private System.Collections.Generic.List<Gx.Source.Tag> _tags;
        /// <summary>
        ///  A reference to a description of the source being referenced.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "description")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "description")]
        [JsonProperty("description")]
        public string DescriptionRef
        {
            get
            {
                return this._descriptionRef;
            }
            set
            {
                this._descriptionRef = value;
            }
        }
        /// <summary>
        ///  The attribution metadata for this source reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attribution", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "attribution")]
        [Newtonsoft.Json.JsonProperty("attribution")]
        public Gx.Common.Attribution Attribution
        {
            get
            {
                return this._attribution;
            }
            set
            {
                this._attribution = value;
            }
        }
        /// <summary>
        ///  The qualifiers associated with this source reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "qualifier", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "qualifier")]
        [Newtonsoft.Json.JsonProperty("qualifiers")]
        public System.Collections.Generic.List<Gx.Common.Qualifier> Qualifiers
        {
            get
            {
                return this._qualifiers;
            }
            set
            {
                this._qualifiers = value;
            }
        }
        /// <summary>
        ///  The tags associated with this source reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "tags", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "tags")]
        [Newtonsoft.Json.JsonProperty("tags")]
        public System.Collections.Generic.List<Gx.Source.Tag> Tags
        {
            get
            {
                return this._tags;
            }
            set
            {
                this._tags = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitSourceReference(this);
        }
    }
}
