using Gedcomx.Model.Rt;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Conclusion
{

    /// <remarks>
    ///  A gender conclusion.
    /// </remarks>
    /// <summary>
    ///  A gender conclusion.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Gender")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Gender")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "gender")]
    public partial class Gender : Gx.Conclusion.Conclusion
    {

        private string _type;
        private System.Collections.Generic.List<Gx.Records.Field> _fields;
        /// <summary>
        ///  The type of the gender.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "type")]
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

        /// <summary>
        ///  Convenience property for treating Type as an enum. See Gx.Types.GenderTypeQNameUtil for details on getter/setter functionality.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [Newtonsoft.Json.JsonIgnore]
        public Gx.Types.GenderType KnownType
        {
            get
            {
                return Gx.Types.GenderTypeQNameUtil.ConvertFromKnownQName(this._type);
            }
            set
            {
                this._type = Gx.Types.GenderTypeQNameUtil.ConvertToKnownQName(value);
            }
        }
        /// <summary>
        ///  The references to the record fields being used as evidence.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "field", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "field")]
        [Newtonsoft.Json.JsonProperty("fields")]
        public System.Collections.Generic.List<Gx.Records.Field> Fields
        {
            get
            {
                return this._fields;
            }
            set
            {
                this._fields = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitGender(this);
        }
    }
}
