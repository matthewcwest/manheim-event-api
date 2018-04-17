using ManheimEventApi.Attributes;
using System.Web.Http.Controllers;
using Xunit;
using Assert = Xunit.Assert;
using System.Net.Http;
using System.Net;
using System;

namespace ManheimEventApiTest.Attributes
{
    public class ValidateModelAttributeTest : TestBase<ValidateModelAttribute>
    {
        public ValidateModelAttributeTest()
        {
            InstantiateClassUnderTest();
        }

        [Fact]
        public void ValidateModelAttribute_OnActionExecuting_WithValidatedModel_ValidatesModel()
        {
            var actionContext = new HttpActionContext();           

            ClassUnderTest.OnActionExecuting(actionContext);

            Assert.Null(actionContext.Response);
        }

        [Fact]
        public void ValidateModelAttribute_OnActionExecuting_WithInvalidModel_ReturnsBadRequest()
        {
            var actionContext = new HttpActionContext();
            var request = new HttpRequestMessage();
            var controllerContext = new HttpControllerContext { Request = request };

            controllerContext.Request = request;
            actionContext.ControllerContext = controllerContext;
            actionContext.Request.RequestUri = new Uri("http://test.com");
            actionContext.ModelState.AddModelError("", "");

            ClassUnderTest.OnActionExecuting(actionContext);

            Assert.False(actionContext.ModelState.IsValid);
            Assert.Equal(actionContext.Response.StatusCode, HttpStatusCode.BadRequest);
        }
    }
}
