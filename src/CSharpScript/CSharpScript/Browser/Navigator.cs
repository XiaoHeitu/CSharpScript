namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Navigator
{
    public static string UserAgent => Reflect.EvalString("navigator.userAgent");

    public static string AppName => Reflect.EvalString("navigator.appName");

    public static string AppVersion => Reflect.EvalString("navigator.appVersion");

    public static string AppCodeName => Reflect.EvalString("navigator.appCodeName");

    public static string Platform => Reflect.EvalString("navigator.platform");

    public static string Product => Reflect.EvalString("navigator.product");

    public static string Vendor => Reflect.EvalString("navigator.vendor");

    public static string Language => Reflect.EvalString("navigator.language");

    public static string Languages => Reflect.EvalString("navigator.languages");

    public static bool OnLine => Reflect.EvalBool("navigator.onLine");

    public static bool CookieEnabled => Reflect.EvalBool("navigator.cookieEnabled");

    [JSImport("globalThis.navigator.javaEnabled")]
    public static partial bool JavaEnabled();

    [JSImport("globalThis.navigator.maxTouchPoints")]
    public static partial int GetMaxTouchPoints();

    [JSImport("globalThis.navigator.hardwareConcurrency")]
    public static partial int GetHardwareConcurrency();

    public static int MaxTouchPoints => GetMaxTouchPoints();
    public static int HardwareConcurrency => GetHardwareConcurrency();
}