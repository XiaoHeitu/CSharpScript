using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class TreeWalkerCore
{
    [JSImport("globalThis.TreeWalker.prototype.root")]
    public static partial IntPtr GetRoot(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.currentNode")]
    public static partial IntPtr GetCurrentNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.currentNode")]
    public static partial void SetCurrentNode(IntPtr handle, IntPtr value);

    [JSImport("globalThis.TreeWalker.prototype.nextNode")]
    public static partial IntPtr NextNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.previousNode")]
    public static partial IntPtr PreviousNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.nextSibling")]
    public static partial IntPtr NextSibling(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.previousSibling")]
    public static partial IntPtr PreviousSibling(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.parentNode")]
    public static partial IntPtr ParentNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.firstChild")]
    public static partial IntPtr FirstChild(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.lastChild")]
    public static partial IntPtr LastChild(IntPtr handle);
}
