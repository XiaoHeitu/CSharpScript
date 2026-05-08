using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class TreeWalker
{
    private readonly JSObject _jsHandle;

    public TreeWalker(JSObject handle)
    {
        _jsHandle = handle;
    }

    public Element Root => new(TreeWalkerCore.GetRoot(_jsHandle));

    public Element CurrentNode
    {
        get => new(TreeWalkerCore.GetCurrentNode(_jsHandle));
        set => TreeWalkerCore.SetCurrentNode(_jsHandle, value.Handle);
    }

    public int WhatToShow { get; set; }

    public Element? NextNode()
    {
        var handle = TreeWalkerCore.NextNode(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? PreviousNode()
    {
        var handle = TreeWalkerCore.PreviousNode(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? NextSibling()
    {
        var handle = TreeWalkerCore.NextSibling(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? PreviousSibling()
    {
        var handle = TreeWalkerCore.PreviousSibling(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? ParentNode()
    {
        var handle = TreeWalkerCore.ParentNode(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? FirstChild()
    {
        var handle = TreeWalkerCore.FirstChild(_jsHandle);
        return handle == null ? null : new Element(handle);
    }

    public Element? LastChild()
    {
        var handle = TreeWalkerCore.LastChild(_jsHandle);
        return handle == null ? null : new Element(handle);
    }
}
