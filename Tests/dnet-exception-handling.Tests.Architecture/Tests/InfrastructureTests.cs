using System.Reflection;
using dnet_exception_handling.Domain.Interfaces;

namespace dnet_exception_handling.Tests.Architecture.Tests;

public class InfrastructureTests
{
    [Test]
    public void RepositoryClassShouldImplementIRepository()
    {
        var result = Types
            .InAssembly(assembly: Assembly.Load(assemblyString: "dnet_exception_handling.Infrastructure"))
            .That()
            .ResideInNamespace(name: "dnet_exception_handling.Infrastructure.Repositories")
            .And()
            .AreClasses()
            .Should()
            .ImplementInterface(interfaceType: typeof(IRepository<>))
            .GetResult();

        Assert.True(condition: result.IsSuccessful);
    }

    [Test]
    public void RepositoryClassesShouldBeSealed()
    {
        var result = Types
            .InAssembly(assembly: Assembly.Load(assemblyString: "dnet_exception_handling.Infrastructure"))
            .That()
            .ResideInNamespace(name: "dnet_exception_handling.Infrastructure.Repositories")
            .And()
            .ImplementInterface(interfaceType: typeof(IRepository<>))
            .And()
            .AreClasses()
            .Should()
            .BeSealed()
            .GetResult();

        Assert.True(condition: result.IsSuccessful);
    }
    
    [Test]
    public void RepositoryClassesShouldBeInternal()
    {
        var result = Types
            .InAssembly(assembly: Assembly.Load(assemblyString: "dnet_exception_handling.Infrastructure"))
            .That()
            .ResideInNamespace(name: "dnet_exception_handling.Infrastructure.Repositories")
            .And()
            .ImplementInterface(interfaceType: typeof(IRepository<>))
            .And()
            .AreClasses()
            .Should()
            .NotBePublic()
            .GetResult();

        Assert.True(condition: result.IsSuccessful);
    }
    
    [Test]
    public void RepositoryClassesShouldNotImplementApplicationInterfaces()
    {
        var result = Types
            .InAssembly(assembly: Assembly.Load(assemblyString: "dnet_exception_handling.Infrastructure"))
            .That()
            .ResideInNamespace(name: "dnet_exception_handling.Infrastructure.Repositories")
            .And()
            .AreClasses()
            .ShouldNot()
            .HaveDependencyOn(dependency: "dnet_exception_handling.Application")
            .GetResult();

        Assert.True(condition: result.IsSuccessful);
    }
}