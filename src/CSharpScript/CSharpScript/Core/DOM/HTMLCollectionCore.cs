using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class HTMLCollectionCore
{
    [JSImport("globalThis.HTMLCollection.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.HTMLCollection.prototype.item")]
    public static partial IntPtr ItemHTMLCollection(IntPtr handle, int index);

    [JSImport("globalThis.HTMLCollection.prototype.namedItem")]
    public static partial IntPtr NamedItem(IntPtr handle, string name);
}
