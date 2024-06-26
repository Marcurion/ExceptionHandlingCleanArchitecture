using Mono.Cecil;

namespace dnet_exception_handling.Tests.Architecture.Rules;

internal sealed class ContainsPublicConstructorParametersRule : ICustomRule
{
    public bool MeetsRule(TypeDefinition type)
    {

        var constructors = type.Methods
            .Where(predicate: method => method.IsPublic && method.IsConstructor);

        return constructors.Any();
    }
}