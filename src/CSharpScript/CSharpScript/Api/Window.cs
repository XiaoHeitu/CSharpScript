using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using CSharpScript.Storage;
using CSharpScript.Core.Api;

namespace CSharpScript.Api;

[SupportedOSPlatform("browser")]
public partial class Window
{
    private static Window? _instance;
    private static readonly object _lock = new();

    public static Window Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Window();
                }
            }
            return _instance;
        }
    }

    private Window() { }

    public Document Document => Document.Instance;

    public Navigator Navigator => Navigator.Instance;

    public History History => History.Instance;

    public Location Location => Location.Instance;

    public Console Console => Console.Instance;

    public LocalStorage LocalStorage => LocalStorage.Instance;

    public SessionStorage SessionStorage => SessionStorage.Instance;

    public static void Alert(string message) => WindowCore.Alert(message);

    public static bool Confirm(string message) => WindowCore.Confirm(message);

    public static string? Prompt(string message, string? defaultValue = null) =>
        WindowCore.Prompt(message, defaultValue);

    public static void ClearTimeout(int id) => WindowCore.ClearTimeout(id);

    public static void ClearInterval(int id) => WindowCore.ClearInterval(id);

    public static string? Open(string? url = null, string? target = null, string? features = null) =>
        WindowCore.Open(url, target, features);

    public static void Close() => WindowCore.Close();

    public static void Print() => WindowCore.Print();

    public static void ScrollTo(double x, double y) => WindowCore.ScrollTo(x, y);

    public static void Scroll(double x, double y) => WindowCore.Scroll(x, y);

    public static void ScrollBy(double x, double y) => WindowCore.ScrollBy(x, y);

    public static void Focus() => WindowCore.Focus();

    public static void Blur() => WindowCore.Blur();

    public static int InnerWidth => WindowCore.EvalInt("window.innerWidth");

    public static int InnerHeight => WindowCore.EvalInt("window.innerHeight");

    public static int OuterWidth => WindowCore.EvalInt("window.outerWidth");

    public static int OuterHeight => WindowCore.EvalInt("window.outerHeight");

    public static int ScreenX => WindowCore.EvalInt("window.screenX");

    public static int ScreenY => WindowCore.EvalInt("window.screenY");

    public static double DevicePixelRatio => WindowCore.EvalDouble("window.devicePixelRatio");

    public static string Origin => WindowCore.EvalString("window.origin");

    public static bool Closed => WindowCore.EvalBool("window.closed");

    public static string Name
    {
        get => WindowCore.EvalString("window.name");
        set => WindowCore.EvalString($"window.name='{value}'");
    }

    public static string Status
    {
        get => WindowCore.EvalString("window.status");
        set => WindowCore.EvalString($"window.status='{value}'");
    }

    public static void ResizeTo(int width, int height) => WindowCore.ResizeTo(width, height);

    public static void ResizeBy(int width, int height) => WindowCore.ResizeBy(width, height);

    public static void MoveTo(int x, int y) => WindowCore.MoveTo(x, y);

    public static void MoveBy(int x, int y) => WindowCore.MoveBy(x, y);

    public static string EvalString(string code) => WindowCore.EvalString(code);

    public static int EvalInt(string code) => WindowCore.EvalInt(code);

    public static bool EvalBool(string code) => WindowCore.EvalBool(code);

    public static double EvalDouble(string code) => WindowCore.EvalDouble(code);
}
