using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManheimEventApi.Attributes;
using System.Web.Http.Controllers;
using Xunit;
using Assert = Xunit.Assert;
using System.Net.Http;
using System.Net;
using System;
using System.Reflection;
using System.Web.Http.Filters.Fakes;

namespace ManheimEventApiTest.Attributes
{
    public class RequireHttpsAttributeTest : TestBase<RequireHttpsAttribute>
    {
        public RequireHttpsAttributeTest()
        {
            InstantiateClassUnderTest();
        }

        [Fact]
        public void RequireHttpsAttribute_OnAuthorization_WithHttps_CallsBaseOnAuthorization()
        {
            var actionContext = SetupActionContext("https://test.test.test");

            var isAuthorizedWasCalled = false;
            var expectedContext = new HttpActionContext();

            ShimAuthorizationFilterAttribute.AllInstances.OnAuthorizationHttpActionContext = (x, y) =>
            {
                isAuthorizedWasCalled = true;
                expectedContext = y;
            };

            ClassUnderTest.OnAuthorization(actionContext);

            Assert.Null(actionContext.Response);
            Assert.True(isAuthorizedWasCalled);
            Assert.Equal(expectedContext, actionContext);
        }

        [Fact]
        public void RequireHttpsAttribute_OnAuthorization_WithHttp_ReturnsForbiddenResponse()
        {
            var po = new PrivateObject(ClassUnderTest);
            var content = (string)po.GetField("Content", BindingFlags.NonPublic | BindingFlags.Static);
            var reasonPhrase = (string)po.GetField("ReasonPhrase", BindingFlags.NonPublic | BindingFlags.Static);
            var actionContext = SetupActionContext("http://test.test.test");

            ClassUnderTest.OnAuthorization(actionContext);

            Assert.Equal(actionContext.Response.StatusCode, HttpStatusCode.Forbidden);
            Assert.Equal(actionContext.Response.ReasonPhrase, reasonPhrase);
            Assert.Equal(actionContext.Response.Content.ReadAsStringAsync().Result, content);
        }

        private static HttpActionContext SetupActionContext(string uriString)
        {
            var uri = new Uri(uriString);
            var actionContext = new HttpActionContext();
            var request = new HttpRequestMessage();
            var controllerContext = new HttpControllerContext();

            request.RequestUri = uri;
            controllerContext.Request = request;
            actionContext.ControllerContext = controllerContext;

            return actionContext;
        }
    }
}
