using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class ElementCore
{
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

    [JSImport("globalThis.Element.prototype.addEventListener")]
    public static partial void AddEventListener(IntPtr handle, string type, IntPtr listener);

    [JSImport("globalThis.Element.prototype.removeEventListener")]
    public static partial void RemoveEventListener(IntPtr handle, string type, IntPtr listener);

    [JSImport("globalThis.Element.prototype.dispatchEvent")]
    public static partial bool DispatchEvent(IntPtr handle, IntPtr event_);

    [JSImport("globalThis.Element.prototype.classList")]
    public static partial IntPtr GetClassList(IntPtr handle);

    [JSImport("globalThis.Element.prototype.style")]
    public static partial IntPtr GetStyle(IntPtr handle);
}