// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Atom
{

    /// <remarks>
    ///  A Person construct is an element that describes a person, corporation, or similar entity
    /// </remarks>
    /// <summary>
    ///  A Person construct is an element that describes a person, corporation, or similar entity
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Person")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "Person")]
    public sealed partial class Person : Gx.Atom.ExtensibleElement
    {

        private string _name;
        private string _uri;
        private string _email;
        /// <summary>
        ///  a human-readable name for the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>
        ///  an IRI associated with the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "uri", Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "uri")]
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
        ///  an e-mail address associated with the person.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "email", Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "email")]
        [Newtonsoft.Json.JsonProperty("email")]
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
    }
}
