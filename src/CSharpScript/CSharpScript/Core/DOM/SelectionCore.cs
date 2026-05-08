using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class SelectionCore
{
    [JSImport("globalThis.Selection.prototype.anchorNode")]
    public static partial JSObject GetAnchorNode(JSObject handle);

    [JSImport("globalThis.Selection.prototype.anchorOffset")]
    public static partial int GetAnchorOffset(JSObject handle);

    [JSImport("globalThis.Selection.prototype.focusNode")]
    public static partial JSObject GetFocusNode(JSObject handle);

    [JSImport("globalThis.Selection.prototype.focusOffset")]
    public static partial int GetFocusOffset(JSObject handle);

    [JSImport("globalThis.Selection.prototype.isCollapsed")]
    public static partial bool GetIsCollapsed(JSObject handle);

    [JSImport("globalThis.Selection.prototype.rangeCount")]
    public static partial int GetRangeCount(JSObject handle);

    [JSImport("globalThis.Selection.prototype.toString")]
    public static partial string ToStringImpl(JSObject handle);

    [JSImport("globalThis.Selection.prototype.getRangeAt")]
    public static partial JSObject GetRangeAt(JSObject handle, int index);

    [JSImport("globalThis.Selection.prototype.collapse")]
    public static partial void Collapse(JSObject handle, JSObject? node, int offset);

    [JSImport("globalThis.Selection.prototype.removeAllRanges")]
    public static partial void RemoveAllRanges(JSObject handle);

    [JSImport("globalThis.Selection.prototype.addRange")]
    public static partial void AddRange(JSObject handle, JSObject range);

    [JSImport("globalThis.Selection.prototype.deleteFromDocument")]
    public static partial void DeleteFromDocument(JSObject handle);

    [JSImport("globalThis.Selection.prototype.containsNode")]
    public static partial bool ContainsNode(JSObject handle, JSObject node, bool partial);
}
