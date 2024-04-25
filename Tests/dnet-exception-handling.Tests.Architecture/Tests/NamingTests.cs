using System.Reflection;

namespace dnet_exception_handling.Tests.Architecture.Tests;

public class GlobalTests
{
    [Test]
    public void InterfaceShouldStartWithI()
    {
        var result = Types
            .InCurrentDomain()
            .That()
            .AreInterfaces()
            .Should()
            .HaveNameStartingWith(start: "I", comparer: StringComparison.InvariantCulture)
            .GetResult();

        Assert.True(condition: result.IsSuccessful);
    }
}