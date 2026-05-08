using System.Runtime.CompilerServices;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class Selection
{
    private readonly IntPtr _jsHandle;

    public Selection(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public Element? AnchorNode
    {
        get
        {
            var handle = SelectionCore.GetAnchorNode(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public int AnchorOffset => SelectionCore.GetAnchorOffset(_jsHandle);

    public Element? FocusNode
    {
        get
        {
            var handle = SelectionCore.GetFocusNode(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public int FocusOffset => SelectionCore.GetFocusOffset(_jsHandle);

    public bool IsCollapsed => SelectionCore.GetIsCollapsed(_jsHandle);
    public int RangeCount => SelectionCore.GetRangeCount(_jsHandle);

    public override string ToString() => SelectionCore.SelectionToString(_jsHandle);

    public DOMRange? GetRangeAt(int index)
    {
        var handle = SelectionCore.GetRangeAt(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new DOMRange(handle);
    }

    public void Collapse(Element? node, int offset) =>
        SelectionCore.Collapse(_jsHandle, node?.Handle ?? IntPtr.Zero, offset);

    public void RemoveAllRanges() => SelectionCore.RemoveAllRanges(_jsHandle);
    public void AddRange(DOMRange range) => SelectionCore.AddRange(_jsHandle, range._jsHandle);
    public void DeleteFromDocument() => SelectionCore.DeleteFromDocument(_jsHandle);
    public bool ContainsNode(Element node, bool partial = false) =>
        SelectionCore.ContainsNode(_jsHandle, node.Handle, partial);
}
