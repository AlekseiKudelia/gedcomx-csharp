// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Fs.Tree
{

    /// <remarks>
    ///  
    /// </remarks>
    /// <summary>
    ///  
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "DiscussionReference")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "DiscussionReference")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://familysearch.org/v1/", ElementName = "discussion-reference")]
    public sealed partial class DiscussionReference : Gx.Links.HypermediaEnabledData
    {

        private string _resourceId;
        private string _resource;
        private Gx.Common.Attribution _attribution;
        /// <summary>
        ///  The id of the discussion being referenced.
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
        /// <summary>
        ///  The attribution metadata for this discussion reference.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "attribution", Namespace = "http://familysearch.org/v1/")]
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
    }
}
