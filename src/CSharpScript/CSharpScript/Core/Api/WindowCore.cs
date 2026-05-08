using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Api;

[SupportedOSPlatform("browser")]
internal partial class WindowCore
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

    [JSImport("globalThis.window.resizeTo")]
    public static partial void ResizeTo(int width, int height);

    [JSImport("globalThis.window.resizeBy")]
    public static partial void ResizeBy(int width, int height);

    [JSImport("globalThis.window.moveTo")]
    public static partial void MoveTo(int x, int y);

    [JSImport("globalThis.window.moveBy")]
    public static partial void MoveBy(int x, int y);

    [JSImport("globalThis.eval")]
    public static partial string EvalString(string code);

    [JSImport("globalThis.eval")]
    public static partial int EvalInt(string code);

    [JSImport("globalThis.eval")]
    public static partial bool EvalBool(string code);

    [JSImport("globalThis.eval")]
    public static partial double EvalDouble(string code);
}