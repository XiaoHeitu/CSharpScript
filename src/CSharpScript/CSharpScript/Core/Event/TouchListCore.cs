using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class TouchListCore
{
    [JSImport("globalThis.TouchList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.TouchList.prototype.item")]
    public static partial IntPtr ItemTouchList(IntPtr handle, int index);
}
