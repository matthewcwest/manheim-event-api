using ManheimEventApi.Logging;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ManheimEventApi.Attributes
{
    public class RequireHttpsAttribute : AuthorizationFilterAttribute
    {
        private const string ReasonPhrase = "Internal Server Error";
        private const string Content = "HTTPS required";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
                {
                    ReasonPhrase = ReasonPhrase,
                    Content = new StringContent(Content)
                };

                Logger.Warning("A request has been attempted over HTTP. HTTPS is required.");
            }
            else
            {
                base.OnAuthorization(actionContext);
            }
        }
    }
}