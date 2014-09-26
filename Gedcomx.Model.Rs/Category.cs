// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Atom
{

    /// <remarks>
    ///  conveys information about a category associated with an entry or feed.
    /// </remarks>
    /// <summary>
    ///  conveys information about a category associated with an entry or feed.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Category")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Category")]
    public sealed partial class Category : Gx.Atom.CommonAttributes
    {

        private string _scheme;
        private string _term;
        private string _label;
        /// <summary>
        ///  identifies a categorization scheme
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "scheme")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "scheme")]
        [Newtonsoft.Json.JsonProperty("scheme")]
        public string Scheme
        {
            get
            {
                return this._scheme;
            }
            set
            {
                this._scheme = value;
            }
        }
        /// <summary>
        ///  identifies the category to which the entry or feed belongs
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "term")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "term")]
        [Newtonsoft.Json.JsonProperty("term")]
        public string Term
        {
            get
            {
                return this._term;
            }
            set
            {
                this._term = value;
            }
        }
        /// <summary>
        ///  a human-readable label for display in end-user applications
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "label")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "label")]
        [Newtonsoft.Json.JsonProperty("label")]
        public string Label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }
    }
}
