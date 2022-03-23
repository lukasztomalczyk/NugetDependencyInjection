namespace PatDependencyInjection.Tests.Testing
{
    public interface ITestedSingeltonService
    {
        string Test { get; set; }

        string GetTestValue();
    }
}