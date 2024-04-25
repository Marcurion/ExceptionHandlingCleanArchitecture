using System.Reflection;

namespace dnet_exception_handling.Tests.Architecture.Tests;
public class ApplicationTests
{
    [Test]
    public void ProjectShouldNotHaveDependenciesOnInfrastructureProject()
    {
        var result = Types
            .InAssembly(assembly: Assembly.Load(assemblyString: "dnet_exception_handling.Application"))
            .That()
            .ResideInNamespace(name: "dnet_exception_handling.Application")
            .ShouldNot()
            .HaveDependencyOn(dependency: "dnet_exception_handling.Infrastructure")
            .GetResult();
        Assert.True(condition: result.IsSuccessful);
    }

}
