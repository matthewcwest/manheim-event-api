using System;
using System.Net;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Filters;
using ManheimEventApi.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace ManheimEventApiTest.Attributes
{
    public class HttpExceptionAttributeTest : TestBase<HttpExceptionAttribute>
    {
        public HttpExceptionAttributeTest()
        {
            InstantiateClassUnderTest();
        }

        [Fact]
        public void HttpExceptionAttribute_WithException_ReturnsExceptionAndCorrectStatusCode()
        {
            var po = new PrivateObject(ClassUnderTest);
            var content = (string)po.GetField("Content", BindingFlags.NonPublic | BindingFlags.Static);
            var reasonPhrase = (string)po.GetField("ReasonPhrase", BindingFlags.NonPublic | BindingFlags.Static);

            var exceptionParam = new HttpActionExecutedContext { Exception = new Exception() };

            var expectedException = Assert.Throws<HttpResponseException>(() => ClassUnderTest.OnException(exceptionParam));

            Assert.Equal(expectedException.Response.ReasonPhrase, reasonPhrase);
            Assert.Equal(expectedException.Response.Content.ReadAsStringAsync().Result, content);
            Assert.Equal(expectedException.Response.StatusCode, HttpStatusCode.InternalServerError);
        }
    }
}
