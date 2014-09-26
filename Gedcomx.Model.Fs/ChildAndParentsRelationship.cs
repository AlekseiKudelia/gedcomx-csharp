using Gx.Common;
using Gx.Conclusion;
using Gx.Fs.Rt;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace Gx.Fs.Tree
{

    /// <remarks>
    ///  The FamilySearch-proprietary model for a relationship between a child and a pair of parents.
    /// </remarks>
    /// <summary>
    ///  The FamilySearch-proprietary model for a relationship between a child and a pair of parents.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "ChildAndParentsRelationship")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://familysearch.org/v1/", TypeName = "ChildAndParentsRelationship")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://familysearch.org/v1/", ElementName = "childAndParentsRelationship")]
    public partial class ChildAndParentsRelationship : Gx.Conclusion.Subject
    {

        private Gx.Common.ResourceReference _father;
        private Gx.Common.ResourceReference _mother;
        private Gx.Common.ResourceReference _child;
        private System.Collections.Generic.List<Gx.Conclusion.Fact> _fatherFacts;
        private System.Collections.Generic.List<Gx.Conclusion.Fact> _motherFacts;
        /// <summary>
        ///  The father of the child.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "father", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "father")]
        [Newtonsoft.Json.JsonProperty("father")]
        public Gx.Common.ResourceReference Father
        {
            get
            {
                return this._father;
            }
            set
            {
                this._father = value;
            }
        }
        /// <summary>
        ///  The mother of the child.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "mother", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "mother")]
        [Newtonsoft.Json.JsonProperty("mother")]
        public Gx.Common.ResourceReference Mother
        {
            get
            {
                return this._mother;
            }
            set
            {
                this._mother = value;
            }
        }
        /// <summary>
        ///  child in the relationship.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "child", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "child")]
        [Newtonsoft.Json.JsonProperty("child")]
        public Gx.Common.ResourceReference Child
        {
            get
            {
                return this._child;
            }
            set
            {
                this._child = value;
            }
        }
        /// <summary>
        ///  The fact conclusions for the father.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "fatherFact", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "fatherFact")]
        [Newtonsoft.Json.JsonProperty("fatherFacts")]
        public System.Collections.Generic.List<Gx.Conclusion.Fact> FatherFacts
        {
            get
            {
                return this._fatherFacts;
            }
            set
            {
                this._fatherFacts = value;
            }
        }
        /// <summary>
        ///  The fact conclusions for the mother.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "motherFact", Namespace = "http://familysearch.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "motherFact")]
        [Newtonsoft.Json.JsonProperty("motherFacts")]
        public System.Collections.Generic.List<Gx.Conclusion.Fact> MotherFacts
        {
            get
            {
                return this._motherFacts;
            }
            set
            {
                this._motherFacts = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor to accept.
         */
        public void Accept(FamilySearchPlatformModelVisitor visitor)
        {
            visitor.VisitChildAndParentsRelationship(this);
        }

        protected override void Embed(ExtensibleData relationship)
        {
            ChildAndParentsRelationship value = relationship as ChildAndParentsRelationship;

            if (value != null)
            {
                if (value.MotherFacts != null)
                {
                    this.MotherFacts = this.MotherFacts == null ? new List<Fact>() : this.MotherFacts;
                    this.MotherFacts.AddRange(value.MotherFacts);
                }
                if (value.FatherFacts != null)
                {
                    this.FatherFacts = this.FatherFacts == null ? new List<Fact>() : this.FatherFacts;
                    this.FatherFacts.AddRange(value.FatherFacts);
                }
            }

            base.Embed(relationship);
        }

        internal void EmbedInt(ExtensibleData relationship)
        {
            this.Embed(relationship);
        }
    }
}
