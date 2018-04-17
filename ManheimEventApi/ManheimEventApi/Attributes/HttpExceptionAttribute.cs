using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using ManheimEventApi.Logging;

namespace ManheimEventApi.Attributes
{
    public class HttpExceptionAttribute : ExceptionFilterAttribute
    {
        private const string Content = "An internal server error occurred!";
        private const string ReasonPhrase = "Internal Server Error";

        public override void OnException(HttpActionExecutedContext context)
        {
            Logger.Error(context.Exception);

            throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(Content),
                ReasonPhrase = ReasonPhrase
            });
        }
    }
}