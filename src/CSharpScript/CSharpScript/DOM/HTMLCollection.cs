using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class HTMLCollection
{
    private readonly IntPtr _jsHandle;

    public HTMLCollection(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Length => HTMLCollectionCore.GetLength(_jsHandle);

    public Element? this[int index]
    {
        get
        {
            var handle = HTMLCollectionCore.ItemHTMLCollection(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? GetItem(int index)
    {
        var handle = HTMLCollectionCore.ItemHTMLCollection(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public Element? NamedItem(string name)
    {
        var handle = HTMLCollectionCore.NamedItem(_jsHandle, name);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }
}