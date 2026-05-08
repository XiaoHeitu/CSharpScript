namespace CSharpScript.Tests.TestInfrastructure;

public sealed class BrowserTestResult
{
    public required string Name { get; init; }

    public bool Passed { get; init; }

    public string? Message { get; init; }

    public double DurationMs { get; init; }
}
