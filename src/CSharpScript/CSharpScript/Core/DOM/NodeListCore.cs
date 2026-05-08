using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class NodeListCore
{
    [JSImport("globalThis.NodeList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.NodeList.prototype.item")]
    public static partial IntPtr ItemNodeList(IntPtr handle, int index);

    [JSImport("globalThis.NodeList.prototype.forEach")]
    public static partial void ForEach(IntPtr handle, IntPtr callback);
}