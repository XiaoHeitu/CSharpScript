namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Navigator
{
    [JSImport("globalThis.navigator.userAgent")]
    public static partial string GetUserAgent();

    [JSImport("globalThis.navigator.appName")]
    public static partial string GetAppName();

    [JSImport("globalThis.navigator.appVersion")]
    public static partial string GetAppVersion();

    [JSImport("globalThis.navigator.appCodeName")]
    public static partial string GetAppCodeName();

    [JSImport("globalThis.navigator.platform")]
    public static partial string GetPlatform();

    [JSImport("globalThis.navigator.product")]
    public static partial string GetProduct();

    [JSImport("globalThis.navigator.vendor")]
    public static partial string GetVendor();

    [JSImport("globalThis.navigator.language")]
    public static partial string GetLanguage();

    [JSImport("globalThis.navigator.languages")]
    public static partial string GetLanguages();

    [JSImport("globalThis.navigator.onLine")]
    public static partial bool GetOnLine();

    [JSImport("globalThis.navigator.cookieEnabled")]
    public static partial bool GetCookieEnabled();

    [JSImport("globalThis.navigator.javaEnabled")]
    public static partial bool JavaEnabled();

    [JSImport("globalThis.navigator.maxTouchPoints")]
    public static partial int GetMaxTouchPoints();

    [JSImport("globalThis.navigator.hardwareConcurrency")]
    public static partial int GetHardwareConcurrency();
}