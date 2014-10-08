// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Conclusion
{

    /// <remarks>
    ///  A set of display properties for places for the convenience of quick display, such as for
    ///  a Web-based application. All display properties are provided in the default locale for the current
    ///  application context and are NOT considered canonical for the purposes of data exchange.
    /// </remarks>
    /// <summary>
    ///  A set of display properties for places for the convenience of quick display, such as for
    ///  a Web-based application. All display properties are provided in the default locale for the current
    ///  application context and are NOT considered canonical for the purposes of data exchange.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "PlaceDisplayProperties")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "PlaceDisplayProperties")]
    public partial class PlaceDisplayProperties : Gx.Common.ExtensibleData
    {

        private string _fullName;
        private string _name;
        private string _type;
        /// <summary>
        ///  The displayable full name of the place.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fullName", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "fullName")]
        [Newtonsoft.Json.JsonProperty("fullName")]
        public string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                this._fullName = value;
            }
        }
        /// <summary>
        ///  The displayable name of the place.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "name", Namespace = "http://gedcomx.org/v1/")]
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
        ///  The displayable type of the place.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "type", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        /**
         * Build up these properties with a name.
         * 
         * @param name The name.
         * @return this.
         */
        public PlaceDisplayProperties SetName(String name)
        {
            Name = name;
            return this;
        }

        /**
         * Build up these properties with a full name.
         * 
         * @param name The name.
         * @return this.
         */
        public PlaceDisplayProperties SetFullName(String name)
        {
            FullName = name;
            return this;
        }

        /**
         * Build up these properties with a type.
         *
         * @param type The type.
         * @return this.
         */
        public PlaceDisplayProperties SetType(String type)
        {
            Type = type;
            return this;
        }
    }
}
