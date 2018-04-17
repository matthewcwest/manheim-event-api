using ManheimEventApi.Logging;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace ManheimEventApi.Attributes
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ModelState.IsValid)
            {
                return;
            }

            Logger.Error($"Bad request was sent to {actionContext.Request.RequestUri.LocalPath}");

            LogInvalidModelState(actionContext);

            actionContext.Response = actionContext.Request.CreateErrorResponse(
                HttpStatusCode.BadRequest, actionContext.ModelState);
        }

        private void LogInvalidModelState(HttpActionContext actionContext)
        {
            foreach (var modelState in actionContext.ModelState.Values)
            {
                foreach (ModelError error in modelState.Errors)
                {
                    if (!string.IsNullOrEmpty(error.ErrorMessage))
                    {
                        Logger.Error($"{error.ErrorMessage}");
                    }

                    if (error.Exception != null)
                    {
                        Logger.Error($"{error.Exception.Message}");
                    }
                }
            }
        }
    }
}