using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class DOMRangeCore
{
    [JSImport("globalThis.Range.prototype.startContainer")]
    public static partial JSObject GetStartContainer(JSObject handle);

    [JSImport("globalThis.Range.prototype.startOffset")]
    public static partial int GetStartOffset(JSObject handle);

    [JSImport("globalThis.Range.prototype.endContainer")]
    public static partial JSObject GetEndContainer(JSObject handle);

    [JSImport("globalThis.Range.prototype.endOffset")]
    public static partial int GetEndOffset(JSObject handle);

    [JSImport("globalThis.Range.prototype.commonAncestorContainer")]
    public static partial JSObject GetCommonAncestorContainer(JSObject handle);

    [JSImport("globalThis.Range.prototype.collapsed")]
    public static partial bool GetCollapsed(JSObject handle);

    [JSImport("globalThis.Range.prototype.compareBoundaryPoints")]
    public static partial int CompareBoundaryPoints(JSObject handle, string how, JSObject sourceRange);

    [JSImport("globalThis.Range.prototype.deleteContents")]
    public static partial void DeleteContents(JSObject handle);

    [JSImport("globalThis.Range.prototype.extractContents")]
    public static partial JSObject ExtractContents(JSObject handle);

    [JSImport("globalThis.Range.prototype.cloneContents")]
    public static partial JSObject CloneContents(JSObject handle);

    [JSImport("globalThis.Range.prototype.insertNode")]
    public static partial void InsertNode(JSObject handle, JSObject newNode);

    [JSImport("globalThis.Range.prototype.surroundContents")]
    public static partial void SurroundContents(JSObject handle, JSObject newParent);

    [JSImport("globalThis.Range.prototype.cloneRange")]
    public static partial JSObject CloneRange(JSObject handle);

    [JSImport("globalThis.Range.prototype.toString")]
    public static partial string RangeToString(JSObject handle);
}
