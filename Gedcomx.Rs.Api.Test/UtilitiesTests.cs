﻿using FamilySearch.Api.Util;
using Gx.Rs.Api;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gx.Rs.Api.Util;
using Gedcomx.Support;
using Newtonsoft.Json.Linq;
using FamilySearch.Api.Ft;
using Newtonsoft.Json;
using System.Net;

namespace Gedcomx.Rs.Api.Test
{
    [TestFixture]
    public class UtilitiesTests
    {
        private FamilySearchFamilyTree tree;

        [TestFixtureSetUp]
        public void Initialize()
        {
            tree = new FamilySearchFamilyTree(true);
            tree.AuthenticateViaOAuth2Password(Resources.TestUserName, Resources.TestPassword, Resources.TestClientId);
        }

        [Test]
        public void TestReadPersonWithMultiplePendingModificationsActivated()
        {
            // Make a separate copy from the main tree used in other tests
            var tempTree = new FamilySearchFamilyTree(true);
            var features = new List<String>();

            tempTree.AuthenticateViaOAuth2Password(Resources.TestUserName, Resources.TestPassword, Resources.TestClientId);

            // Get all the features that are pending
            IRestRequest request = new RestRequest()
                .Accept(MediaTypes.APPLICATION_JSON_TYPE)
                .Build("https://sandbox.familysearch.org/platform/pending-modifications", Method.GET);
            IRestResponse response = tempTree.Client.Handle(request);

            // Get each pending feature
            foreach (var kvp in JsonConvert.DeserializeObject<IDictionary<String, JToken>>(response.Content).Where(x => x.Key == "features"))
            {
                foreach (var feature in kvp.Value.ToArray().SelectMany(x => x.ToObject<IDictionary<String, JToken>>().Where(y => y.Key == "name").Select(z => z.Value.ToString())))
                {
                    features.Add(feature);
                }
            }

            // Add every pending feature to the tree's current client
            tempTree.Client.AddFilter(new ExperimentsFilter(features.ToArray()));

            var state = tempTree.AddPerson(TestBacking.GetCreateMalePerson());

            // Ensure a response came back
            Assert.IsNotNull(state);
            var requestedFeatures = String.Join(",", state.Request.GetHeaders().Get("X-FS-Feature-Tag").Select(x => x.Value.ToString()));
            // Ensure each requested feature was found in the request headers
            Assert.IsTrue(features.TrueForAll(x => requestedFeatures.Contains(x)));
        }

        [Test]
        public void TestReadPersonWithPendingModificationActivated()
        {
            // The default client is assumed to add a single pending feature (if it doesn't, this test will fail)
            var state = tree.AuthenticateViaOAuth2Password(Resources.TestUserName, Resources.TestPassword, Resources.TestClientId);

            Assert.IsNotNull(state);
            var requestedFeatures = String.Join(",", state.Request.GetHeaders().Get("X-FS-Feature-Tag").Select(x => x.Value.ToString()));
            Assert.IsNotNull(requestedFeatures);
            Assert.AreEqual(-1, requestedFeatures.IndexOf(","));
            Assert.Greater(requestedFeatures.Length, 0);
        }

        [Test]
        public void TestRedirectToPerson()
        {
            var person = tree.AddPerson(TestBacking.GetCreateMalePerson());
            var id = person.Response.Headers.Get("X-ENTITY-ID").Single().Value.ToString();
            IRestRequest request = new RestRequest()
                .Accept(MediaTypes.APPLICATION_JSON_TYPE)
                .Build("https://sandbox.familysearch.org/platform/redirect?person=" + id, Method.GET);
            var response = tree.Client.Execute(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.TemporaryRedirect, response.StatusCode);
        }

        [Test]
        public void TestRedirectToPersonMemories()
        {
            var person = tree.AddPerson(TestBacking.GetCreateMalePerson());
            var id = person.Response.Headers.Get("X-ENTITY-ID").Single().Value.ToString();
            IRestRequest request = new RestRequest()
                .Accept(MediaTypes.APPLICATION_JSON_TYPE)
                .Build("https://sandbox.familysearch.org/platform/redirect?context=memories&person=" + id, Method.GET);
            var response = tree.Client.Execute(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.TemporaryRedirect, response.StatusCode);
        }

        [Test]
        public void TestRedirectToSourceLinker()
        {
            var person = (FamilyTreePersonState)tree.AddPerson(TestBacking.GetCreateMalePerson()).Get();
            var uri = String.Format("https://sandbox.familysearch.org/platform/redirect?context=sourcelinker&person={0}&hintId={1}", person.Person.Id, person.Person.Identifiers[0].Value);
            IRestRequest request = new RestRequest()
                .Accept(MediaTypes.APPLICATION_JSON_TYPE)
                .Build(uri, Method.GET);
            var response = tree.Client.Execute(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.TemporaryRedirect, response.StatusCode);
        }

        [Test]
        public void TestRedirectToUri()
        {
            IRestRequest request = new RestRequest()
                .Accept(MediaTypes.APPLICATION_JSON_TYPE)
                .Build("https://sandbox.familysearch.org/platform/redirect?uri=https://familysearch.org/some/path?p1%3Dp1-value%26p2%3Dp2-value", Method.GET);
            var response = tree.Client.Execute(request);

            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.TemporaryRedirect, response.StatusCode);
        }
    }
}