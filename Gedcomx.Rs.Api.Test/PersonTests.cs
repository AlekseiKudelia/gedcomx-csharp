﻿using Gx.Common;
using Gx.Conclusion;
using Gx.Links;
using Gx.Rs.Api;
using Gx.Rs.Api.Util;
using Gx.Source;
using KellermanSoftware.CompareNetObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Gedcomx.Rs.Api.Test
{
    [TestFixture]
    public class PersonTests
    {
        private static readonly String SANDBOX_URI = "https://sandbox.familysearch.org/platform/collections/tree";
        private static readonly String READ_PERSON_URI = "https://sandbox.familysearch.org/platform/tree/persons/KWQ7-Y57";
        private static readonly String PERSON_WITH_DATA_URI = "https://sandbox.familysearch.org/platform/tree/persons/KWWD-CMF";
        private CollectionState collection;
        private Person testPerson;

        [TestFixtureSetUp]
        public void Initialize()
        {
            collection = new CollectionState(new Uri(SANDBOX_URI));
            collection.AuthenticateViaOAuth2Password("sdktester", "1234sdkpass", "WCQY-7J1Q-GKVV-7DNM-SQ5M-9Q5H-JX3H-CMJK");
            Assert.DoesNotThrow(() => collection.IfSuccessful());
            Assert.IsNotNullOrEmpty(collection.CurrentAccessToken);
            testPerson = TestBacking.GetCreatePerson();
        }

        [Test]
        public void TestCreatePerson()
        {
            var result = collection.AddPerson(testPerson);
            Assert.DoesNotThrow(() => result.IfSuccessful());
            var person = (PersonState)result.Get();
            Assert.IsNotNull(person.Person);
            Assert.IsNotNullOrEmpty(person.Person.Id);
        }

        [Test]
        public void TestPersonSourceReference()
        {
            var result = collection.AddPerson(testPerson);
            Assert.DoesNotThrow(() => result.IfSuccessful());
            var state = (PersonState)result.Get();
            var result2 = state.AddSourceReference(TestBacking.GetPersonSourceReference());
            Assert.DoesNotThrow(() => result2.IfSuccessful());
            Assert.IsTrue(result2.Response.StatusCode == HttpStatusCode.Created);
        }

        [Test]
        public void TestCreatePersonConclusion()
        {
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            Person conclusion = TestBacking.GetCreatePersonConclusion(state.Person.Id);
            var state2 = state.UpdateConclusions(conclusion);
            Assert.IsNotNull(state2);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
        }

        [Test]
        [Ignore("May depend on discussions. Also need to resolve discussion-references element.")]
        public void TestCreateDiscussionReference()
        {
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            var discussion = TestBacking.GetCreateDiscussionReference(state.Person.Id);
            throw new NotImplementedException();
        }

        [Test]
        public void TestCreateNote()
        {
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            var note = TestBacking.GetCreateNote(state.Person.Id);
            var state2 = state.AddNote(note);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
        }

        [Test]
        public void TestReadMergedPerson()
        {
            // KWWD-X35 was merged with KWWD-CMF
            var state = collection.ReadPerson(new Uri("https://sandbox.familysearch.org/platform/tree/persons/KWWD-X35"));
            Assert.DoesNotThrow(() => state.IfSuccessful());
            Assert.IsTrue(state.Response.StatusCode == HttpStatusCode.MovedPermanently);
            var link = state.GetLink("self");
            Assert.IsNotNull(link);
            Assert.IsTrue(link.Href == PERSON_WITH_DATA_URI);
        }

        [Test]
        public void TestReadDeletedPerson()
        {
            var state = collection.ReadPerson(new Uri("https://sandbox.familysearch.org/platform/tree/persons/KWWD-ZM7"));
            Assert.IsTrue(state.Response.StatusCode == HttpStatusCode.Gone);
        }

        [Test]
        public void TestReadPerson()
        {
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            Assert.DoesNotThrow(() => state.IfSuccessful());
            Assert.IsNotNull(state.Person);
            Assert.IsNotNullOrEmpty(state.Person.Id);
        }

        [Test]
        public void TestReadPersonSourceReferences()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.LoadSourceReferences();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsNotNull(state2.Person);
            Assert.IsNotNull(state2.Person.Sources);
        }

        [Test]
        [Ignore("May not be needed. Covered by TestReadPersonSourceReferences()?")]
        public void TestReadPersonSources()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void TestReadRelationshipsToChildren()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.LoadChildRelationships();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            var children = state2.GetChildRelationships();
            Assert.IsNotNull(children);
            Assert.IsTrue(children.Count > 0);
        }

        [Test]
        public void TestReadRelationshipsToParents()
        {
            var state = collection.ReadPerson(new Uri("https://sandbox.familysearch.org/platform/tree/persons/KWWD-QV9"));
            var state2 = state.LoadParentRelationships();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            var parents = state2.GetParentRelationships();
            Assert.IsNotNull(parents);
            Assert.IsTrue(parents.Count > 0);
        }

        [Test]
        public void TestReadRelationshipsToSpouses()
        {
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            var state2 = state.LoadSpouseRelationships();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            var spouses = state2.GetSpouseRelationships();
            Assert.IsNotNull(spouses);
            Assert.IsTrue(spouses.Count > 0);
        }

        [Test(Description = "Matches example request here https://familysearch.org/developers/docs/api/tree/Read_Relationships_To_Spouses_with_Persons_usecase, but is either unneeded or the SDK needs to be updated to support this more directly.")]
        public void TestReadRelationshipsToSpousesWithPersons()
        {
            var parameters = new ApplyParameters();
            parameters.Parameters.Add(new RestSharp.Parameter() { Name = "persons", Type = RestSharp.ParameterType.QueryString, Value = string.Empty });
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            var state2 = state.LoadSpouseRelationships(parameters);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsNotNull(state2.Entity != null);
            Assert.IsNotNull(state2.Entity.Persons);
            Assert.IsTrue(state2.Entity.Persons.Count == 2);
        }

        [Test]
        [Ignore("Discussions are not implemented yet.")]
        public void TestReadDiscussionReferences()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void TestReadChildrenOfAPerson()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.ReadChildren();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsNotNull(state2.Persons);
            Assert.IsTrue(state2.Persons.Count > 0);
        }

        [Test]
        public void TestReadNotFoundPerson()
        {
            var state = collection.ReadPerson(new Uri("https://sandbox.familysearch.org/platform/tree/persons/NOTFOUND"));
            Assert.IsTrue(state.Response.StatusCode == HttpStatusCode.NotFound);
        }

        [Test(Description = "Does not test implementations of StateTransitionOption. Need to implement StateTransitionOptions.")]
        public void TestReadNotModifiedPerson()
        {
            var parameters = new ApplyParameters();
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            var etag = state.Response.Headers.Single(x => x.Name == "ETag");
            parameters.Parameters.Add(new RestSharp.Parameter() { Name = "If-None-Match", Type = RestSharp.ParameterType.HttpHeader, Value = etag.Value });
            var state2 = collection.ReadPerson(new Uri(READ_PERSON_URI), parameters);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsTrue(state2.Response.StatusCode == HttpStatusCode.NotModified);
        }

        [Test]
        public void TestReadNotes()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.LoadNotes();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsNotNull(state2.Person);
            Assert.IsNotNull(state2.Person.Notes);
            Assert.IsTrue(state2.Person.Notes.Count > 0);
        }

        [Test]
        public void TestReadParentsOfAPerson()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.ReadParents();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsNotNull(state2.Persons);
            Assert.IsTrue(state2.Persons.Count > 0);
        }

        [Test(Description="PersonSpousesState is not yet implemented, but ReadSpouses() is implemented. No assertions made in this test.")]
        public void TestReadSpousesOfAPerson()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.ReadSpouses();
        }

        [Test]
        public void TestHeadPerson()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = (PersonState)state.Head();
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsTrue(state2.Response.StatusCode == HttpStatusCode.OK);
        }

        [Test]
        [Ignore("Need clarification on this before this is ready.")]
        public void TestUpdatePersonSourceReference()
        {
            // TODO: Is an ID needed? Is this the correct pattern? Was unable to get working via self-discovery.
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            state.Person.Sources = new List<SourceReference>();
            state.Person.Sources.Add(TestBacking.GetPersonSourceReference("????-???"));
            var state2 = state.UpdateSourceReferences(state.Person);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
        }

        [Test]
        public void TestUpdatePersonConclusion()
        {
            var state = collection.ReadPerson(new Uri(READ_PERSON_URI));
            state.Person.Facts.Add(TestBacking.GetNewFact());
            var state2 = state.UpdateConclusions(state.Person);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
        }

        [Test]
        public void TestUpdatePersonCustomNonEventFact()
        {
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state2 = state.UpdateFact(TestBacking.GetUpdateFact());

            Assert.DoesNotThrow(() => state2.IfSuccessful());
        }

        [Test(Description = "Does not test implementations of StateTransitionOption. Need to implement StateTransitionOptions.")]
        public void TestUpdatePersonWithPreconditions()
        {
            var parameters = new ApplyParameters();
            var state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var value = DateTime.UtcNow.ToString("ddd, dd MMM yyyy HH:mm:ss G\\MT");
#warning Need to address ETag precondition issue
            parameters.Parameters.Add(new RestSharp.Parameter() { Name = "If-Unmodified-Since", Type = RestSharp.ParameterType.HttpHeader, Value = value });
            var state2 = state.UpdateFacts(state.Person.Facts.ToArray(), parameters);
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsTrue(state2.Response.StatusCode == HttpStatusCode.NoContent);

            state = collection.ReadPerson(new Uri(PERSON_WITH_DATA_URI));
            var state3 = state.UpdateFacts(state.Person.Facts.ToArray(), parameters);
            Assert.Throws<GedcomxApplicationException>(() => state3.IfSuccessful());
            Assert.IsTrue(state3.Response.StatusCode == HttpStatusCode.PreconditionFailed);
        }

        [Test]
        public void TestDeletePerson()
        {
            // Assume the ability to add a person is working
            var state = collection.AddPerson(TestBacking.GetCreatePerson());
            var state2 = (PersonState)state.Delete();

            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsTrue(state2.Response.StatusCode == HttpStatusCode.NoContent);
        }

        [Test]
        public void TestDeletePersonSourceReference()
        {
            // Assume the ability to add a person is working
            var state = collection.AddPerson(TestBacking.GetCreatePerson());
            state = (PersonState)state.Get();
            // Assume the ability to add a source reference is working
            state.AddSourceReference(TestBacking.GetPersonSourceReference());
            state.LoadSourceReferences();

            var state2 = state.DeleteSourceReference(state.Person.Sources.FirstOrDefault());
            Assert.DoesNotThrow(() => state2.IfSuccessful());
            Assert.IsTrue(state2.Response.StatusCode == HttpStatusCode.NoContent);
        }

        [Test]
        public void TestDeletePersonConclusion()
        {
            // Assume the ability to add a person is working
            var state = collection.AddPerson(TestBacking.GetCreatePerson());
            state = (PersonState)state.Get();
            state = state.DeleteFact(state.Person.Facts.FirstOrDefault());
            Assert.DoesNotThrow(() => state.IfSuccessful());
            Assert.IsTrue(state.Response.StatusCode == HttpStatusCode.NoContent);
        }

        [Test(Description = "Does not test implementations of StateTransitionOption. Need to implement StateTransitionOptions.")]
        public void TestDeletePersonWithPreconditions()
        {
            var parameters = new ApplyParameters();
            // Assume the ability to add a person is working
            var state = collection.AddPerson(TestBacking.GetCreatePerson());
            state = (PersonState)state.Get();
            var value = DateTime.UtcNow.ToString("ddd, dd MMM yyyy HH:mm:ss G\\MT");
#warning Need to address ETag precondition issue
            parameters.Parameters.Add(new RestSharp.Parameter() { Name = "If-Unmodified-Since", Type = RestSharp.ParameterType.HttpHeader, Value = value });

            // Touch the record since the above date
            state.Update(state.Person);

            // This should fail
            var state2 = (PersonState)state.Delete(parameters);
            Assert.Throws<GedcomxApplicationException>(() => state2.IfSuccessful());
            Assert.IsTrue(state2.Response.StatusCode == HttpStatusCode.PreconditionFailed);
        }

        [Test]
        [Ignore("Unable to create discussion references (part of extensions).")]
        public void TestDeleteDiscussionReference()
        {
            throw new NotImplementedException();
        }

        [Test]
        [Ignore("Unable to test restore (part of extensions).")]
        public void TestRestorePerson()
        {
            // Assume the ability to add a person is working
            var state = collection.AddPerson(TestBacking.GetCreatePerson());
            state = (PersonState)state.Delete();

            throw new NotImplementedException();
        }

        [Test]
        public void TestSearchForPersonsAndReadPerson()
        {
            GedcomxPersonSearchQueryBuilder query = new GedcomxPersonSearchQueryBuilder()
                .Name("John Smith")
                .BirthDate("1 January 1900")
                .FatherName("Peter Smith");

            PersonSearchResultsState results = collection.SearchForPersons(query);

            Assert.DoesNotThrow(() => results.IfSuccessful());
            PersonState person = results.ReadPerson(results.Results.Entries.FirstOrDefault());

            Assert.IsNotNull(person);
            Assert.DoesNotThrow(() => person.IfSuccessful());
        }
    }
}