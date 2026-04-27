namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Location
{
    [JSImport("globalThis.location.href")]
    public static partial string GetHref();

    [JSImport("globalThis.location.href")]
    public static partial void SetHref(string value);

    [JSImport("globalThis.location.protocol")]
    public static partial string GetProtocol();

    [JSImport("globalThis.location.host")]
    public static partial string GetHost();

    [JSImport("globalThis.location.hostname")]
    public static partial string GetHostname();

    [JSImport("globalThis.location.port")]
    public static partial string GetPort();

    [JSImport("globalThis.location.pathname")]
    public static partial string GetPathname();

    [JSImport("globalThis.location.search")]
    public static partial string GetSearch();

    [JSImport("globalThis.location.hash")]
    public static partial string GetHash();

    [JSImport("globalThis.location.origin")]
    public static partial string GetOrigin();

    [JSImport("globalThis.location.assign")]
    public static partial void Assign(string url);

    [JSImport("globalThis.location.replace")]
    public static partial void Replace(string url);

    [JSImport("globalThis.location.reload")]
    public static partial void Reload();
}