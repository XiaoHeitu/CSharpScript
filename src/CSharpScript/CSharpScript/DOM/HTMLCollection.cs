using CSharpScript.Core.DOM;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class HTMLCollection
{
    private readonly JSObject _jsHandle;

    public HTMLCollection(JSObject handle)
    {
        _jsHandle = handle;
    }

    public int Length => _jsHandle.GetPropertyAsInt32("length");

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
