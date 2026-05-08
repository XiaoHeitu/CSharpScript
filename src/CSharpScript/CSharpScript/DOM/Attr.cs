using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class Attr
{
    private readonly IntPtr _jsHandle;

    public Attr(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public string Name => AttrCore.GetName(_jsHandle);

    public string Value
    {
        get => AttrCore.GetValue(_jsHandle);
        set => AttrCore.SetValue(_jsHandle, value);
    }

    public string? NamespaceURI => AttrCore.GetNamespaceURI(_jsHandle);

    public string? Prefix => AttrCore.GetPrefix(_jsHandle);

    public string LocalName => AttrCore.GetLocalName(_jsHandle);

    public bool Specified => AttrCore.GetSpecified(_jsHandle);

    public IntPtr Handle => _jsHandle;

    public Element? OwnerElement
    {
        get
        {
            var handle = AttrCore.GetOwnerElement(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public override string ToString() => $"{Name}=\"{Value}\"";
}