namespace ManheimEventApi.Utilities
{
    public interface IConfigurationUtility
    {
        string ApiKey { get; }
        string DBConnectionString { get; }
    }
}