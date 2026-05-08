using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class DOMRectCore
{
    [JSImport("globalThis.DOMRect.prototype.x")]
    public static partial double GetX(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.y")]
    public static partial double GetY(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.width")]
    public static partial double GetWidth(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.height")]
    public static partial double GetHeight(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.top")]
    public static partial double GetTop(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.right")]
    public static partial double GetRight(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.bottom")]
    public static partial double GetBottom(JSObject handle);

    [JSImport("globalThis.DOMRect.prototype.left")]
    public static partial double GetLeft(JSObject handle);
}
