namespace CSharpScript.Tests.TestInfrastructure;

[CollectionDefinition(Name, DisableParallelization = true)]
public sealed class BrowserTestCollection
{
    public const string Name = "browser-tests";
}
