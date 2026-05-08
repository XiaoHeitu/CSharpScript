using CSharpScript.Core.DOM;
using CSharpScript.CSS;
using CSharpScript.Event;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class Element
{
    private readonly JSObject _jsHandle;

    public Element(JSObject handle)
    {
        _jsHandle = handle;
    }

    public string Id
    {
        get => _jsHandle.GetPropertyAsString("id")!;
        set => _jsHandle.SetProperty("id", value);
    }

    public string TagName => _jsHandle.GetPropertyAsString("tagName")!;

    public string ClassName
    {
        get => _jsHandle.GetPropertyAsString("className")!;
        set => _jsHandle.SetProperty("className", value);
    }

    public string InnerHTML
    {
        get => _jsHandle.GetPropertyAsString("innerHTML")!;
        set => _jsHandle.SetProperty("innerHTML", value);
    }

    public string OuterHTML
    {
        get => _jsHandle.GetPropertyAsString("outerHTML")!;
        set => _jsHandle.SetProperty("outerHTML", value);
    }

    public string? TextContent
    {
        get => _jsHandle.GetPropertyAsString("textContent");
        set => _jsHandle.SetProperty("textContent", value);
    }

    public string InnerText
    {
        get => _jsHandle.GetPropertyAsString("innerText")!;
        set => _jsHandle.SetProperty("innerText", value);
    }

    public DOMRect GetBoundingClientRect() => new(ElementCore.GetBoundingClientRectImpl(_jsHandle));

    public JSObject? OffsetParent => _jsHandle.GetPropertyAsJSObject("offsetParent");
    public double OffsetTop => _jsHandle.GetPropertyAsDouble("offsetTop");
    public double OffsetLeft => _jsHandle.GetPropertyAsDouble("offsetLeft");
    public double OffsetWidth => _jsHandle.GetPropertyAsDouble("offsetWidth");
    public double OffsetHeight => _jsHandle.GetPropertyAsDouble("offsetHeight");

    public double ScrollTop
    {
        get => _jsHandle.GetPropertyAsDouble("scrollTop");
        set => _jsHandle.SetProperty("scrollTop", value);
    }

    public double ScrollLeft
    {
        get => _jsHandle.GetPropertyAsDouble("scrollLeft");
        set => _jsHandle.SetProperty("scrollLeft", value);
    }

    public double ScrollWidth => _jsHandle.GetPropertyAsDouble("scrollWidth");
    public double ScrollHeight => _jsHandle.GetPropertyAsDouble("scrollHeight");

    public double ClientTop => _jsHandle.GetPropertyAsDouble("clientTop");
    public double ClientLeft => _jsHandle.GetPropertyAsDouble("clientLeft");
    public double ClientWidth => _jsHandle.GetPropertyAsDouble("clientWidth");
    public double ClientHeight => _jsHandle.GetPropertyAsDouble("clientHeight");

    public HTMLCollection Children => new(_jsHandle.GetPropertyAsJSObject("children")!);

    public int ChildElementCount => _jsHandle.GetPropertyAsInt32("childElementCount");

    public Element? FirstElementChild
    {
        get
        {
            var handle = _jsHandle.GetPropertyAsJSObject("firstElementChild");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? LastElementChild
    {
        get
        {
            var handle = _jsHandle.GetPropertyAsJSObject("lastElementChild");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? PreviousElementSibling
    {
        get
        {
            var handle = _jsHandle.GetPropertyAsJSObject("previousElementSibling");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? NextElementSibling
    {
        get
        {
            var handle = _jsHandle.GetPropertyAsJSObject("nextElementSibling");
            return handle == null ? null : new Element(handle);
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
        return handle == null ? null : new Element(handle);
    }

    public bool Matches(string selectors) => ElementCore.Matches(_jsHandle, selectors);
    public Element? QuerySelector(string selectors)
    {
        var handle = ElementCore.QuerySelector(_jsHandle, selectors);
        return handle == null ? null : new Element(handle);
    }

    public HTMLCollection QuerySelectorAll(string selectors) => new(ElementCore.QuerySelectorAll(_jsHandle, selectors));
    public HTMLCollection GetElementsByClassName(string className) => new(ElementCore.GetElementsByClassName(_jsHandle, className));
    public HTMLCollection GetElementsByTagName(string tagName) => new(ElementCore.GetElementsByTagName(_jsHandle, tagName));

    public bool HasFocus() => ElementCore.HasFocus(_jsHandle);

    public JSObject Handle => _jsHandle;

    public ClassList ClassList => new(ElementCore.GetClassList(_jsHandle));

    public void AddEventListener(string type, Action listener) =>
        ElementCore.AddEventListener(_jsHandle, type, null!);

    public void RemoveEventListener(string type, Action listener) =>
        ElementCore.RemoveEventListener(_jsHandle, type, null!);

    public void AddEventListener<T>(string type, Action<T> listener) =>
        ElementCore.AddEventListener(_jsHandle, type, null!);

    public void RemoveEventListener<T>(string type, Action<T> listener) =>
        ElementCore.RemoveEventListener(_jsHandle, type, null!);

    public bool DispatchEvent(BrowserEvent e) => ElementCore.DispatchEvent(_jsHandle, e.Handle);

    public CSSStyleDeclaration Style => new(ElementCore.GetStyle(_jsHandle));

    public void Click() => ElementCore.Click(_jsHandle);
    public void Focus() => ElementCore.Focus(_jsHandle);
    public void Blur() => ElementCore.Blur(_jsHandle);
}
