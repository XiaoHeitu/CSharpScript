using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class NodeListCore
{
    [JSImport("globalThis.NodeList.prototype.length")]
    public static partial int GetLength(JSObject handle);

    [JSImport("globalThis.NodeList.prototype.item")]
    public static partial JSObject ItemNodeList(JSObject handle, int index);

    [JSImport("globalThis.NodeList.prototype.forEach")]
    public static partial void ForEach(JSObject handle, JSObject callback);
}
