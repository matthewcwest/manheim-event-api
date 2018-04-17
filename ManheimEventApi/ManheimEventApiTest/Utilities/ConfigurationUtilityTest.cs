using System.Collections.Specialized;
using System.Configuration.Fakes;
using ManheimEventApi.Utilities;
using Xunit;

namespace ManheimEventApiTest.Utilities
{
    public class ConfigurationUtilityTest : TestBase<ConfigurationUtility>
    {
        public ConfigurationUtilityTest()
        {
            InstantiateClassUnderTest();
        }

        [Fact]
        public void ConfigurationUtility_ApiKey_ReturnsCorrectValueFromConfigurationManager()
        {
            var nvCollection = new NameValueCollection { { "apiKey", "12345" } };

            ShimConfigurationManager.AppSettingsGet = () => nvCollection;

            var prop = ClassUnderTest.GetType().GetProperty("ApiKey")?.GetValue(ClassUnderTest);

            Assert.Equal(prop, nvCollection.Get(0));
        }
    }
}
