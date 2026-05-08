using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class EventCore
{
    [JSImport("globalThis.Event.prototype.type")]
    public static partial string GetType(JSObject handle);

    [JSImport("globalThis.Event.prototype.target")]
    public static partial JSObject GetTarget(JSObject handle);

    [JSImport("globalThis.Event.prototype.currentTarget")]
    public static partial JSObject GetCurrentTarget(JSObject handle);

    [JSImport("globalThis.Event.prototype.eventPhase")]
    public static partial int GetEventPhase(JSObject handle);

    [JSImport("globalThis.Event.prototype.bubbles")]
    public static partial bool GetBubbles(JSObject handle);

    [JSImport("globalThis.Event.prototype.cancelable")]
    public static partial bool GetCancelable(JSObject handle);

    [JSImport("globalThis.Event.prototype.defaultPrevented")]
    public static partial bool GetDefaultPrevented(JSObject handle);

    [JSImport("globalThis.Event.prototype.composed")]
    public static partial bool GetComposed(JSObject handle);

    [JSImport("globalThis.Event.prototype.timeStamp")]
    public static partial double GetTimeStamp(JSObject handle);

    [JSImport("globalThis.Event.prototype.isTrusted")]
    public static partial bool GetIsTrusted(JSObject handle);

    [JSImport("globalThis.Event.prototype.stopPropagation")]
    public static partial void StopPropagation(JSObject handle);

    [JSImport("globalThis.Event.prototype.stopImmediatePropagation")]
    public static partial void StopImmediatePropagation(JSObject handle);

    [JSImport("globalThis.Event.prototype.preventDefault")]
    public static partial void PreventDefault(JSObject handle);

    [JSImport("globalThis.Event.prototype.initEvent")]
    public static partial void InitEvent(JSObject handle, string type, bool bubbles, bool cancelable);

    [JSImport("globalThis.Event.prototype.composedPath")]
    public static partial IntPtr ComposedPath(JSObject handle);
}
