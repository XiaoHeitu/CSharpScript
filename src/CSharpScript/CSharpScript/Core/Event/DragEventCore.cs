using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class DragEventCore
{
    [JSImport("globalThis.DragEvent.prototype.dataTransfer")]
    public static partial IntPtr GetDataTransfer(IntPtr handle);
}