namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public partial class HTMLCollection
{
    internal readonly IntPtr _jsHandle;

    public HTMLCollection(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.HTMLCollection.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.HTMLCollection.prototype.item")]
    public static partial IntPtr ItemImpl(IntPtr handle, int index);

    [JSImport("globalThis.HTMLCollection.prototype.namedItem")]
    public static partial IntPtr NamedItemImpl(IntPtr handle, string name);

    public int Length => GetLength(_jsHandle);
    public int Count => Length;

    public Element? this[int index]
    {
        get
        {
            var handle = ItemImpl(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? this[string name]
    {
        get
        {
            var handle = NamedItemImpl(_jsHandle, name);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? GetAt(int index)
    {
        var handle = ItemImpl(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public Element? GetByName(string name)
    {
        var handle = NamedItemImpl(_jsHandle, name);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public IEnumerable<Element> AsEnumerable()
    {
        for (int i = 0; i < Length; i++)
        {
            var element = this[i];
            if (element != null)
                yield return element;
        }
    }

    public IntPtr Handle => _jsHandle;
}

[SupportedOSPlatform("browser")]
public partial class NodeList
{
    internal readonly IntPtr _jsHandle;

    public NodeList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.NodeList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.NodeList.prototype.item")]
    public static partial IntPtr ItemImpl(IntPtr handle, int index);

    public int Length => GetLength(_jsHandle);
    public int Count => Length;

    public Element? this[int index]
    {
        get
        {
            var handle = ItemImpl(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? GetAt(int index)
    {
        var handle = ItemImpl(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public IEnumerable<Element> AsEnumerable()
    {
        for (int i = 0; i < Length; i++)
        {
            var element = this[i];
            if (element != null)
                yield return element;
        }
    }

    public IntPtr Handle => _jsHandle;
}

[SupportedOSPlatform("browser")]
public partial class NamedNodeMap
{
    internal readonly IntPtr _jsHandle;

    public NamedNodeMap(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.NamedNodeMap.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.NamedNodeMap.prototype.item")]
    public static partial IntPtr ItemImpl(IntPtr handle, int index);

    [JSImport("globalThis.NamedNodeMap.prototype.getNamedItem")]
    public static partial IntPtr GetNamedItemImpl(IntPtr handle, string name);

    [JSImport("globalThis.NamedNodeMap.prototype.setNamedItem")]
    public static partial IntPtr SetNamedItemImpl(IntPtr handle, IntPtr node);

    [JSImport("globalThis.NamedNodeMap.prototype.removeNamedItem")]
    public static partial IntPtr RemoveNamedItemImpl(IntPtr handle, string name);

    public int Length => GetLength(_jsHandle);
    public int Count => Length;

    public Attr? this[int index]
    {
        get
        {
            var handle = ItemImpl(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Attr(handle);
        }
    }

    public Attr? this[string name]
    {
        get => GetNamedItem(name);
        set => SetNode(value ?? throw new ArgumentNullException(nameof(value)));
    }

    public Attr? GetAt(int index)
    {
        var handle = ItemImpl(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? GetNamedItem(string name)
    {
        var handle = GetNamedItemImpl(_jsHandle, name);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? SetNode(Attr node)
    {
        var handle = SetNamedItemImpl(_jsHandle, node._jsHandle);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public Attr? RemoveNamedItem(string name)
    {
        var handle = RemoveNamedItemImpl(_jsHandle, name);
        return handle == IntPtr.Zero ? null : new Attr(handle);
    }

    public IntPtr Handle => _jsHandle;
}

[SupportedOSPlatform("browser")]
public partial class Attr
{
    internal readonly IntPtr _jsHandle;

    public Attr(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.Attr.prototype.name")]
    public static partial string GetName(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.value")]
    public static partial string GetValue(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.value")]
    public static partial void SetValue(IntPtr handle, string value);

    [JSImport("globalThis.Attr.prototype.localName")]
    public static partial string GetLocalName(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.prefix")]
    public static partial string? GetPrefix(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.namespaceURI")]
    public static partial string? GetNamespaceURI(IntPtr handle);

    public string Name => GetName(_jsHandle);
    public string Value
    {
        get => GetValue(_jsHandle);
        set => SetValue(_jsHandle, value);
    }

    public string LocalName => GetLocalName(_jsHandle);
    public string? Prefix => GetPrefix(_jsHandle);
    public string? NamespaceURI => GetNamespaceURI(_jsHandle);

    public IntPtr Handle => _jsHandle;
}
