using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class ErrorEventCore
{
    [JSImport("globalThis.ErrorEvent.prototype.message")]
    public static partial string GetMessage(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.filename")]
    public static partial string GetFilename(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.lineno")]
    public static partial int GetLineno(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.colno")]
    public static partial int GetColno(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.error")]
    public static partial IntPtr GetError(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.initErrorEvent")]
    public static partial void InitErrorEvent(IntPtr handle, string type, bool bubbles, bool cancelable, string message, string filename, int lineno, int colno, IntPtr error);
}
