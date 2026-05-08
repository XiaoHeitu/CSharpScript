using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class SelectionCore
{
    [JSImport("globalThis.Selection.prototype.anchorNode")]
    public static partial IntPtr GetAnchorNode(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.anchorOffset")]
    public static partial int GetAnchorOffset(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.focusNode")]
    public static partial IntPtr GetFocusNode(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.focusOffset")]
    public static partial int GetFocusOffset(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.isCollapsed")]
    public static partial bool GetIsCollapsed(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.rangeCount")]
    public static partial int GetRangeCount(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.toString")]
    public static partial string SelectionToString(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.getRangeAt")]
    public static partial IntPtr GetRangeAt(IntPtr handle, int index);

    [JSImport("globalThis.Selection.prototype.collapse")]
    public static partial void Collapse(IntPtr handle, IntPtr node, int offset);

    [JSImport("globalThis.Selection.prototype.removeAllRanges")]
    public static partial void RemoveAllRanges(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.addRange")]
    public static partial void AddRange(IntPtr handle, IntPtr range);

    [JSImport("globalThis.Selection.prototype.deleteFromDocument")]
    public static partial void DeleteFromDocument(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.containsNode")]
    public static partial bool ContainsNode(IntPtr handle, IntPtr node, bool partial);
}
