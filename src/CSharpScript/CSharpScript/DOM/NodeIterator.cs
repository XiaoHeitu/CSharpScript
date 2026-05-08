using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class NodeIterator
{
    private readonly IntPtr _jsHandle;

    public NodeIterator(IntPtr handle)
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
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public Element? PreviousNode()
    {
        var handle = NodeIteratorCore.PreviousNode(_jsHandle);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public void Detach() => NodeIteratorCore.Detach(_jsHandle);
}