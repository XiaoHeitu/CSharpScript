namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Console
{
    [JSImport("globalThis.console.log")]
    public static partial void Log(string message);

    [JSImport("globalThis.console.info")]
    public static partial void Info(string message);

    [JSImport("globalThis.console.warn")]
    public static partial void Warn(string message);

    [JSImport("globalThis.console.error")]
    public static partial void Error(string message);

    [JSImport("globalThis.console.debug")]
    public static partial void Debug(string message);

    [JSImport("globalThis.console.clear")]
    public static partial void Clear();

    [JSImport("globalThis.console.trace")]
    public static partial void Trace(string message);

    [JSImport("globalThis.console.assert")]
    public static partial void Assert(bool condition, string message);

    [JSImport("globalThis.console.count")]
    public static partial void Count(string? label = null);

    [JSImport("globalThis.console.countReset")]
    public static partial void CountReset(string? label = null);

    [JSImport("globalThis.console.group")]
    public static partial void Group(string? label = null);

    [JSImport("globalThis.console.groupEnd")]
    public static partial void GroupEnd();

    [JSImport("globalThis.console.groupCollapsed")]
    public static partial void GroupCollapsed(string? label = null);

    [JSImport("globalThis.console.time")]
    public static partial void Time(string? label = null);

    [JSImport("globalThis.console.timeEnd")]
    public static partial void TimeEnd(string? label = null);

    [JSImport("globalThis.console.timeLog")]
    public static partial void TimeLog(string? label = null);
}