using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class KeyboardEventCore
{
    [JSImport("globalThis.KeyboardEvent.prototype.key")]
    public static partial string GetKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.code")]
    public static partial string GetCode(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.ctrlKey")]
    public static partial bool GetCtrlKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.shiftKey")]
    public static partial bool GetShiftKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.altKey")]
    public static partial bool GetAltKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.metaKey")]
    public static partial bool GetMetaKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.repeat")]
    public static partial bool GetRepeat(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.isComposing")]
    public static partial bool GetIsComposing(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.location")]
    public static partial int GetLocation(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.initKeyboardEvent")]
    public static partial void InitKeyboardEvent(IntPtr handle, string type, bool bubbles, bool cancelable,
        IntPtr view, string key, int location, bool ctrlKey, bool shiftKey, bool altKey, bool metaKey);
}
