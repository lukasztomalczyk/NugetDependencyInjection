namespace PatDependencyInjection.Tests.Testing
{
    [DependencyInjection(Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton)]
    public class TestedSingeltonService : ITestedSingeltonService
    {
        public string Test { get; set; } = "Ok";
        public string GetTestValue()
        {
            return Test;
        }
    }
}
