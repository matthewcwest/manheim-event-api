using System.Configuration;

namespace ManheimEventApi.Utilities
{
    public class ConfigurationUtility : IConfigurationUtility
    {
        public string DBConnectionString => ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public string ApiKey => ConfigurationManager.AppSettings["apiKey"];
    }
}
