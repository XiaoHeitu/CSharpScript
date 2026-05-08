using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.Api;

namespace CSharpScript.Api;

[SupportedOSPlatform("browser")]
public partial class Navigator
{
    private static Navigator? _instance;
    private static readonly object _lock = new();
    private static JSObject NavigatorObject => JSHost.GlobalThis.GetPropertyAsJSObject("navigator")!;

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

    public string UserAgent => NavigatorObject.GetPropertyAsString("userAgent")!;

    public string AppName => NavigatorObject.GetPropertyAsString("appName")!;

    public string AppVersion => NavigatorObject.GetPropertyAsString("appVersion")!;

    public string AppCodeName => NavigatorObject.GetPropertyAsString("appCodeName")!;

    public string Platform => NavigatorObject.GetPropertyAsString("platform")!;

    public string Product => NavigatorObject.GetPropertyAsString("product")!;

    public string Vendor => NavigatorObject.GetPropertyAsString("vendor")!;

    public string Language => NavigatorObject.GetPropertyAsString("language")!;

    public string Languages => NavigatorObject.GetPropertyAsString("languages")!;

    public bool OnLine => NavigatorObject.GetPropertyAsBoolean("onLine");

    public bool CookieEnabled => NavigatorObject.GetPropertyAsBoolean("cookieEnabled");

    public bool JavaEnabled() => NavigatorCore.JavaEnabled();

    public int MaxTouchPoints => NavigatorObject.GetPropertyAsInt32("maxTouchPoints");

    public int HardwareConcurrency => NavigatorObject.GetPropertyAsInt32("hardwareConcurrency");
}
