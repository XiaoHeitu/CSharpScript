using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class NodeList
{
    private readonly JSObject _jsHandle;

    public NodeList(JSObject handle)
    {
        _jsHandle = handle;
    }

    public int Length => NodeListCore.GetLength(_jsHandle);

    public Element? this[int index]
    {
        get
        {
            var handle = NodeListCore.Item(_jsHandle, index);
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? GetItem(int index)
    {
        var handle = NodeListCore.Item(_jsHandle, index);
        return handle == null ? null : new Element(handle);
    }
}
