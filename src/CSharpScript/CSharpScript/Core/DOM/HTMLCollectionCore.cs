using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class HTMLCollectionCore
{
    [JSImport("globalThis.HTMLCollection.prototype.length")]
    public static partial int GetLength(JSObject handle);

    [JSImport("globalThis.HTMLCollection.prototype.item")]
    public static partial JSObject Item(JSObject handle, int index);

    [JSImport("globalThis.HTMLCollection.prototype.namedItem")]
    public static partial JSObject NamedItem(JSObject handle, string name);
}
