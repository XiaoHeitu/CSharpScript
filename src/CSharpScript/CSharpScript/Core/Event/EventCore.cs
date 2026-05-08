using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class EventCore
{
    [JSImport("globalThis.Event.prototype.type")]
    public static partial string GetType(IntPtr handle);

    [JSImport("globalThis.Event.prototype.target")]
    public static partial IntPtr GetTarget(IntPtr handle);

    [JSImport("globalThis.Event.prototype.currentTarget")]
    public static partial IntPtr GetCurrentTarget(IntPtr handle);

    [JSImport("globalThis.Event.prototype.eventPhase")]
    public static partial int GetEventPhase(IntPtr handle);

    [JSImport("globalThis.Event.prototype.bubbles")]
    public static partial bool GetBubbles(IntPtr handle);

    [JSImport("globalThis.Event.prototype.cancelable")]
    public static partial bool GetCancelable(IntPtr handle);

    [JSImport("globalThis.Event.prototype.defaultPrevented")]
    public static partial bool GetDefaultPrevented(IntPtr handle);

    [JSImport("globalThis.Event.prototype.composed")]
    public static partial bool GetComposed(IntPtr handle);

    [JSImport("globalThis.Event.prototype.timeStamp")]
    public static partial double GetTimeStamp(IntPtr handle);

    [JSImport("globalThis.Event.prototype.isTrusted")]
    public static partial bool GetIsTrusted(IntPtr handle);

    [JSImport("globalThis.Event.prototype.stopPropagation")]
    public static partial void StopPropagation(IntPtr handle);

    [JSImport("globalThis.Event.prototype.stopImmediatePropagation")]
    public static partial void StopImmediatePropagation(IntPtr handle);

    [JSImport("globalThis.Event.prototype.preventDefault")]
    public static partial void PreventDefault(IntPtr handle);

    [JSImport("globalThis.Event.prototype.initEvent")]
    public static partial void InitEvent(IntPtr handle, string type, bool bubbles, bool cancelable);

    [JSImport("globalThis.Event.prototype.composedPath")]
    public static partial IntPtr ComposedPath(IntPtr handle);
}
