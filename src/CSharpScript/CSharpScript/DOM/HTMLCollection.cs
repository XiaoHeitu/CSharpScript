using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class HTMLCollection
{
    private readonly JSObject _jsHandle;

    public HTMLCollection(JSObject handle)
    {
        _jsHandle = handle;
    }

    public int Length => HTMLCollectionCore.GetLength(_jsHandle);

    public Element? this[int index]
    {
        get
        {
            var handle = HTMLCollectionCore.Item(_jsHandle, index);
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? GetItem(int index)
    {
        var handle = HTMLCollectionCore.Item(_jsHandle, index);
        return handle == null ? null : new Element(handle);
    }

    public Element? NamedItem(string name)
    {
        var handle = HTMLCollectionCore.NamedItem(_jsHandle, name);
        return handle == null ? null : new Element(handle);
    }
}
