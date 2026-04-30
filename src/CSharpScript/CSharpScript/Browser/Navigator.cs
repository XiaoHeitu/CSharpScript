namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Navigator
{
    public static string UserAgent => Window.EvalString("navigator.userAgent");

    public static string AppName => Window.EvalString("navigator.appName");

    public static string AppVersion => Window.EvalString("navigator.appVersion");

    public static string AppCodeName => Window.EvalString("navigator.appCodeName");

    public static string Platform => Window.EvalString("navigator.platform");

    public static string Product => Window.EvalString("navigator.product");

    public static string Vendor => Window.EvalString("navigator.vendor");

    public static string Language => Window.EvalString("navigator.language");

    public static string Languages => Window.EvalString("navigator.languages");

    public static bool OnLine => Window.EvalBool("navigator.onLine");

    public static bool CookieEnabled => Window.EvalBool("navigator.cookieEnabled");

    public static bool JavaEnabled() => Window.EvalBool("navigator.javaEnabled()");

    public static int MaxTouchPoints => Window.EvalInt("navigator.maxTouchPoints");

    public static int HardwareConcurrency => Window.EvalInt("navigator.hardwareConcurrency");
}