using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class NodeFilter
{
    internal readonly IntPtr _jsHandle;

    public NodeFilter(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public IntPtr Handle => _jsHandle;

    public int AcceptNode(IntPtr node)
    {
        return 1;
    }

    public const int FILTER_ACCEPT = 1;
    public const int FILTER_REJECT = 2;
    public const int FILTER_SKIP = 3;

    public const int SHOW_ALL = unchecked((int)0xFFFFFFFF);
    public const int SHOW_ELEMENT = 0x1;
    public const int SHOW_ATTRIBUTE = 0x2;
    public const int SHOW_TEXT = 0x4;
    public const int SHOW_CDATA_SECTION = 0x8;
    public const int SHOW_ENTITY_REFERENCE = 0x10;
    public const int SHOW_ENTITY = 0x20;
    public const int SHOW_PROCESSING_INSTRUCTION = 0x40;
    public const int SHOW_COMMENT = 0x80;
    public const int SHOW_DOCUMENT = 0x100;
    public const int SHOW_DOCUMENT_TYPE = 0x200;
    public const int SHOW_DOCUMENT_FRAGMENT = 0x400;
    public const int SHOW_NOTATION = 0x800;
}