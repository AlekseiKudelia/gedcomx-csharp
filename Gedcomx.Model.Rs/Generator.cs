// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Atom
{

    /// <remarks>
    ///  identifies the agent used to generate a feed, for debugging and other purposes.
    /// </remarks>
    /// <summary>
    ///  identifies the agent used to generate a feed, for debugging and other purposes.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Generator")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Generator")]
    public sealed partial class Generator
    {

        private string _base;
        private string _uri;
        private string _lang;
        private string _version;
        private string _value;
        /// <summary>
        ///  The base.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "base")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "base")]
        [Newtonsoft.Json.JsonProperty("base")]
        public string Base
        {
            get
            {
                return this._base;
            }
            set
            {
                this._base = value;
            }
        }
        /// <summary>
        ///  link to a representation that is relevant to the generating agent.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "uri")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "uri")]
        [Newtonsoft.Json.JsonProperty("uri")]
        public string Uri
        {
            get
            {
                return this._uri;
            }
            set
            {
                this._uri = value;
            }
        }
        /// <summary>
        ///  The language.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace")]
        [Newtonsoft.Json.JsonProperty("lang")]
        public string Lang
        {
            get
            {
                return this._lang;
            }
            set
            {
                this._lang = value;
            }
        }
        /// <summary>
        ///  the version of the generating agent
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "version")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "version")]
        [Newtonsoft.Json.JsonProperty("version")]
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>
        ///  human-readable name for the generating agent
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        [Newtonsoft.Json.JsonProperty("value")]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}
