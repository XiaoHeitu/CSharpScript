using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class TreeWalkerCore
{
    [JSImport("globalThis.TreeWalker.prototype.root")]
    public static partial JSObject GetRoot(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.currentNode")]
    public static partial JSObject GetCurrentNode(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.currentNode")]
    public static partial void SetCurrentNode(JSObject handle, JSObject value);

    [JSImport("globalThis.TreeWalker.prototype.nextNode")]
    public static partial JSObject NextNode(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.previousNode")]
    public static partial JSObject PreviousNode(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.nextSibling")]
    public static partial JSObject NextSibling(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.previousSibling")]
    public static partial JSObject PreviousSibling(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.parentNode")]
    public static partial JSObject ParentNode(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.firstChild")]
    public static partial JSObject FirstChild(JSObject handle);

    [JSImport("globalThis.TreeWalker.prototype.lastChild")]
    public static partial JSObject LastChild(JSObject handle);
}
