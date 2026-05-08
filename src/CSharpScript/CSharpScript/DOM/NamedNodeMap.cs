using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class NamedNodeMap
{
    private readonly JSObject _jsHandle;

    public NamedNodeMap(JSObject handle)
    {
        _jsHandle = handle;
    }

    public int Length => NamedNodeMapCore.GetLength(_jsHandle);

    public Attr? this[int index]
    {
        get
        {
            var handle = NamedNodeMapCore.Item(_jsHandle, index);
            return handle == null ? null : new Attr(handle);
        }
    }

    public Attr? GetItem(int index)
    {
        var handle = NamedNodeMapCore.Item(_jsHandle, index);
        return handle == null ? null : new Attr(handle);
    }

    public Attr? GetNamedItem(string name)
    {
        var handle = NamedNodeMapCore.GetNamedItem(_jsHandle, name);
        return handle == null ? null : new Attr(handle);
    }

    public Attr? SetNamedItem(Attr node)
    {
        var handle = NamedNodeMapCore.SetNamedItem(_jsHandle, node.Handle);
        return handle == null ? null : new Attr(handle);
    }

    public Attr? RemoveNamedItem(string name)
    {
        var handle = NamedNodeMapCore.RemoveNamedItem(_jsHandle, name);
        return handle == null ? null : new Attr(handle);
    }

    public Attr? GetNamedItemNS(string? ns, string localName)
    {
        var handle = NamedNodeMapCore.GetNamedItemNS(_jsHandle, ns, localName);
        return handle == null ? null : new Attr(handle);
    }

    public Attr? SetNamedItemNS(Attr node)
    {
        var handle = NamedNodeMapCore.SetNamedItemNS(_jsHandle, node.Handle);
        return handle == null ? null : new Attr(handle);
    }

    public Attr? RemoveNamedItemNS(string? ns, string localName)
    {
        var handle = NamedNodeMapCore.RemoveNamedItemNS(_jsHandle, ns, localName);
        return handle == null ? null : new Attr(handle);
    }
}
