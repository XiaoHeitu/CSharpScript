using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class TouchEventCore
{
    [JSImport("globalThis.TouchEvent.prototype.touches")]
    public static partial IntPtr GetTouches(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.targetTouches")]
    public static partial IntPtr GetTargetTouches(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.changedTouches")]
    public static partial IntPtr GetChangedTouches(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.ctrlKey")]
    public static partial bool GetCtrlKey(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.shiftKey")]
    public static partial bool GetShiftKey(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.altKey")]
    public static partial bool GetAltKey(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.metaKey")]
    public static partial bool GetMetaKey(IntPtr handle);
}
