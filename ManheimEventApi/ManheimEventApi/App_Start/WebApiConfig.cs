using System.Web.Http;
using ManheimEventApi.Logging;

namespace ManheimEventApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Logger.Info("Registering config");

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}"
            );
        }
    }
}
