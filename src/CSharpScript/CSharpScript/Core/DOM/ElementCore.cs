using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class ElementCore
{
    [JSImport("globalThis.Element.prototype.getAttribute")]
    public static partial string GetAttribute(JSObject handle, string name);

    [JSImport("globalThis.Element.prototype.setAttribute")]
    public static partial void SetAttribute(JSObject handle, string name, string value);

    [JSImport("globalThis.Element.prototype.removeAttribute")]
    public static partial void RemoveAttribute(JSObject handle, string name);

    [JSImport("globalThis.Element.prototype.hasAttribute")]
    public static partial bool HasAttribute(JSObject handle, string name);

    [JSImport("globalThis.Element.prototype.getAttributeNS")]
    public static partial string? GetAttributeNS(JSObject handle, string? ns, string localName);

    [JSImport("globalThis.Element.prototype.setAttributeNS")]
    public static partial void SetAttributeNS(JSObject handle, string? ns, string qualifiedName, string value);

    [JSImport("globalThis.Element.prototype.removeAttributeNS")]
    public static partial void RemoveAttributeNS(JSObject handle, string? ns, string localName);

    [JSImport("globalThis.Element.prototype.id")]
    public static partial string GetId(JSObject handle);

    [JSImport("globalThis.Element.prototype.id")]
    public static partial void SetId(JSObject handle, string value);

    [JSImport("globalThis.Element.prototype.tagName")]
    public static partial string GetTagName(JSObject handle);

    [JSImport("globalThis.Element.prototype.className")]
    public static partial string GetClassName(JSObject handle);

    [JSImport("globalThis.Element.prototype.className")]
    public static partial void SetClassName(JSObject handle, string value);

    [JSImport("globalThis.Element.prototype.innerHTML")]
    public static partial string GetInnerHTML(JSObject handle);

    [JSImport("globalThis.Element.prototype.innerHTML")]
    public static partial void SetInnerHTML(JSObject handle, string value);

    [JSImport("globalThis.Element.prototype.outerHTML")]
    public static partial string GetOuterHTML(JSObject handle);

    [JSImport("globalThis.Element.prototype.outerHTML")]
    public static partial void SetOuterHTML(JSObject handle, string value);

    [JSImport("globalThis.Element.prototype.textContent")]
    public static partial string? GetTextContent(JSObject handle);

    [JSImport("globalThis.Element.prototype.textContent")]
    public static partial void SetTextContent(JSObject handle, string? value);

    [JSImport("globalThis.Element.prototype.innerText")]
    public static partial string GetInnerText(JSObject handle);

    [JSImport("globalThis.Element.prototype.innerText")]
    public static partial void SetInnerText(JSObject handle, string value);

    [JSImport("globalThis.Element.prototype.click")]
    public static partial void Click(JSObject handle);

    [JSImport("globalThis.Element.prototype.focus")]
    public static partial void Focus(JSObject handle);

    [JSImport("globalThis.Element.prototype.blur")]
    public static partial void Blur(JSObject handle);

    [JSImport("globalThis.Element.prototype.scrollIntoView")]
    public static partial void ScrollIntoView(JSObject handle);

    [JSImport("globalThis.Element.prototype.scrollIntoView")]
    public static partial void ScrollIntoViewWithOptions(JSObject handle, bool alignToTop);

    [JSImport("globalThis.Element.prototype.scroll")]
    public static partial void Scroll(JSObject handle, double x, double y);

    [JSImport("globalThis.Element.prototype.scrollTo")]
    public static partial void ScrollTo(JSObject handle, double x, double y);

    [JSImport("globalThis.Element.prototype.scrollBy")]
    public static partial void ScrollBy(JSObject handle, double x, double y);

    [JSImport("globalThis.Element.prototype.getBoundingClientRect")]
    public static partial JSObject GetBoundingClientRectImpl(JSObject handle);

    [JSImport("globalThis.Element.prototype.getClientRects")]
    public static partial JSObject GetClientRects(JSObject handle);

    [JSImport("globalThis.Element.prototype.offsetParent")]
    public static partial JSObject GetOffsetParent(JSObject handle);

    [JSImport("globalThis.Element.prototype.offsetTop")]
    public static partial double GetOffsetTop(JSObject handle);

    [JSImport("globalThis.Element.prototype.offsetLeft")]
    public static partial double GetOffsetLeft(JSObject handle);

    [JSImport("globalThis.Element.prototype.offsetWidth")]
    public static partial double GetOffsetWidth(JSObject handle);

    [JSImport("globalThis.Element.prototype.offsetHeight")]
    public static partial double GetOffsetHeight(JSObject handle);

    [JSImport("globalThis.Element.prototype.scrollTop")]
    public static partial double GetScrollTop(JSObject handle);

    [JSImport("globalThis.Element.prototype.scrollTop")]
    public static partial void SetScrollTop(JSObject handle, double value);

    [JSImport("globalThis.Element.prototype.scrollLeft")]
    public static partial double GetScrollLeft(JSObject handle);

    [JSImport("globalThis.Element.prototype.scrollLeft")]
    public static partial void SetScrollLeft(JSObject handle, double value);

    [JSImport("globalThis.Element.prototype.scrollWidth")]
    public static partial double GetScrollWidth(JSObject handle);

    [JSImport("globalThis.Element.prototype.scrollHeight")]
    public static partial double GetScrollHeight(JSObject handle);

    [JSImport("globalThis.Element.prototype.clientTop")]
    public static partial double GetClientTop(JSObject handle);

    [JSImport("globalThis.Element.prototype.clientLeft")]
    public static partial double GetClientLeft(JSObject handle);

    [JSImport("globalThis.Element.prototype.clientWidth")]
    public static partial double GetClientWidth(JSObject handle);

    [JSImport("globalThis.Element.prototype.clientHeight")]
    public static partial double GetClientHeight(JSObject handle);

    [JSImport("globalThis.Element.prototype.children")]
    public static partial JSObject GetChildren(JSObject handle);

    [JSImport("globalThis.Element.prototype.childElementCount")]
    public static partial int GetChildElementCount(JSObject handle);

    [JSImport("globalThis.Element.prototype.firstElementChild")]
    public static partial JSObject GetFirstElementChild(JSObject handle);

    [JSImport("globalThis.Element.prototype.lastElementChild")]
    public static partial JSObject GetLastElementChild(JSObject handle);

    [JSImport("globalThis.Element.prototype.previousElementSibling")]
    public static partial JSObject GetPreviousElementSibling(JSObject handle);

    [JSImport("globalThis.Element.prototype.nextElementSibling")]
    public static partial JSObject GetNextElementSibling(JSObject handle);

    [JSImport("globalThis.Element.prototype.appendChild")]
    public static partial JSObject AppendChild(JSObject handle, JSObject newChild);

    [JSImport("globalThis.Element.prototype.removeChild")]
    public static partial JSObject RemoveChild(JSObject handle, JSObject oldChild);

    [JSImport("globalThis.Element.prototype.replaceChild")]
    public static partial JSObject ReplaceChild(JSObject handle, JSObject newChild, JSObject oldChild);

    [JSImport("globalThis.Element.prototype.insertBefore")]
    public static partial JSObject InsertBefore(JSObject handle, JSObject newNode, JSObject? referenceNode);

    [JSImport("globalThis.Element.prototype.cloneNode")]
    public static partial JSObject CloneNode(JSObject handle, bool deep = false);

    [JSImport("globalThis.Element.prototype.contains")]
    public static partial bool Contains(JSObject handle, JSObject other);

    [JSImport("globalThis.Element.prototype.closest")]
    public static partial JSObject Closest(JSObject handle, string selectors);

    [JSImport("globalThis.Element.prototype.matches")]
    public static partial bool Matches(JSObject handle, string selectors);

    [JSImport("globalThis.Element.prototype.querySelector")]
    public static partial JSObject QuerySelector(JSObject handle, string selectors);

    [JSImport("globalThis.Element.prototype.querySelectorAll")]
    public static partial JSObject QuerySelectorAll(JSObject handle, string selectors);

    [JSImport("globalThis.Element.prototype.getElementsByClassName")]
    public static partial JSObject GetElementsByClassName(JSObject handle, string className);

    [JSImport("globalThis.Element.prototype.getElementsByTagName")]
    public static partial JSObject GetElementsByTagName(JSObject handle, string tagName);

    [JSImport("globalThis.Element.prototype.hasFocus")]
    public static partial bool HasFocus(JSObject handle);

    [JSImport("globalThis.Element.prototype.addEventListener")]
    public static partial void AddEventListener(JSObject handle, string type, JSObject listener);

    [JSImport("globalThis.Element.prototype.removeEventListener")]
    public static partial void RemoveEventListener(JSObject handle, string type, JSObject listener);

    [JSImport("globalThis.Element.prototype.dispatchEvent")]
    public static partial bool DispatchEvent(JSObject handle, JSObject event_);

    [JSImport("globalThis.Element.prototype.classList")]
    public static partial JSObject GetClassList(JSObject handle);

    [JSImport("globalThis.Element.prototype.style")]
    public static partial JSObject GetStyle(JSObject handle);
}
