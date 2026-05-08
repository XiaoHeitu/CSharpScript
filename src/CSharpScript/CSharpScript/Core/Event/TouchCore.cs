using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class TouchCore
{
    [JSImport("globalThis.Touch.prototype.identifier")]
    public static partial int GetIdentifier(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.target")]
    public static partial IntPtr GetTarget(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.clientX")]
    public static partial double GetClientX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.clientY")]
    public static partial double GetClientY(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.screenX")]
    public static partial double GetScreenX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.screenY")]
    public static partial double GetScreenY(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.pageX")]
    public static partial double GetPageX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.pageY")]
    public static partial double GetPageY(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.radiusX")]
    public static partial double GetRadiusX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.radiusY")]
    public static partial double GetRadiusY(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.rotationAngle")]
    public static partial double GetRotationAngle(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.force")]
    public static partial double GetForce(IntPtr handle);
}