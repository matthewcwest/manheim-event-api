using System.Web;
using System.Web.Http;
using ManheimEventApi.Attributes;
using ManheimEventApi.Utilities;
using ManheimEventApi.DependencyInjection;
using System.Web.Http.Filters;

namespace ManheimEventApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ContainerInstance.RegisterInterfaces();
            RegisterWebApiFilters(GlobalConfiguration.Configuration.Filters); 
        }

        public static void RegisterWebApiFilters(HttpFilterCollection filters)
        {
            filters.Add(new HttpAuthorizeAttribute(new ConfigurationUtility()));
            filters.Add(new HttpExceptionAttribute());
            filters.Add(new RequireHttpsAttribute());
            filters.Add(new ValidateModelAttribute());
        }
    }
}
