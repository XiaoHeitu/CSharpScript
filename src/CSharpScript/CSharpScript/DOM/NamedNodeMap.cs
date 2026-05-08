using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class NamedNodeMap
{
    private readonly IntPtr _jsHandle;

    public NamedNodeMap(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Length => NamedNodeMapCore.GetLength(_jsHandle);

    public Attr? this[int index]
    {
        get
        {
            var handle = NamedNodeMapCore.ItemNamedNodeMap(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Attr(handle);
        }
    }

    public Attr? GetItem(int index)
    {
        var handle = NamedNodeMapCore.ItemNamedNodeMap(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? GetNamedItem(string name)
    {
        var handle = NamedNodeMapCore.GetNamedItem(_jsHandle, name);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? SetNamedItem(Attr node)
    {
        var handle = NamedNodeMapCore.SetNamedItem(_jsHandle, node.Handle);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? RemoveNamedItem(string name)
    {
        var handle = NamedNodeMapCore.RemoveNamedItem(_jsHandle, name);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? GetNamedItemNS(string? ns, string localName)
    {
        var handle = NamedNodeMapCore.GetNamedItemNS(_jsHandle, ns, localName);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? SetNamedItemNS(Attr node)
    {
        var handle = NamedNodeMapCore.SetNamedItemNS(_jsHandle, node.Handle);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? RemoveNamedItemNS(string? ns, string localName)
    {
        var handle = NamedNodeMapCore.RemoveNamedItemNS(_jsHandle, ns, localName);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }
}