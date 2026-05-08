using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class NodeIteratorCore
{
    [JSImport("globalThis.NodeIterator.prototype.root")]
    public static partial IntPtr GetRoot(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.referenceNode")]
    public static partial IntPtr GetReferenceNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.pointerBeforeReferenceNode")]
    public static partial bool GetPointerBeforeReferenceNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.nextNode")]
    public static partial IntPtr NextNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.previousNode")]
    public static partial IntPtr PreviousNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.detach")]
    public static partial void Detach(IntPtr handle);
}
