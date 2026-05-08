namespace CSharpScript.Tests.TestInfrastructure;

internal static class PublicApiExclusions
{
    public static IReadOnlySet<string> ExcludedTypeNames { get; } = new HashSet<string>
    {
        "CSharpScript.CSharpScriptTest",
        "CSharpScript.WindowTest",
        "CSharpScript.DocumentTest",
    };
}
