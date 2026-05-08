using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class TouchCore
{
    [JSImport("globalThis.Touch.prototype.identifier")]
    public static partial int GetIdentifier(JSObject handle);

    [JSImport("globalThis.Touch.prototype.target")]
    public static partial JSObject GetTarget(JSObject handle);

    [JSImport("globalThis.Touch.prototype.clientX")]
    public static partial double GetClientX(JSObject handle);

    [JSImport("globalThis.Touch.prototype.clientY")]
    public static partial double GetClientY(JSObject handle);

    [JSImport("globalThis.Touch.prototype.screenX")]
    public static partial double GetScreenX(JSObject handle);

    [JSImport("globalThis.Touch.prototype.screenY")]
    public static partial double GetScreenY(JSObject handle);

    [JSImport("globalThis.Touch.prototype.pageX")]
    public static partial double GetPageX(JSObject handle);

    [JSImport("globalThis.Touch.prototype.pageY")]
    public static partial double GetPageY(JSObject handle);

    [JSImport("globalThis.Touch.prototype.radiusX")]
    public static partial double GetRadiusX(JSObject handle);

    [JSImport("globalThis.Touch.prototype.radiusY")]
    public static partial double GetRadiusY(JSObject handle);

    [JSImport("globalThis.Touch.prototype.rotationAngle")]
    public static partial double GetRotationAngle(JSObject handle);

    [JSImport("globalThis.Touch.prototype.force")]
    public static partial double GetForce(JSObject handle);
}
