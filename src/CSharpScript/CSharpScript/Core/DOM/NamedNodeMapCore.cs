using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class NamedNodeMapCore
{
    [JSImport("globalThis.NamedNodeMap.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.NamedNodeMap.prototype.item")]
    public static partial IntPtr ItemNamedNodeMap(IntPtr handle, int index);

    [JSImport("globalThis.NamedNodeMap.prototype.getNamedItem")]
    public static partial IntPtr GetNamedItem(IntPtr handle, string name);

    [JSImport("globalThis.NamedNodeMap.prototype.setNamedItem")]
    public static partial IntPtr SetNamedItem(IntPtr handle, IntPtr node);

    [JSImport("globalThis.NamedNodeMap.prototype.removeNamedItem")]
    public static partial IntPtr RemoveNamedItem(IntPtr handle, string name);

    [JSImport("globalThis.NamedNodeMap.prototype.getNamedItemNS")]
    public static partial IntPtr GetNamedItemNS(IntPtr handle, string? ns, string localName);

    [JSImport("globalThis.NamedNodeMap.prototype.setNamedItemNS")]
    public static partial IntPtr SetNamedItemNS(IntPtr handle, IntPtr node);

    [JSImport("globalThis.NamedNodeMap.prototype.removeNamedItemNS")]
    public static partial IntPtr RemoveNamedItemNS(IntPtr handle, string? ns, string localName);
}