using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class MouseEventCore
{
    [JSImport("globalThis.MouseEvent.prototype.screenX")]
    public static partial int GetScreenX(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.screenY")]
    public static partial int GetScreenY(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.clientX")]
    public static partial int GetClientX(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.clientY")]
    public static partial int GetClientY(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.ctrlKey")]
    public static partial bool GetCtrlKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.shiftKey")]
    public static partial bool GetShiftKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.altKey")]
    public static partial bool GetAltKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.metaKey")]
    public static partial bool GetMetaKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.button")]
    public static partial int GetButton(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.buttons")]
    public static partial int GetButtons(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.relatedTarget")]
    public static partial IntPtr GetRelatedTarget(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.region")]
    public static partial string? GetRegion(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.initMouseEvent")]
    public static partial void InitMouseEvent(IntPtr handle, string type, bool bubbles, bool cancelable,
        IntPtr view, int detail, int screenX, int screenY, int clientX, int clientY,
        bool ctrlKey, bool altKey, bool shiftKey, bool metaKey, short button, IntPtr relatedTarget);
}
