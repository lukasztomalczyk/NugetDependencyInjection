using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDependencyInjection.Tests.Testing
{
    [DependencyInjection(Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient)]
    public class TestedTransientService : ITestedTransientService
    {
    }
}
