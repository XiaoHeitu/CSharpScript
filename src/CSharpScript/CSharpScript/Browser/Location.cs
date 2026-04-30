namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Location
{
    public static string Href
    {
        get => Window.EvalString("location.href");
        set => Window.EvalString($"location.href='{value}'");
    }

    public static string Protocol => Window.EvalString("location.protocol");

    public static string Host => Window.EvalString("location.host");

    public static string Hostname => Window.EvalString("location.hostname");

    public static string Port => Window.EvalString("location.port");

    public static string Pathname => Window.EvalString("location.pathname");

    public static string Search => Window.EvalString("location.search");

    public static string Hash => Window.EvalString("location.hash");

    public static string Origin => Window.EvalString("location.origin");

    [JSImport("globalThis.location.assign")]
    public static partial void Assign(string url);

    [JSImport("globalThis.location.replace")]
    public static partial void Replace(string url);

    [JSImport("globalThis.location.reload")]
    public static partial void Reload();
}