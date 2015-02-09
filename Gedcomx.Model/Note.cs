using Gedcomx.Model.Rt;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Common
{

    /// <remarks>
    ///  A note about a genealogical resource (e.g. conclusion or source).
    /// </remarks>
    /// <summary>
    ///  A note about a genealogical resource (e.g. conclusion or source).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Note")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Note")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "note")]
    public partial class Note : Gx.Links.HypermediaEnabledData, IAttributable
    {

        private string _lang;
        private string _subject;
        private string _text;
        private Gx.Common.Attribution _attribution;
        /// <summary>
        ///  The language of the note.
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
        ///  The subject of the note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "subject", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "subject")]
        [Newtonsoft.Json.JsonProperty("subject")]
        public string Subject
        {
            get
            {
                return this._subject;
            }
            set
            {
                this._subject = value;
            }
        }
        /// <summary>
        ///  The text of the note.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "text", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "text")]
        [Newtonsoft.Json.JsonProperty("text")]
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        /// <summary>
        ///  Attribution metadata for a note.
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
        public void Accept(IGedcomxModelVisitor visitor)
        {
            visitor.VisitNote(this);
        }

        /**
         * Build up this note with a locale.
         *
         * @param lang The locale.
         */
        public Note SetLang(String lang)
        {
            this.Lang = lang;
            return this;
        }

        /**
         * Build up this note with a subject.
         *
         * @param text The subject.
         * @return this.
         */
        public Note SetSubject(String text)
        {
            this.Subject = text;
            return this;
        }

        /**
         * Build up this note with some text.
         *
         * @param text The text.
         */
        public Note SetText(String text)
        {
            this.Text = text;
            return this;
        }

        /**
         * Build up this note with attribution.
         *
         * @param attribution The attribution.
         * @return this.
         */
        public Note SetAttribution(Attribution attribution)
        {
            this.Attribution = attribution;
            return this;
        }
    }
}
