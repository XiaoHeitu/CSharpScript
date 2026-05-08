using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class NodeIterator
{
    private readonly JSObject _jsHandle;

    public NodeIterator(JSObject handle)
    {
        _jsHandle = handle;
    }

    public Element Root => new(NodeIteratorCore.GetRoot(_jsHandle));

    public Element ReferenceNode => new(NodeIteratorCore.GetReferenceNode(_jsHandle));

    public bool PointerBeforeReferenceNode => NodeIteratorCore.GetPointerBeforeReferenceNode(_jsHandle);

    public int WhatToShow { get; set; }

    public Element? NextNode()
    {
        var handle = NodeIteratorCore.NextNode(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? PreviousNode()
    {
        var handle = NodeIteratorCore.PreviousNode(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public void Detach() => NodeIteratorCore.Detach(_jsHandle);
}
