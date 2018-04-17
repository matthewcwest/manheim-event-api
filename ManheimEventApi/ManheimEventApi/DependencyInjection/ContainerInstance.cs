using System;
using System.Linq;
using System.Web.Http;
using ManheimEventApi.Logging;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;

namespace ManheimEventApi.DependencyInjection
{
    // This class provides a static instance of the Simple Injector container
    // and it registers all interfaces as transient or singleton
    public static class ContainerInstance
    {
        private static Container _container;

        public static Container Container => _container ?? (_container = new Container());

        public static void RegisterInterfaces()
        {
            Logger.Info("Registering interfaces to DI container");

            try
            {
                RegisterScopedClasses();

                RegisterWebApiControllers();
            }
            catch (Exception ex)
            {
                Logger.Error("An error occurred while attempting to update register interfaces.");
                Logger.Error($"Class: { nameof(ContainerInstance)}, Method: {nameof(RegisterInterfaces) }");
                Logger.Error(ex);
            }
        }

        private static void RegisterScopedClasses()
        {
            Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            RegisterGenericInterfaces();
            RegisterNonGenericInterfaces();
        }

        private static void RegisterWebApiControllers()
        {
            Container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(Container);
        }

        private static void RegisterGenericInterfaces()
        {
            var assembly = typeof(ContainerInstance).Assembly;

            var genericRegistrations =
               from type in assembly.GetExportedTypes()
               where type.GetInterfaces().Any(x => x.Assembly == assembly)
               && type.IsGenericType
               select new { Service = type.GetInterfaces().First(), Implementation = type };

            foreach (var reg in genericRegistrations)
            {
                Container.Register(reg.Service.GetGenericTypeDefinition(), reg.Implementation.GetGenericTypeDefinition(), Lifestyle.Scoped);
            }
        }

        private static void RegisterNonGenericInterfaces()
        {
            var assembly = typeof(ContainerInstance).Assembly;

            var nonGenericRegistrations =
               from type in assembly.GetExportedTypes()
               where type.GetInterfaces().Any(x => x.Assembly == assembly)
               && !type.IsGenericType
               select new { Service = type.GetInterfaces().First(), Implementation = type };

            foreach (var reg in nonGenericRegistrations)
            {
                Container.Register(reg.Service, reg.Implementation, Lifestyle.Scoped);
            }
        }
    }
}