using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class NodeList
{
    private readonly IntPtr _jsHandle;

    public NodeList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Length => NodeListCore.GetLength(_jsHandle);

    public Element? this[int index]
    {
        get
        {
            var handle = NodeListCore.ItemNodeList(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? GetItem(int index)
    {
        var handle = NodeListCore.ItemNodeList(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }
}