// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Common
{

    /// <remarks>
    ///  A generic reference to a resource.
    /// </remarks>
    /// <summary>
    ///  A generic reference to a resource.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "ResourceReference")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "ResourceReference")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "resourceReference")]
    public sealed partial class ResourceReference
    {
        public ResourceReference()
        {
        }

        public ResourceReference(string resource)
            : this()
        {
            Resource = resource;
        }

        private string _resourceId;
        private string _resource;
        /// <summary>
        ///  The resource id of the resource being referenced.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "resourceId")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "resourceId")]
        [Newtonsoft.Json.JsonProperty("resourceId")]
        public string ResourceId
        {
            get
            {
                return this._resourceId;
            }
            set
            {
                this._resourceId = value;
            }
        }
        /// <summary>
        ///  The URI to the resource.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "resource")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "resource")]
        [Newtonsoft.Json.JsonProperty("resource")]
        public string Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
            }
        }
    }
}
