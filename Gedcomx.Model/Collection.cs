using Gedcomx.Model.Rt;
using Gx.Common;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace Gx.Records
{

    /// <remarks>
    ///  A collection of genealogical resources.
    /// </remarks>
    /// <summary>
    ///  A collection of genealogical resources.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Collection")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Collection")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "collection")]
    public partial class Collection : Gx.Links.HypermediaEnabledData
    {

        private string _lang;
        private string _title;
        private int? _size;
        private bool _sizeSpecified;
        private System.Collections.Generic.List<Gx.Records.CollectionContent> _content;
        private Gx.Common.Attribution _attribution;
        /// <summary>
        ///  The language of this description of the collection
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
        ///  A title for the collection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "title", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "title")]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        /// <summary>
        ///  The size of the collection, in terms of the number of items in this collection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "size", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "size")]
        [Newtonsoft.Json.JsonProperty("size")]
        public int Size
        {
            get
            {
                return this._size.GetValueOrDefault();
            }
            set
            {
                this._size = value;
                this._sizeSpecified = true;
            }
        }

        /// <summary>
        ///  Property for the XML serializer indicating whether the "Size" property should be included in the output.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Newtonsoft.Json.JsonIgnore]
        public bool SizeSpecified
        {
            get
            {
                return this._sizeSpecified;
            }
            set
            {
                this._sizeSpecified = value;
            }
        }

        /// <summary>
        ///  Descriptions of the content of this collection.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "content", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "content")]
        [Newtonsoft.Json.JsonProperty("content")]
        public System.Collections.Generic.List<Gx.Records.CollectionContent> Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }
        /// <summary>
        ///  Attribution metadata for this collection.
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

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitCollection(this);
        }

        /**
         * Build out this collection with a lang.
         * @param lang The lang.
         * @return this.
         */
        public Collection SetLang(String lang)
        {
            Lang = lang;
            return this;
        }

        /**
         * Build out this collection with a title.
         * @param title the title.
         * @return this.
         */
        public Collection SetTitle(String title)
        {
            Title = title;
            return this;
        }

        /**
         * Build out this collection with content.
         * @param content The content.
         * @return this.
         */
        public Collection SetContent(CollectionContent content)
        {
            AddContent(content);
            return this;
        }

        /**
         * Build out this collection with attribution.
         * @param attribution The attribution.
         * @return this.
         */
        public Collection SetAttribution(Attribution attribution)
        {
            Attribution = attribution;
            return this;
        }

        /**
         * Build out this collection with size.
         *
         * @param size the size.
         * @return this.
         */
        public Collection SetSize(Int32 size)
        {
            Size = size;
            return this;
        }

        /**
         * Add a reference to the record content values being used as evidence.
         *
         * @param content The content to be added.
         */
        public void AddContent(CollectionContent content)
        {
            if (content != null)
            {
                if (this._content == null)
                {
                    this._content = new List<CollectionContent>();
                }
                this._content.Add(content);
            }
        }
    }
}
