using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class DOMRange
{
    protected internal readonly JSObject _jsHandle;

    public DOMRange(JSObject handle)
    {
        _jsHandle = handle;
    }

    public Element StartContainer => new(DOMRangeCore.GetStartContainer(_jsHandle));
    public int StartOffset => DOMRangeCore.GetStartOffset(_jsHandle);
    public Element EndContainer => new(DOMRangeCore.GetEndContainer(_jsHandle));
    public int EndOffset => DOMRangeCore.GetEndOffset(_jsHandle);
    public Element CommonAncestorContainer => new(DOMRangeCore.GetCommonAncestorContainer(_jsHandle));
    public bool Collapsed => DOMRangeCore.GetCollapsed(_jsHandle);

    public int CompareBoundaryPoints(string how, DOMRange sourceRange) =>
        DOMRangeCore.CompareBoundaryPoints(_jsHandle, how, sourceRange._jsHandle);

    public void DeleteContents() => DOMRangeCore.DeleteContents(_jsHandle);
    public Element ExtractContents() => new(DOMRangeCore.ExtractContents(_jsHandle));
    public Element CloneContents() => new(DOMRangeCore.CloneContents(_jsHandle));
    public void InsertNode(Element newNode) => DOMRangeCore.InsertNode(_jsHandle, newNode.Handle);
    public void SurroundContents(Element newParent) => DOMRangeCore.SurroundContents(_jsHandle, newParent.Handle);
    public DOMRange CloneRange() => new(DOMRangeCore.CloneRange(_jsHandle));
    public override string ToString() => DOMRangeCore.ToStringImpl(_jsHandle);

    public const int START_TO_START = 0;
    public const int START_TO_END = 1;
    public const int END_TO_END = 2;
    public const int END_TO_START = 3;
}
