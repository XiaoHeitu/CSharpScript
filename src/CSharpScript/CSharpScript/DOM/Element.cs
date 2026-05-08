using CSharpScript.Browser.Event;
using CSharpScript.Browser.CSS;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class Element
{
    private readonly IntPtr _jsHandle;

    public Element(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public string Id
    {
        get => ElementCore.GetId(_jsHandle);
        set => ElementCore.SetId(_jsHandle, value);
    }

    public string TagName => ElementCore.GetTagName(_jsHandle);

    public string ClassName
    {
        get => ElementCore.GetClassName(_jsHandle);
        set => ElementCore.SetClassName(_jsHandle, value);
    }

    public string InnerHTML
    {
        get => ElementCore.GetInnerHTML(_jsHandle);
        set => ElementCore.SetInnerHTML(_jsHandle, value);
    }

    public string OuterHTML
    {
        get => ElementCore.GetOuterHTML(_jsHandle);
        set => ElementCore.SetOuterHTML(_jsHandle, value);
    }

    public string? TextContent
    {
        get => ElementCore.GetTextContent(_jsHandle);
        set => ElementCore.SetTextContent(_jsHandle, value);
    }

    public string InnerText
    {
        get => ElementCore.GetInnerText(_jsHandle);
        set => ElementCore.SetInnerText(_jsHandle, value);
    }

    public DOMRect GetBoundingClientRect() => new(ElementCore.GetBoundingClientRectImpl(_jsHandle));

    public IntPtr OffsetParent => ElementCore.GetOffsetParent(_jsHandle);
    public double OffsetTop => ElementCore.GetOffsetTop(_jsHandle);
    public double OffsetLeft => ElementCore.GetOffsetLeft(_jsHandle);
    public double OffsetWidth => ElementCore.GetOffsetWidth(_jsHandle);
    public double OffsetHeight => ElementCore.GetOffsetHeight(_jsHandle);

    public double ScrollTop
    {
        get => ElementCore.GetScrollTop(_jsHandle);
        set => ElementCore.SetScrollTop(_jsHandle, value);
    }

    public double ScrollLeft
    {
        get => ElementCore.GetScrollLeft(_jsHandle);
        set => ElementCore.SetScrollLeft(_jsHandle, value);
    }

    public double ScrollWidth => ElementCore.GetScrollWidth(_jsHandle);
    public double ScrollHeight => ElementCore.GetScrollHeight(_jsHandle);

    public double ClientTop => ElementCore.GetClientTop(_jsHandle);
    public double ClientLeft => ElementCore.GetClientLeft(_jsHandle);
    public double ClientWidth => ElementCore.GetClientWidth(_jsHandle);
    public double ClientHeight => ElementCore.GetClientHeight(_jsHandle);

    public HTMLCollection Children => new(ElementCore.GetChildren(_jsHandle));

    public int ChildElementCount => ElementCore.GetChildElementCount(_jsHandle);

    public Element? FirstElementChild
    {
        get
        {
            var handle = ElementCore.GetFirstElementChild(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? LastElementChild
    {
        get
        {
            var handle = ElementCore.GetLastElementChild(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? PreviousElementSibling
    {
        get
        {
            var handle = ElementCore.GetPreviousElementSibling(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? NextElementSibling
    {
        get
        {
            var handle = ElementCore.GetNextElementSibling(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public void ScrollIntoView() => ElementCore.ScrollIntoView(_jsHandle);
    public void ScrollIntoView(bool alignToTop) => ElementCore.ScrollIntoViewWithOptions(_jsHandle, alignToTop);
    public void Scroll(double x, double y) => ElementCore.Scroll(_jsHandle, x, y);
    public void ScrollTo(double x, double y) => ElementCore.ScrollTo(_jsHandle, x, y);
    public void ScrollBy(double x, double y) => ElementCore.ScrollBy(_jsHandle, x, y);

    public string? GetAttribute(string name) => ElementCore.GetAttribute(_jsHandle, name);
    public void SetAttribute(string name, string value) => ElementCore.SetAttribute(_jsHandle, name, value);
    public void RemoveAttribute(string name) => ElementCore.RemoveAttribute(_jsHandle, name);
    public bool HasAttribute(string name) => ElementCore.HasAttribute(_jsHandle, name);
    public string? GetAttributeNS(string? ns, string localName) => ElementCore.GetAttributeNS(_jsHandle, ns, localName);
    public void SetAttributeNS(string? ns, string qualifiedName, string value) => ElementCore.SetAttributeNS(_jsHandle, ns, qualifiedName, value);
    public void RemoveAttributeNS(string? ns, string localName) => ElementCore.RemoveAttributeNS(_jsHandle, ns, localName);

    public Element AppendChild(Element newChild) => new(ElementCore.AppendChild(_jsHandle, newChild._jsHandle));
    public Element RemoveChild(Element oldChild) => new(ElementCore.RemoveChild(_jsHandle, oldChild._jsHandle));
    public Element ReplaceChild(Element newChild, Element oldChild) => new(ElementCore.ReplaceChild(_jsHandle, newChild._jsHandle, oldChild._jsHandle));
    public Element InsertBefore(Element newNode, Element? referenceNode) =>
        new(ElementCore.InsertBefore(_jsHandle, newNode._jsHandle, referenceNode?._jsHandle));

    public Element CloneNode(bool deep = false) => new(ElementCore.CloneNode(_jsHandle, deep));
    public bool Contains(Element other) => ElementCore.Contains(_jsHandle, other._jsHandle);
    public Element? Closest(string selectors)
    {
        var handle = ElementCore.Closest(_jsHandle, selectors);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public bool Matches(string selectors) => ElementCore.Matches(_jsHandle, selectors);
    public Element? QuerySelector(string selectors)
    {
        var handle = ElementCore.QuerySelector(_jsHandle, selectors);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public HTMLCollection QuerySelectorAll(string selectors) => new(ElementCore.QuerySelectorAll(_jsHandle, selectors));
    public HTMLCollection GetElementsByClassName(string className) => new(ElementCore.GetElementsByClassName(_jsHandle, className));
    public HTMLCollection GetElementsByTagName(string tagName) => new(ElementCore.GetElementsByTagName(_jsHandle, tagName));

    public bool HasFocus() => ElementCore.HasFocus(_jsHandle);

    public IntPtr Handle => _jsHandle;

    public ClassList ClassList => new(ElementCore.GetClassList(_jsHandle));

    public void AddEventListener(string type, Action listener) =>
        ElementCore.AddEventListener(_jsHandle, type, IntPtr.Zero);

    public void RemoveEventListener(string type, Action listener) =>
        ElementCore.RemoveEventListener(_jsHandle, type, IntPtr.Zero);

    public void AddEventListener<T>(string type, Action<T> listener) =>
        ElementCore.AddEventListener(_jsHandle, type, IntPtr.Zero);

    public void RemoveEventListener<T>(string type, Action<T> listener) =>
        ElementCore.RemoveEventListener(_jsHandle, type, IntPtr.Zero);

    public bool DispatchEvent(BrowserEvent e) => ElementCore.DispatchEvent(_jsHandle, e.Handle);

    public CSSStyleDeclaration Style => new(ElementCore.GetStyle(_jsHandle));

    public void Click() => ElementCore.Click(_jsHandle);
    public void Focus() => ElementCore.Focus(_jsHandle);
    public void Blur() => ElementCore.Blur(_jsHandle);
}