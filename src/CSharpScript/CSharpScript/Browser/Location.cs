namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Location
{
    public static string Href
    {
        get => Reflect.EvalString("location.href");
        set => Reflect.EvalString($"location.href='{value}'");
    }

    public static string Protocol => Reflect.EvalString("location.protocol");

    public static string Host => Reflect.EvalString("location.host");

    public static string Hostname => Reflect.EvalString("location.hostname");

    public static string Port => Reflect.EvalString("location.port");

    public static string Pathname => Reflect.EvalString("location.pathname");

    public static string Search => Reflect.EvalString("location.search");

    public static string Hash => Reflect.EvalString("location.hash");

    public static string Origin => Reflect.EvalString("location.origin");

    [JSImport("globalThis.location.assign")]
    public static partial void Assign(string url);

    [JSImport("globalThis.location.replace")]
    public static partial void Replace(string url);

    [JSImport("globalThis.location.reload")]
    public static partial void Reload();
}