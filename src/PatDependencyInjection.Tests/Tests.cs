using Microsoft.Extensions.DependencyInjection;
using PatDependencyInjection.Extensions;
using PatDependencyInjection.Tests.Testing;
using System.Reflection;
using Xunit;

namespace PatDependencyInjection.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Scoped()
        {
            var serviceProvider = new ServiceCollection()
                .AddPatDependencyInjection(typeof(TestedScopedService).Assembly)
                .BuildServiceProvider();

            var result = serviceProvider
                .GetService<ITestedScopedService>();

            Assert.NotNull(result);
        }

        [Fact]
        public void Transient()
        {
            var serviceProvider = new ServiceCollection()
                .AddPatDependencyInjection(typeof(TestedTransientService).Assembly)
                .BuildServiceProvider();

            var result = serviceProvider
                .GetService<ITestedTransientService>();

            Assert.NotNull(result);
        }

        [Fact]
        public void Singelton()
        {
            var serviceProvider = new ServiceCollection()
                .AddPatDependencyInjection(typeof(TestedSingeltonService).Assembly)
                .BuildServiceProvider();

            var result = serviceProvider
                .GetService<ITestedSingeltonService>();

            Assert.NotNull(result);
        }
    }
}
