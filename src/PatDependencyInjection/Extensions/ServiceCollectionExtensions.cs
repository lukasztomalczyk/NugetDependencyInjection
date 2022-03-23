using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Reflection;

namespace PatDependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPatDependencyInjection(this IServiceCollection services, 
            Assembly assembly = null)
        {
            RegisterByLifetime(ServiceLifetime.Scoped, services, assembly);
            RegisterByLifetime(ServiceLifetime.Singleton, services, assembly);
            RegisterByLifetime(ServiceLifetime.Transient, services, assembly);

            return services;
        }

        private static void RegisterByLifetime(ServiceLifetime lifetime, IServiceCollection services,
            Assembly assembly = null)
        {
            services.Scan(scan => scan
                .FromAssemblies(assembly ?? Assembly.GetCallingAssembly())
                .AddClasses(@class => @class.WithAttribute<DependencyInjectionAttribute>(x => x.Lifetime == lifetime))
                .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                .AsImplementedInterfaces()
                .WithLifetime(lifetime));
        }
    }
}
