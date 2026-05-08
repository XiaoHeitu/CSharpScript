using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class TouchListCore
{
    [JSImport("globalThis.TouchList.prototype.length")]
    public static partial int GetLength(JSObject handle);

    [JSImport("globalThis.TouchList.prototype.item")]
    public static partial JSObject Item(JSObject handle, int index);
}
