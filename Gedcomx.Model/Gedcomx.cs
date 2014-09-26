using Gedcomx.Model.Rt;
using Gx.Conclusion;
using Gx.Links;
using Gx.Records;
using Gx.Source;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace Gx
{

    /// <remarks>
    ///  &lt;p&gt;The GEDCOM X data formats define the serialization formats of the GEDCOM X conceptual model. The canonical documentation
    ///  is provided by the formal specification documents:&lt;/p&gt;
    ///  
    ///  &lt;ul&gt;
    ///  &lt;li&gt;&lt;a href=&quot;https://github.com/FamilySearch/gedcomx/blob/master/specifications/conceptual-model-specification.md&quot;&gt;The GEDCOM X Conceptual Model, Version 1.0&lt;/a&gt;&lt;/li&gt;
    ///  &lt;li&gt;&lt;a href=&quot;https://github.com/FamilySearch/gedcomx/blob/master/specifications/json-format-specification.md&quot;&gt;The GEDCOM X JSON Format, Version 1.0&lt;/a&gt;&lt;/li&gt;
    ///  &lt;li&gt;&lt;a href=&quot;https://github.com/FamilySearch/gedcomx/blob/master/specifications/xml-format-specification.md&quot;&gt;The GEDCOM X XML Format, Version 1.0&lt;/a&gt;&lt;/li&gt;
    ///  &lt;/ul&gt;
    ///  
    ///  &lt;p&gt;This documentation is provided as a non-normative reference guide.&lt;/p&gt;
    /// </remarks>
    /// <summary>
    ///  &lt;p&gt;The GEDCOM X data formats define the serialization formats of the GEDCOM X conceptual model. The canonical documentation
    ///  is provided by the formal specification documents:&lt;/p&gt;
    ///  
    ///  &lt;ul&gt;
    ///  &lt;li&gt;&lt;a href=&quot;https://github.com/FamilySearch/gedcomx/blob/master/specifications/conceptual-model-specification.md&quot;&gt;The GEDCOM X Conceptual Model, Version 1.0&lt;/a&gt;&lt;/li&gt;
    ///  &lt;li&gt;&lt;a href=&quot;https://github.com/FamilySearch/gedcomx/blob/master/specifications/json-format-specification.md&quot;&gt;The GEDCOM X JSON Format, Version 1.0&lt;/a&gt;&lt;/li&gt;
    ///  &lt;li&gt;&lt;a href=&quot;https://github.com/FamilySearch/gedcomx/blob/master/specifications/xml-format-specification.md&quot;&gt;The GEDCOM X XML Format, Version 1.0&lt;/a&gt;&lt;/li&gt;
    ///  &lt;/ul&gt;
    ///  
    ///  &lt;p&gt;This documentation is provided as a non-normative reference guide.&lt;/p&gt;
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Gedcomx")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Gedcomx")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gedcomx.org/v1/", ElementName = "gedcomx")]
    public partial class Gedcomx : Gx.Links.HypermediaEnabledData
    {

        private string _lang;
        private string _descriptionRef;
        private string _profile;
        private Gx.Common.Attribution _attribution;
        private System.Collections.Generic.List<Gx.Conclusion.Person> _persons;
        private System.Collections.Generic.List<Gx.Conclusion.Relationship> _relationships;
        private System.Collections.Generic.List<Gx.Source.SourceDescription> _sourceDescriptions;
        private System.Collections.Generic.List<Gx.Agent.Agent> _agents;
        private System.Collections.Generic.List<Gx.Conclusion.Event> _events;
        private System.Collections.Generic.List<Gx.Conclusion.PlaceDescription> _places;
        private System.Collections.Generic.List<Gx.Conclusion.Document> _documents;
        private System.Collections.Generic.List<Gx.Records.Collection> _collections;
        private System.Collections.Generic.List<Gx.Records.Field> _fields;
        private System.Collections.Generic.List<Gx.Records.RecordDescriptor> _recordDescriptors;
        /// <summary>
        ///  The language of the genealogical data.
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
        ///  A reference to a description of this data set.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "description")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "description")]
        [Newtonsoft.Json.JsonProperty("description")]
        public string DescriptionRef
        {
            get
            {
                return this._descriptionRef;
            }
            set
            {
                this._descriptionRef = value;
            }
        }
        /// <summary>
        ///  A reference to the profile that describes this data set.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "profile")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "profile")]
        [Newtonsoft.Json.JsonProperty("profile")]
        public string Profile
        {
            get
            {
                return this._profile;
            }
            set
            {
                this._profile = value;
            }
        }
        /// <summary>
        ///  The attribution of this genealogical data.
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
        /// <summary>
        ///  The persons included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "person", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "person")]
        [Newtonsoft.Json.JsonProperty("persons")]
        public System.Collections.Generic.List<Gx.Conclusion.Person> Persons
        {
            get
            {
                return this._persons;
            }
            set
            {
                this._persons = value;
            }
        }
        /// <summary>
        ///  The relationships included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "relationship", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "relationship")]
        [Newtonsoft.Json.JsonProperty("relationships")]
        public System.Collections.Generic.List<Gx.Conclusion.Relationship> Relationships
        {
            get
            {
                return this._relationships;
            }
            set
            {
                this._relationships = value;
            }
        }
        /// <summary>
        ///  The descriptions of sources included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "sourceDescription", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "sourceDescription")]
        [Newtonsoft.Json.JsonProperty("sourceDescriptions")]
        public System.Collections.Generic.List<Gx.Source.SourceDescription> SourceDescriptions
        {
            get
            {
                return this._sourceDescriptions;
            }
            set
            {
                this._sourceDescriptions = value;
            }
        }
        /// <summary>
        ///  The agents included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "agent", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "agent")]
        [Newtonsoft.Json.JsonProperty("agents")]
        public System.Collections.Generic.List<Gx.Agent.Agent> Agents
        {
            get
            {
                return this._agents;
            }
            set
            {
                this._agents = value;
            }
        }
        /// <summary>
        ///  The events included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "event", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "event")]
        [Newtonsoft.Json.JsonProperty("events")]
        public System.Collections.Generic.List<Gx.Conclusion.Event> Events
        {
            get
            {
                return this._events;
            }
            set
            {
                this._events = value;
            }
        }
        /// <summary>
        ///  The places included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "place", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "place")]
        [Newtonsoft.Json.JsonProperty("places")]
        public System.Collections.Generic.List<Gx.Conclusion.PlaceDescription> Places
        {
            get
            {
                return this._places;
            }
            set
            {
                this._places = value;
            }
        }
        /// <summary>
        ///  The documents included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "document", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "document")]
        [Newtonsoft.Json.JsonProperty("documents")]
        public System.Collections.Generic.List<Gx.Conclusion.Document> Documents
        {
            get
            {
                return this._documents;
            }
            set
            {
                this._documents = value;
            }
        }
        /// <summary>
        ///  The collections included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "collection", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "collection")]
        [Newtonsoft.Json.JsonProperty("collections")]
        public System.Collections.Generic.List<Gx.Records.Collection> Collections
        {
            get
            {
                return this._collections;
            }
            set
            {
                this._collections = value;
            }
        }
        /// <summary>
        ///  The extracted fields included in this genealogical data set.
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
        /// <summary>
        ///  The record descriptors included in this genealogical data set.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "recordDescriptor", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "recordDescriptor")]
        [Newtonsoft.Json.JsonProperty("recordDescriptors")]
        public System.Collections.Generic.List<Gx.Records.RecordDescriptor> RecordDescriptors
        {
            get
            {
                return this._recordDescriptors;
            }
            set
            {
                this._recordDescriptors = value;
            }
        }

        public Gedcomx AddCollection(Collection collection)
        {
            this.Collections.Add(collection);

            return this;
        }

        public void AddPerson(Person person)
        {
            if (person != null)
            {
                if (Persons == null)
                {
                    Persons = new List<Person>();
                }

                Persons.Add(person);
            }
        }

        /// <summary>
        /// Add a relationship to the data set.
        /// </summary>
        /// <param name="relationship">The relationship to be added.</param>
        public void AddRelationship(Relationship relationship)
        {
            if (relationship != null)
            {
                if (Relationships == null)
                    Relationships = new List<Relationship>();
                Relationships.Add(relationship);
            }
        }

        /// <summary>
        /// Add a source description to the data set.
        /// </summary>
        /// <param name="sourceDescription">The source description to be added.</param>
        public void AddSourceDescription(SourceDescription sourceDescription)
        {
            if (sourceDescription != null)
            {
                if (SourceDescriptions == null)
                    SourceDescriptions = new List<SourceDescription>();
                SourceDescriptions.Add(sourceDescription);
            }
        }

        /// <summary>
        /// Add a agent to the data set.
        /// </summary>
        /// <param name="agent">The agent to be added.</param>
        public void AddAgent(Gx.Agent.Agent agent)
        {
            if (agent != null)
            {
                if (Agents == null)
                    Agents = new List<Gx.Agent.Agent>();
                Agents.Add(agent);
            }
        }

        /// <summary>
        /// Add a event to the data set.
        /// </summary>
        /// <param name="event">The event to be added.</param>
        public void AddEvent(Event @event)
        {
            if (@event != null)
            {
                if (Events == null)
                    Events = new List<Event>();
                Events.Add(@event);
            }
        }

        /// <summary>
        /// Add a place to the data set.
        /// </summary>
        /// <param name="place">The place to be added.</param>
        public void AddPlace(PlaceDescription place)
        {
            if (place != null)
            {
                if (Places == null)
                    Places = new List<PlaceDescription>();
                Places.Add(place);
            }
        }

        /// <summary>
        /// Add a document to the data set.
        /// </summary>
        /// <param name="document">The document to be added.</param>
        public void AddDocument(Document document)
        {
            if (document != null)
            {
                if (Documents == null)
                    Documents = new List<Document>();
                Documents.Add(document);
            }
        }

        /// <summary>
        /// Add a field to the data set.
        /// </summary>
        /// <param name="field">The field to be added.</param>
        public void AddField(Field field)
        {
            if (field != null)
            {
                if (Fields == null)
                    Fields = new List<Field>();
                Fields.Add(field);
            }
        }

        /**
         * Add a recordDescriptor to the data set.
         *
         * @param recordDescriptor The recordDescriptor to be added.
         */
        public void AddRecordDescriptor(RecordDescriptor recordDescriptor)
        {
            if (recordDescriptor != null)
            {
                if (RecordDescriptors == null)
                    RecordDescriptors = new List<RecordDescriptor>();
                RecordDescriptors.Add(recordDescriptor);
            }
        }

        public virtual void Embed(Gedcomx gedcomx)
        {
            List<Link> links = gedcomx.Links;
            if (links != null)
            {
                foreach (Link link in links)
                {
                    bool found = false;
                    if (link.Rel != null)
                    {
                        if (Links != null)
                        {
                            foreach (Link target in Links)
                            {
                                if (link.Rel.Equals(target.Rel))
                                {
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddLink(link);
                    }
                }
            }

            List<Person> persons = gedcomx.Persons;
            if (persons != null)
            {
                foreach (Person person in persons)
                {
                    bool found = false;
                    if (person.Id != null)
                    {
                        if (Persons != null)
                        {
                            foreach (Person target in Persons)
                            {
                                if (person.Id.Equals(target.Id))
                                {
                                    target.Embed(person);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddPerson(person);
                    }
                }
            }

            List<Relationship> relationships = gedcomx.Relationships;
            if (relationships != null)
            {
                foreach (Relationship relationship in relationships)
                {
                    bool found = false;
                    if (relationship.Id != null)
                    {
                        if (Relationships != null)
                        {
                            foreach (Relationship target in Relationships)
                            {
                                if (relationship.Id.Equals(target.Id))
                                {
                                    target.Embed(relationship);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddRelationship(relationship);
                    }
                }
            }

            List<SourceDescription> sourceDescriptions = gedcomx.SourceDescriptions;
            if (sourceDescriptions != null)
            {
                foreach (SourceDescription sourceDescription in sourceDescriptions)
                {
                    bool found = false;
                    if (sourceDescription.Id != null)
                    {
                        if (SourceDescriptions != null)
                        {
                            foreach (SourceDescription target in SourceDescriptions)
                            {
                                if (sourceDescription.Id.Equals(target.Id))
                                {
                                    target.Embed(sourceDescription);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddSourceDescription(sourceDescription);
                    }
                }
            }

            List<Gx.Agent.Agent> agents = gedcomx.Agents;
            if (agents != null)
            {
                foreach (Gx.Agent.Agent agent in agents)
                {
                    bool found = false;
                    if (agent.Id != null)
                    {
                        if (Agents != null)
                        {
                            foreach (Gx.Agent.Agent target in Agents)
                            {
                                if (agent.Id.Equals(target.Id))
                                {
                                    target.Embed(agent);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddAgent(agent);
                    }
                }
            }

            List<Event> events = gedcomx.Events;
            if (events != null)
            {
                foreach (Event @event in events)
                {
                    bool found = false;
                    if (@event.Id != null)
                    {
                        if (Events != null)
                        {
                            foreach (Event target in Events)
                            {
                                if (@event.Id.Equals(target.Id))
                                {
                                    target.Embed(@event);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddEvent(@event);
                    }
                }
            }

            List<PlaceDescription> placeDescriptions = gedcomx.Places;
            if (placeDescriptions != null)
            {
                foreach (PlaceDescription placeDescription in placeDescriptions)
                {
                    bool found = false;
                    if (placeDescription.Id != null)
                    {
                        if (Places != null)
                        {
                            foreach (PlaceDescription target in Places)
                            {
                                if (placeDescription.Id.Equals(target.Id))
                                {
                                    target.Embed(placeDescription);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddPlace(placeDescription);
                    }
                }
            }

            List<Document> documents = gedcomx.Documents;
            if (documents != null)
            {
                foreach (Document document in documents)
                {
                    bool found = false;
                    if (document.Id != null)
                    {
                        if (Documents != null)
                        {
                            foreach (Document target in Documents)
                            {
                                if (document.Id.Equals(target.Id))
                                {
                                    target.Embed(document);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddDocument(document);
                    }
                }
            }

            List<Collection> collections = gedcomx.Collections;
            if (collections != null)
            {
                foreach (Collection collection in collections)
                {
                    bool found = false;
                    if (collection.Id != null)
                    {
                        if (Collections != null)
                        {
                            foreach (Collection target in Collections)
                            {
                                if (collection.Id.Equals(target.Id))
                                {
                                    target.Embed(collection);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddCollection(collection);
                    }
                }
            }

            List<Field> fields = gedcomx.Fields;
            if (fields != null)
            {
                foreach (Field field in fields)
                {
                    bool found = false;
                    if (field.Id != null)
                    {
                        if (Fields != null)
                        {
                            foreach (Field target in Fields)
                            {
                                if (field.Id.Equals(target.Id))
                                {
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddField(field);
                    }
                }
            }

            List<RecordDescriptor> recordDescriptors = gedcomx.RecordDescriptors;
            if (recordDescriptors != null)
            {
                foreach (RecordDescriptor recordDescriptor in recordDescriptors)
                {
                    bool found = false;
                    if (recordDescriptor.Id != null)
                    {
                        if (RecordDescriptors != null)
                        {
                            foreach (RecordDescriptor target in RecordDescriptors)
                            {
                                if (recordDescriptor.Id.Equals(target.Id))
                                {
                                    target.Embed(recordDescriptor);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!found)
                    {
                        AddRecordDescriptor(recordDescriptor);
                    }
                }
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor.
         */
        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitGedcomx(this);
        }
    }
}
