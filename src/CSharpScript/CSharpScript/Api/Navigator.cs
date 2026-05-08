using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Api;

[SupportedOSPlatform("browser")]
public partial class Navigator
{
    private static Navigator? _instance;
    private static readonly object _lock = new();

    public static Navigator Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Navigator();
                }
            }
            return _instance;
        }
    }

    private Navigator() { }

    public string UserAgent => Window.EvalString("navigator.userAgent");

    public string AppName => Window.EvalString("navigator.appName");

    public string AppVersion => Window.EvalString("navigator.appVersion");

    public string AppCodeName => Window.EvalString("navigator.appCodeName");

    public string Platform => Window.EvalString("navigator.platform");

    public string Product => Window.EvalString("navigator.product");

    public string Vendor => Window.EvalString("navigator.vendor");

    public string Language => Window.EvalString("navigator.language");

    public string Languages => Window.EvalString("navigator.languages");

    public bool OnLine => Window.EvalBool("navigator.onLine");

    public bool CookieEnabled => Window.EvalBool("navigator.cookieEnabled");

    public bool JavaEnabled() => Window.EvalBool("navigator.javaEnabled()");

    public int MaxTouchPoints => Window.EvalInt("navigator.maxTouchPoints");

    public int HardwareConcurrency => Window.EvalInt("navigator.hardwareConcurrency");
}