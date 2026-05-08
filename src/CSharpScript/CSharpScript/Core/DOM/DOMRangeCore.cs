using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class DOMRangeCore
{
    [JSImport("globalThis.Range.prototype.startContainer")]
    public static partial IntPtr GetStartContainer(IntPtr handle);

    [JSImport("globalThis.Range.prototype.startOffset")]
    public static partial int GetStartOffset(IntPtr handle);

    [JSImport("globalThis.Range.prototype.endContainer")]
    public static partial IntPtr GetEndContainer(IntPtr handle);

    [JSImport("globalThis.Range.prototype.endOffset")]
    public static partial int GetEndOffset(IntPtr handle);

    [JSImport("globalThis.Range.prototype.commonAncestorContainer")]
    public static partial IntPtr GetCommonAncestorContainer(IntPtr handle);

    [JSImport("globalThis.Range.prototype.collapsed")]
    public static partial bool GetCollapsed(IntPtr handle);

    [JSImport("globalThis.Range.prototype.compareBoundaryPoints")]
    public static partial int CompareBoundaryPoints(IntPtr handle, string how, IntPtr sourceRange);

    [JSImport("globalThis.Range.prototype.deleteContents")]
    public static partial void DeleteContents(IntPtr handle);

    [JSImport("globalThis.Range.prototype.extractContents")]
    public static partial IntPtr ExtractContents(IntPtr handle);

    [JSImport("globalThis.Range.prototype.cloneContents")]
    public static partial IntPtr CloneContents(IntPtr handle);

    [JSImport("globalThis.Range.prototype.insertNode")]
    public static partial void InsertNode(IntPtr handle, IntPtr newNode);

    [JSImport("globalThis.Range.prototype.surroundContents")]
    public static partial void SurroundContents(IntPtr handle, IntPtr newParent);

    [JSImport("globalThis.Range.prototype.cloneRange")]
    public static partial IntPtr CloneRange(IntPtr handle);

    [JSImport("globalThis.Range.prototype.toString")]
    public static partial string RangeToString(IntPtr handle);
}