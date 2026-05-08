using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class ProgressEventCore
{
    [JSImport("globalThis.ProgressEvent.prototype.lengthComputable")]
    public static partial bool GetLengthComputable(IntPtr handle);

    [JSImport("globalThis.ProgressEvent.prototype.loaded")]
    public static partial double GetLoaded(IntPtr handle);

    [JSImport("globalThis.ProgressEvent.prototype.total")]
    public static partial double GetTotal(IntPtr handle);

    [JSImport("globalThis.ProgressEvent.prototype.initProgressEvent")]
    public static partial void InitProgressEvent(IntPtr handle, string type, bool bubbles, bool cancelable, bool lengthComputable, double loaded, double total);
}
