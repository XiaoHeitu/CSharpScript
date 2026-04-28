namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Window
{
    [JSImport("globalThis.window.alert")]
    public static partial void Alert(string message);

    [JSImport("globalThis.window.confirm")]
    public static partial bool Confirm(string message);

    [JSImport("globalThis.window.prompt")]
    public static partial string? Prompt(string message, string? defaultValue = null);

    [JSImport("globalThis.window.clearTimeout")]
    public static partial void ClearTimeout(int id);

    [JSImport("globalThis.window.clearInterval")]
    public static partial void ClearInterval(int id);

    [JSImport("globalThis.window.open")]
    public static partial string? Open(string? url = null, string? target = null, string? features = null);

    [JSImport("globalThis.window.close")]
    public static partial void Close();

    [JSImport("globalThis.window.print")]
    public static partial void Print();

    [JSImport("globalThis.window.scrollTo")]
    public static partial void ScrollTo(double x, double y);

    [JSImport("globalThis.window.scroll")]
    public static partial void Scroll(double x, double y);

    [JSImport("globalThis.window.scrollBy")]
    public static partial void ScrollBy(double x, double y);

    [JSImport("globalThis.window.focus")]
    public static partial void Focus();

    [JSImport("globalThis.window.blur")]
    public static partial void Blur();

    public static int InnerWidth => Reflect.EvalInt("window.innerWidth");

    public static int InnerHeight => Reflect.EvalInt("window.innerHeight");

    public static int OuterWidth => Reflect.EvalInt("window.outerWidth");

    public static int OuterHeight => Reflect.EvalInt("window.outerHeight");

    public static int ScreenX => Reflect.EvalInt("window.screenX");

    public static int ScreenY => Reflect.EvalInt("window.screenY");

    public static double DevicePixelRatio => Reflect.EvalDouble("window.devicePixelRatio");

    public static string Origin => Reflect.EvalString("window.origin");

    public static bool Closed => Reflect.EvalBool("window.closed");

    public static string Name
    {
        get => Reflect.EvalString("window.name");
        set => Reflect.EvalString($"window.name='{value}'");
    }

    public static string Status
    {
        get => Reflect.EvalString("window.status");
        set => Reflect.EvalString($"window.status='{value}'");
    }

    [JSImport("globalThis.window.resizeTo")]
    public static partial void ResizeTo(int width, int height);

    [JSImport("globalThis.window.resizeBy")]
    public static partial void ResizeBy(int width, int height);

    [JSImport("globalThis.window.moveTo")]
    public static partial void MoveTo(int x, int y);

    [JSImport("globalThis.window.moveBy")]
    public static partial void MoveBy(int x, int y);
}
