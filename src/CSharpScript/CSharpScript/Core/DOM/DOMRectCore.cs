using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class DOMRectCore
{
    [JSImport("globalThis.DOMRect.prototype.x")]
    public static partial double GetX(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.y")]
    public static partial double GetY(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.width")]
    public static partial double GetWidth(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.height")]
    public static partial double GetHeight(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.top")]
    public static partial double GetTop(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.right")]
    public static partial double GetRight(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.bottom")]
    public static partial double GetBottom(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.left")]
    public static partial double GetLeft(IntPtr handle);
}
