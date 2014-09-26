// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Agent {

  /// <remarks>
  ///  An address.
  /// </remarks>
  /// <summary>
  ///  An address.
  /// </summary>
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gedcomx.org/v1/",TypeName="Address")]
  [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://gedcomx.org/v1/",TypeName="Address")]
  [Newtonsoft.Json.JsonObject("")]
  public partial class Address : Gx.Common.ExtensibleData {

    private string _city;
    private string _country;
    private string _postalCode;
    private string _stateOrProvince;
    private string _street;
    private string _street2;
    private string _street3;
    private string _street4;
    private string _street5;
    private string _street6;
    private string _value;
    /// <summary>
    ///  The city.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="city",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="city")]
    [Newtonsoft.Json.JsonProperty("city")]
    public string City {
      get {
        return this._city;
      }
      set {
        this._city = value;
      }
    }
    /// <summary>
    ///  The country.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="country",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="country")]
    [Newtonsoft.Json.JsonProperty("country")]
    public string Country
    {
      get {
        return this._country;
      }
      set {
        this._country = value;
      }
    }
    /// <summary>
    ///  The postal code.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="postalCode",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="postalCode")]
    [Newtonsoft.Json.JsonProperty("postalCode")]
    public string PostalCode
    {
      get {
        return this._postalCode;
      }
      set {
        this._postalCode = value;
      }
    }
    /// <summary>
    ///  The state or province.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="stateOrProvince",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="stateOrProvince")]
    [Newtonsoft.Json.JsonProperty("stateOrProvince")]
    public string StateOrProvince
    {
      get {
        return this._stateOrProvince;
      }
      set {
        this._stateOrProvince = value;
      }
    }
    /// <summary>
    ///  The street.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="street",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="street")]
    [Newtonsoft.Json.JsonProperty("street")]
    public string Street
    {
      get {
        return this._street;
      }
      set {
        this._street = value;
      }
    }
    /// <summary>
    ///  Additional street information.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="street2",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="street2")]
    [Newtonsoft.Json.JsonProperty("street2")]
    public string Street2
    {
      get {
        return this._street2;
      }
      set {
        this._street2 = value;
      }
    }
    /// <summary>
    ///  Additional street information.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="street3",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="street3")]
    [Newtonsoft.Json.JsonProperty("street3")]
    public string Street3
    {
      get {
        return this._street3;
      }
      set {
        this._street3 = value;
      }
    }
    /// <summary>
    ///  Additional street information.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="street4",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="street4")]
    [Newtonsoft.Json.JsonProperty("street4")]
    public string Street4
    {
      get {
        return this._street4;
      }
      set {
        this._street4 = value;
      }
    }
    /// <summary>
    ///  Additional street information.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="street5",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="street5")]
    [Newtonsoft.Json.JsonProperty("street5")]
    public string Street5
    {
      get {
        return this._street5;
      }
      set {
        this._street5 = value;
      }
    }
    /// <summary>
    ///  Additional street information.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="street6",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="street6")]
    [Newtonsoft.Json.JsonProperty("street6")]
    public string Street6
    {
      get {
        return this._street6;
      }
      set {
        this._street6 = value;
      }
    }
    /// <summary>
    ///  The value of the property.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(ElementName="value",Namespace="http://gedcomx.org/v1/")]
    [System.Xml.Serialization.SoapElementAttribute(ElementName="value")]
    [Newtonsoft.Json.JsonProperty("value")]
    public string Value
    {
      get {
        return this._value;
      }
      set {
        this._value = value;
      }
    }
  }
}  
