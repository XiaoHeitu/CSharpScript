using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class NodeIteratorCore
{
    [JSImport("globalThis.NodeIterator.prototype.root")]
    public static partial JSObject GetRoot(JSObject handle);

    [JSImport("globalThis.NodeIterator.prototype.referenceNode")]
    public static partial JSObject GetReferenceNode(JSObject handle);

    [JSImport("globalThis.NodeIterator.prototype.pointerBeforeReferenceNode")]
    public static partial bool GetPointerBeforeReferenceNode(JSObject handle);

    [JSImport("globalThis.NodeIterator.prototype.nextNode")]
    public static partial JSObject NextNode(JSObject handle);

    [JSImport("globalThis.NodeIterator.prototype.previousNode")]
    public static partial JSObject PreviousNode(JSObject handle);

    [JSImport("globalThis.NodeIterator.prototype.detach")]
    public static partial void Detach(JSObject handle);
}
