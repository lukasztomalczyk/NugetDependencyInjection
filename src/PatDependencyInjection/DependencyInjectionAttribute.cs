using Microsoft.Extensions.DependencyInjection;
using System;

namespace PatDependencyInjection
{
    public class DependencyInjectionAttribute : Attribute
    {
        public readonly ServiceLifetime Lifetime;

        public DependencyInjectionAttribute(ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            Lifetime = lifetime;
        }
    }
}
