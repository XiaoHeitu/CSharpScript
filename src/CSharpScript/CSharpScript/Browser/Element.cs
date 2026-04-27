namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public partial class Element
{
    internal readonly IntPtr _jsHandle;

    public Element(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.Element.prototype.getAttribute")]
    public static partial string GetAttribute(IntPtr handle, string name);

    [JSImport("globalThis.Element.prototype.setAttribute")]
    public static partial void SetAttribute(IntPtr handle, string name, string value);

    [JSImport("globalThis.Element.prototype.removeAttribute")]
    public static partial void RemoveAttribute(IntPtr handle, string name);

    [JSImport("globalThis.Element.prototype.hasAttribute")]
    public static partial bool HasAttribute(IntPtr handle, string name);

    [JSImport("globalThis.Element.prototype.getAttributeNS")]
    public static partial string? GetAttributeNS(IntPtr handle, string? ns, string localName);

    [JSImport("globalThis.Element.prototype.setAttributeNS")]
    public static partial void SetAttributeNS(IntPtr handle, string? ns, string qualifiedName, string value);

    [JSImport("globalThis.Element.prototype.removeAttributeNS")]
    public static partial void RemoveAttributeNS(IntPtr handle, string? ns, string localName);

    [JSImport("globalThis.Element.prototype.id")]
    public static partial string GetId(IntPtr handle);

    [JSImport("globalThis.Element.prototype.id")]
    public static partial void SetId(IntPtr handle, string value);

    [JSImport("globalThis.Element.prototype.tagName")]
    public static partial string GetTagName(IntPtr handle);

    [JSImport("globalThis.Element.prototype.className")]
    public static partial string GetClassName(IntPtr handle);

    [JSImport("globalThis.Element.prototype.className")]
    public static partial void SetClassName(IntPtr handle, string value);

    [JSImport("globalThis.Element.prototype.innerHTML")]
    public static partial string GetInnerHTML(IntPtr handle);

    [JSImport("globalThis.Element.prototype.innerHTML")]
    public static partial void SetInnerHTML(IntPtr handle, string value);

    [JSImport("globalThis.Element.prototype.outerHTML")]
    public static partial string GetOuterHTML(IntPtr handle);

    [JSImport("globalThis.Element.prototype.outerHTML")]
    public static partial void SetOuterHTML(IntPtr handle, string value);

    [JSImport("globalThis.Element.prototype.textContent")]
    public static partial string? GetTextContent(IntPtr handle);

    [JSImport("globalThis.Element.prototype.textContent")]
    public static partial void SetTextContent(IntPtr handle, string? value);

    [JSImport("globalThis.Element.prototype.innerText")]
    public static partial string GetInnerText(IntPtr handle);

    [JSImport("globalThis.Element.prototype.innerText")]
    public static partial void SetInnerText(IntPtr handle, string value);

    [JSImport("globalThis.Element.prototype.click")]
    public static partial void Click(IntPtr handle);

    [JSImport("globalThis.Element.prototype.focus")]
    public static partial void Focus(IntPtr handle);

    [JSImport("globalThis.Element.prototype.blur")]
    public static partial void Blur(IntPtr handle);

    [JSImport("globalThis.Element.prototype.scrollIntoView")]
    public static partial void ScrollIntoView(IntPtr handle);

    [JSImport("globalThis.Element.prototype.scrollIntoView")]
    public static partial void ScrollIntoViewWithOptions(IntPtr handle, bool alignToTop);

    [JSImport("globalThis.Element.prototype.scroll")]
    public static partial void Scroll(IntPtr handle, double x, double y);

    [JSImport("globalThis.Element.prototype.scrollTo")]
    public static partial void ScrollTo(IntPtr handle, double x, double y);

    [JSImport("globalThis.Element.prototype.scrollBy")]
    public static partial void ScrollBy(IntPtr handle, double x, double y);

    [JSImport("globalThis.Element.prototype.getBoundingClientRect")]
    public static partial IntPtr GetBoundingClientRectImpl(IntPtr handle);

    [JSImport("globalThis.Element.prototype.getClientRects")]
    public static partial IntPtr GetClientRects(IntPtr handle);

    [JSImport("globalThis.Element.prototype.offsetParent")]
    public static partial IntPtr GetOffsetParent(IntPtr handle);

    [JSImport("globalThis.Element.prototype.offsetTop")]
    public static partial double GetOffsetTop(IntPtr handle);

    [JSImport("globalThis.Element.prototype.offsetLeft")]
    public static partial double GetOffsetLeft(IntPtr handle);

    [JSImport("globalThis.Element.prototype.offsetWidth")]
    public static partial double GetOffsetWidth(IntPtr handle);

    [JSImport("globalThis.Element.prototype.offsetHeight")]
    public static partial double GetOffsetHeight(IntPtr handle);

    [JSImport("globalThis.Element.prototype.scrollTop")]
    public static partial double GetScrollTop(IntPtr handle);

    [JSImport("globalThis.Element.prototype.scrollTop")]
    public static partial void SetScrollTop(IntPtr handle, double value);

    [JSImport("globalThis.Element.prototype.scrollLeft")]
    public static partial double GetScrollLeft(IntPtr handle);

    [JSImport("globalThis.Element.prototype.scrollLeft")]
    public static partial void SetScrollLeft(IntPtr handle, double value);

    [JSImport("globalThis.Element.prototype.scrollWidth")]
    public static partial double GetScrollWidth(IntPtr handle);

    [JSImport("globalThis.Element.prototype.scrollHeight")]
    public static partial double GetScrollHeight(IntPtr handle);

    [JSImport("globalThis.Element.prototype.clientTop")]
    public static partial double GetClientTop(IntPtr handle);

    [JSImport("globalThis.Element.prototype.clientLeft")]
    public static partial double GetClientLeft(IntPtr handle);

    [JSImport("globalThis.Element.prototype.clientWidth")]
    public static partial double GetClientWidth(IntPtr handle);

    [JSImport("globalThis.Element.prototype.clientHeight")]
    public static partial double GetClientHeight(IntPtr handle);

    [JSImport("globalThis.Element.prototype.children")]
    public static partial IntPtr GetChildren(IntPtr handle);

    [JSImport("globalThis.Element.prototype.childElementCount")]
    public static partial int GetChildElementCount(IntPtr handle);

    [JSImport("globalThis.Element.prototype.firstElementChild")]
    public static partial IntPtr GetFirstElementChild(IntPtr handle);

    [JSImport("globalThis.Element.prototype.lastElementChild")]
    public static partial IntPtr GetLastElementChild(IntPtr handle);

    [JSImport("globalThis.Element.prototype.previousElementSibling")]
    public static partial IntPtr GetPreviousElementSibling(IntPtr handle);

    [JSImport("globalThis.Element.prototype.nextElementSibling")]
    public static partial IntPtr GetNextElementSibling(IntPtr handle);

    [JSImport("globalThis.Element.prototype.appendChild")]
    public static partial IntPtr AppendChild(IntPtr handle, IntPtr newChild);

    [JSImport("globalThis.Element.prototype.removeChild")]
    public static partial IntPtr RemoveChild(IntPtr handle, IntPtr oldChild);

    [JSImport("globalThis.Element.prototype.replaceChild")]
    public static partial IntPtr ReplaceChild(IntPtr handle, IntPtr newChild, IntPtr oldChild);

    [JSImport("globalThis.Element.prototype.insertBefore")]
    public static partial IntPtr InsertBefore(IntPtr handle, IntPtr newNode, IntPtr? referenceNode);

    [JSImport("globalThis.Element.prototype.cloneNode")]
    public static partial IntPtr CloneNode(IntPtr handle, bool deep = false);

    [JSImport("globalThis.Element.prototype.contains")]
    public static partial bool Contains(IntPtr handle, IntPtr other);

    [JSImport("globalThis.Element.prototype.closest")]
    public static partial IntPtr Closest(IntPtr handle, string selectors);

    [JSImport("globalThis.Element.prototype.matches")]
    public static partial bool Matches(IntPtr handle, string selectors);

    [JSImport("globalThis.Element.prototype.querySelector")]
    public static partial IntPtr QuerySelector(IntPtr handle, string selectors);

    [JSImport("globalThis.Element.prototype.querySelectorAll")]
    public static partial IntPtr QuerySelectorAll(IntPtr handle, string selectors);

    [JSImport("globalThis.Element.prototype.getElementsByClassName")]
    public static partial IntPtr GetElementsByClassName(IntPtr handle, string className);

    [JSImport("globalThis.Element.prototype.getElementsByTagName")]
    public static partial IntPtr GetElementsByTagName(IntPtr handle, string tagName);

    [JSImport("globalThis.Element.prototype.hasFocus")]
    public static partial bool HasFocus(IntPtr handle);

    public string Id
    {
        get => GetId(_jsHandle);
        set => SetId(_jsHandle, value);
    }

    public string TagName => GetTagName(_jsHandle);

    public string ClassName
    {
        get => GetClassName(_jsHandle);
        set => SetClassName(_jsHandle, value);
    }

    public string InnerHTML
    {
        get => GetInnerHTML(_jsHandle);
        set => SetInnerHTML(_jsHandle, value);
    }

    public string OuterHTML
    {
        get => GetOuterHTML(_jsHandle);
        set => SetOuterHTML(_jsHandle, value);
    }

    public string? TextContent
    {
        get => GetTextContent(_jsHandle);
        set => SetTextContent(_jsHandle, value);
    }

    public string InnerText
    {
        get => GetInnerText(_jsHandle);
        set => SetInnerText(_jsHandle, value);
    }

    public DOMRect GetBoundingClientRect() => new(GetBoundingClientRectImpl(_jsHandle));

    public IntPtr OffsetParent => GetOffsetParent(_jsHandle);
    public double OffsetTop => GetOffsetTop(_jsHandle);
    public double OffsetLeft => GetOffsetLeft(_jsHandle);
    public double OffsetWidth => GetOffsetWidth(_jsHandle);
    public double OffsetHeight => GetOffsetHeight(_jsHandle);

    public double ScrollTop
    {
        get => GetScrollTop(_jsHandle);
        set => SetScrollTop(_jsHandle, value);
    }

    public double ScrollLeft
    {
        get => GetScrollLeft(_jsHandle);
        set => SetScrollLeft(_jsHandle, value);
    }

    public double ScrollWidth => GetScrollWidth(_jsHandle);
    public double ScrollHeight => GetScrollHeight(_jsHandle);

    public double ClientTop => GetClientTop(_jsHandle);
    public double ClientLeft => GetClientLeft(_jsHandle);
    public double ClientWidth => GetClientWidth(_jsHandle);
    public double ClientHeight => GetClientHeight(_jsHandle);

    public HTMLCollection Children => new(GetChildren(_jsHandle));

    public int ChildElementCount => GetChildElementCount(_jsHandle);

    public Element? FirstElementChild
    {
        get
        {
            var handle = GetFirstElementChild(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? LastElementChild
    {
        get
        {
            var handle = GetLastElementChild(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? PreviousElementSibling
    {
        get
        {
            var handle = GetPreviousElementSibling(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? NextElementSibling
    {
        get
        {
            var handle = GetNextElementSibling(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public void ScrollIntoView() => ScrollIntoView(_jsHandle);
    public void ScrollIntoView(bool alignToTop) => ScrollIntoViewWithOptions(_jsHandle, alignToTop);
    public void Scroll(double x, double y) => Scroll(_jsHandle, x, y);
    public void ScrollTo(double x, double y) => ScrollTo(_jsHandle, x, y);
    public void ScrollBy(double x, double y) => ScrollBy(_jsHandle, x, y);

    public string? GetAttribute(string name) => GetAttribute(_jsHandle, name);
    public void SetAttribute(string name, string value) => SetAttribute(_jsHandle, name, value);
    public void RemoveAttribute(string name) => RemoveAttribute(_jsHandle, name);
    public bool HasAttribute(string name) => HasAttribute(_jsHandle, name);
    public string? GetAttributeNS(string? ns, string localName) => GetAttributeNS(_jsHandle, ns, localName);
    public void SetAttributeNS(string? ns, string qualifiedName, string value) => SetAttributeNS(_jsHandle, ns, qualifiedName, value);
    public void RemoveAttributeNS(string? ns, string localName) => RemoveAttributeNS(_jsHandle, ns, localName);

    public Element AppendChild(Element newChild) => new(AppendChild(_jsHandle, newChild._jsHandle));
    public Element RemoveChild(Element oldChild) => new(RemoveChild(_jsHandle, oldChild._jsHandle));
    public Element ReplaceChild(Element newChild, Element oldChild) => new(ReplaceChild(_jsHandle, newChild._jsHandle, oldChild._jsHandle));
    public Element InsertBefore(Element newNode, Element? referenceNode) =>
        new(InsertBefore(_jsHandle, newNode._jsHandle, referenceNode?._jsHandle));

    public Element CloneNode(bool deep = false) => new(CloneNode(_jsHandle, deep));
    public bool Contains(Element other) => Contains(_jsHandle, other._jsHandle);
    public Element? Closest(string selectors)
    {
        var handle = Closest(_jsHandle, selectors);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public bool Matches(string selectors) => Matches(_jsHandle, selectors);
    public Element? QuerySelector(string selectors)
    {
        var handle = QuerySelector(_jsHandle, selectors);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public HTMLCollection QuerySelectorAll(string selectors) => new(QuerySelectorAll(_jsHandle, selectors));
    public HTMLCollection GetElementsByClassName(string className) => new(GetElementsByClassName(_jsHandle, className));
    public HTMLCollection GetElementsByTagName(string tagName) => new(GetElementsByTagName(_jsHandle, tagName));

    public bool HasFocus() => HasFocus(_jsHandle);

    public IntPtr Handle => _jsHandle;
}

[SupportedOSPlatform("browser")]
public partial class DOMRect
{
    internal readonly IntPtr _jsHandle;

    public DOMRect(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.DOMRect.prototype.x")]
    public static partial double GetX(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.y")]
    public static partial double GetY(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.width")]
    public static partial double GetWidth(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.height")]
    public static partial double GetHeight(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.top")]
    public static partial double GetTop(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.right")]
    public static partial double GetRight(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.bottom")]
    public static partial double GetBottom(IntPtr handle);

    [JSImport("globalThis.DOMRect.prototype.left")]
    public static partial double GetLeft(IntPtr handle);

    public double X => GetX(_jsHandle);
    public double Y => GetY(_jsHandle);
    public double Width => GetWidth(_jsHandle);
    public double Height => GetHeight(_jsHandle);
    public double Top => GetTop(_jsHandle);
    public double Right => GetRight(_jsHandle);
    public double Bottom => GetBottom(_jsHandle);
    public double Left => GetLeft(_jsHandle);
}
