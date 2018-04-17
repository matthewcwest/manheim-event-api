using System;
using System.Collections.Generic;
using System.Net;
using ManheimEventApi.Attributes;
using System.Web.Http.Controllers;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Reflection;
using System.Web.Http.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;
using ManheimEventApi.Utilities;
using Moq;

namespace ManheimEventApiTest.Attributes
{
    public class HttpAuthorizeAttributeTest : TestBase<HttpAuthorizeAttribute>
    {
        private const string ApiKey = "TestApiKey";

        private Mock<IConfigurationUtility> ConfigUtilityMock { get; }

        public HttpAuthorizeAttributeTest()
        {
            ConfigUtilityMock = new Mock<IConfigurationUtility>();

            InstantiateClassUnderTest(ConfigUtilityMock.Object);
        }

        [Fact]
        public void HttpAuthorizeAttribute_OnAuthorize_WithAuthorizedHeader_ReturnsAuthorization()
        {
            ConfigUtilityMock.Setup(x => x.ApiKey).Returns(ApiKey);

            var po = new PrivateObject(ClassUnderTest);
            var scheme = (string)po.GetField("Scheme", BindingFlags.NonPublic | BindingFlags.Static);

            var headerValue = new AuthenticationHeaderValue(scheme, ApiKey);
            var context = new HttpActionContext();
            var request = new HttpRequestMessage();
            var controllerContext = new HttpControllerContext();

            request.Headers.Authorization = headerValue;
            controllerContext.Request = request;
            context.ControllerContext = controllerContext;
            context.Request.RequestUri = new Uri("http://test.com");

            var isAuthorizedWasCalled = false;
            var expectedContext = new HttpActionContext();

            ShimAuthorizeAttribute.AllInstances.IsAuthorizedHttpActionContext = (x, y) =>
            {
                isAuthorizedWasCalled = true;
                expectedContext = y;

                return true;
            };

            ClassUnderTest.OnAuthorization(context);

            Assert.Null(context.Response);
            Assert.True(isAuthorizedWasCalled);
            Assert.Equal(expectedContext, context);
        }

        [Theory]
        [MemberData(nameof(SetupData))]
        public void HttpAuthorizeAttribute_OnAuthorize_WithNullOrUnauthorizedHeaders_ReturnsUnauthorizedResponse(HttpActionContext context)
        {
            var po = new PrivateObject(ClassUnderTest);
            var reasonPhrase = (string)po.GetField("ReasonPhrase", BindingFlags.NonPublic | BindingFlags.Static);

            ClassUnderTest.OnAuthorization(context);

            Assert.Equal(context.Response.StatusCode, HttpStatusCode.Unauthorized);
            Assert.Equal(context.Response.ReasonPhrase, reasonPhrase);
        }

        public static IEnumerable<object[]> SetupData()
        {
            return new List<object[]>
            {
                new object[] { GetNullHeaderActionContext() },
                new object[] { GetUnauthorizedHeaderActionContext() }
            };
        }

        private static HttpActionContext GetNullHeaderActionContext()
        {
            var actionContext = new HttpActionContext();
            var request = new HttpRequestMessage();
            var controllerContext = new HttpControllerContext { Request = request };

            actionContext.ControllerContext = controllerContext;
            actionContext.Request.RequestUri = new Uri("http://test.com");

            return actionContext;
        }

        private static HttpActionContext GetUnauthorizedHeaderActionContext()
        {
            var actionContext = new HttpActionContext();
            var request = new HttpRequestMessage();
            var controllerContext = new HttpControllerContext { Request = request };

            var headerValue = new AuthenticationHeaderValue("Basic", "eGVzdDoxMjM=");
            request.Headers.Authorization = headerValue;
            controllerContext.Request = request;
            actionContext.ControllerContext = controllerContext;
            actionContext.Request.RequestUri = new Uri("http://test.com");

            return actionContext;
        }
    }
}
