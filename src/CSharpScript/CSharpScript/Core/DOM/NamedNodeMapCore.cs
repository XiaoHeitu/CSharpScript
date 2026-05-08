using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class NamedNodeMapCore
{
    [JSImport("globalThis.NamedNodeMap.prototype.length")]
    public static partial int GetLength(JSObject handle);

    [JSImport("globalThis.NamedNodeMap.prototype.item")]
    public static partial JSObject ItemNamedNodeMap(JSObject handle, int index);

    [JSImport("globalThis.NamedNodeMap.prototype.getNamedItem")]
    public static partial JSObject GetNamedItem(JSObject handle, string name);

    [JSImport("globalThis.NamedNodeMap.prototype.setNamedItem")]
    public static partial JSObject SetNamedItem(JSObject handle, JSObject node);

    [JSImport("globalThis.NamedNodeMap.prototype.removeNamedItem")]
    public static partial JSObject RemoveNamedItem(JSObject handle, string name);

    [JSImport("globalThis.NamedNodeMap.prototype.getNamedItemNS")]
    public static partial JSObject GetNamedItemNS(JSObject handle, string? ns, string localName);

    [JSImport("globalThis.NamedNodeMap.prototype.setNamedItemNS")]
    public static partial JSObject SetNamedItemNS(JSObject handle, JSObject node);

    [JSImport("globalThis.NamedNodeMap.prototype.removeNamedItemNS")]
    public static partial JSObject RemoveNamedItemNS(JSObject handle, string? ns, string localName);
}
