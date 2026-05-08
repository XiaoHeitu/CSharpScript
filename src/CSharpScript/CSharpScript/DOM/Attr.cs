using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class Attr
{
    private readonly JSObject _jsHandle;

    public Attr(JSObject handle)
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

    public JSObject Handle => _jsHandle;

    public Element? OwnerElement
    {
        get
        {
            var handle = AttrCore.GetOwnerElement(_jsHandle);
            return handle == null ? null : new Element(handle);
        }
    }

    public override string ToString() => $"{Name}=\"{Value}\"";
}
