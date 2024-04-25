using dnet_exception_handling.Application.Common.Composers;
using Microsoft.Extensions.DependencyInjection;
using dnet_exception_handling.Infrastructure.Common.Composer;

namespace dnet_exception_handling.Tests.UnitTests;

public class RegisterDepenciesTests
{
    [TestFixture]
    public class RegisterDependenciesTests
    {
        [Test]
        public void RegisterInfrastructure_WhenCalled_ReturnsServiceCollection()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            var result = services.RegisterInfrastructure();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IServiceCollection>(result);
        }
        
        [Test]
        public void RegisterApplication_WhenCalled_ReturnsServiceCollection()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            var result = services.RegisterApplication();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IServiceCollection>(result);
        }
    }
}