using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.DOM;
using CSharpScript.Event;
using CSharpScript.CSS;
using CSharpScript.Core.Api;

namespace CSharpScript.Api;

[SupportedOSPlatform("browser")]
public partial class Document
{
    private static Document? _instance;
    private static readonly object _lock = new();
    private static JSObject DocumentObject => JSHost.GlobalThis.GetPropertyAsJSObject("document")!;

    public static Document Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Document();
                }
            }
            return _instance;
        }
    }

    private Document() { }

    public JSObject GetElementByIdImpl(string id) => DocumentCore.GetElementByIdImpl(id);

    public JSObject GetElementsByClassNameImpl(string className) => DocumentCore.GetElementsByClassNameImpl(className);

    public JSObject GetElementsByTagNameImpl(string tagName) => DocumentCore.GetElementsByTagNameImpl(tagName);

    public JSObject GetElementsByNameImpl(string name) => DocumentCore.GetElementsByNameImpl(name);

    public JSObject QuerySelectorImpl(string selectors) => DocumentCore.QuerySelectorImpl(selectors);

    public JSObject QuerySelectorAllImpl(string selectors) => DocumentCore.QuerySelectorAllImpl(selectors);

    public JSObject CreateElementImpl(string tagName) => DocumentCore.CreateElementImpl(tagName);

    public JSObject CreateTextNodeImpl(string text) => DocumentCore.CreateTextNodeImpl(text);

    public JSObject CreateDocumentFragmentImpl() => DocumentCore.CreateDocumentFragmentImpl();

    public JSObject CreateCommentImpl(string text) => DocumentCore.CreateCommentImpl(text);

    public JSObject CreateAttributeImpl(string name) => DocumentCore.CreateAttributeImpl(name);

    public JSObject CreateEventImpl(string eventType) => DocumentCore.CreateEventImpl(eventType);

    public JSObject CreateRangeImpl() => DocumentCore.CreateRangeImpl();

    public JSObject CreateTreeWalkerImpl(JSObject root, int whatToShow, IntPtr filter, bool entityReferenceExpansion) =>
        DocumentCore.CreateTreeWalkerImpl(root, whatToShow, filter, entityReferenceExpansion);

    public JSObject CreateNodeIteratorImpl(JSObject root, int whatToShow, IntPtr filter) =>
        DocumentCore.CreateNodeIteratorImpl(root, whatToShow, filter);

    public string Title
    {
        get => DocumentObject.GetPropertyAsString("title")!;
        set => DocumentObject.SetProperty("title", value);
    }

    public string Cookie
    {
        get => DocumentObject.GetPropertyAsString("cookie")!;
        set => DocumentObject.SetProperty("cookie", value);
    }

    public string Domain => DocumentObject.GetPropertyAsString("domain")!;
    public string Referrer => DocumentObject.GetPropertyAsString("referrer")!;
    public string URL => DocumentObject.GetPropertyAsString("URL")!;
    public string URLUnencoded => DocumentObject.GetPropertyAsString("URLUnencoded")!;
    public string ReadyState => DocumentObject.GetPropertyAsString("readyState")!;
    public bool Hidden => DocumentObject.GetPropertyAsBoolean("hidden");
    public string VisibilityState => DocumentObject.GetPropertyAsString("visibilityState")!;
    public string CharacterSet => DocumentObject.GetPropertyAsString("characterSet")!;
    public string ContentType => DocumentObject.GetPropertyAsString("contentType")!;
    public string InputEncoding => DocumentObject.GetPropertyAsString("inputEncoding")!;
    public string LastModified => DocumentObject.GetPropertyAsString("lastModified")!;
    public string CompatMode => DocumentObject.GetPropertyAsString("compatMode")!;

    public string DesignMode
    {
        get => DocumentObject.GetPropertyAsString("designMode")!;
        set => DocumentObject.SetProperty("designMode", value);
    }

    public void WriteImpl(string? text) => DocumentCore.WriteImpl(text);
    public void WritelnImpl(string? text) => DocumentCore.WritelnImpl(text);

    public IntPtr OpenImpl(string? url, string? name, string? features, bool replace) =>
        DocumentCore.OpenImpl(url, name, features, replace);

    public void Close() => DocumentCore.Close();
    public bool HasFocus() => DocumentCore.HasFocus();
    public JSObject ImportNodeImpl(JSObject importedNode, bool deep) => DocumentCore.ImportNodeImpl(importedNode, deep);
    public JSObject AdoptNodeImpl(JSObject node) => DocumentCore.AdoptNodeImpl(node);
    public void Normalize() => DocumentCore.Normalize();
    public JSObject GetSelectionImpl() => DocumentCore.GetSelectionImpl();

    public bool ExecCommandImpl(string commandId, bool showUI, string? value) =>
        DocumentCore.ExecCommandImpl(commandId, showUI, value);

    public bool QueryCommandEnabledImpl(string commandId) => DocumentCore.QueryCommandEnabledImpl(commandId);
    public bool QueryCommandSupportedImpl(string commandId) => DocumentCore.QueryCommandSupportedImpl(commandId);

    public IntPtr GetStyleSheetsImpl() => DocumentCore.GetStyleSheetsImpl();

    public Element? GetElementById(string id)
    {
        var handle = GetElementByIdImpl(id);
        return handle == null ? null : new Element(handle);
    }

    public HTMLCollection GetElementsByClassName(string className) =>
        new(GetElementsByClassNameImpl(className));

    public HTMLCollection GetElementsByTagName(string tagName) =>
        new(GetElementsByTagNameImpl(tagName));

    public HTMLCollection GetElementsByName(string name) =>
        new(GetElementsByNameImpl(name));

    public Element? QuerySelector(string selectors)
    {
        var handle = QuerySelectorImpl(selectors);
        return handle == null ? null : new Element(handle);
    }

    public NodeList QuerySelectorAll(string selectors) =>
        new(QuerySelectorAllImpl(selectors));

    public Element CreateElement(string tagName) =>
        new(CreateElementImpl(tagName));

    public Element CreateTextNode(string text) =>
        new(CreateTextNodeImpl(text));

    public Element CreateDocumentFragment() =>
        new(CreateDocumentFragmentImpl());

    public Element CreateComment(string text) =>
        new(CreateCommentImpl(text));

    public Attr CreateAttribute(string name) =>
        new(CreateAttributeImpl(name));

    public BrowserEvent CreateEvent(string eventType) =>
        new(CreateEventImpl(eventType));

    public DOMRange CreateRange() =>
        new(CreateRangeImpl());

    public TreeWalker CreateTreeWalker(Element root, int whatToShow, NodeFilter? filter = null, bool entityReferenceExpansion = false) =>
        new(CreateTreeWalkerImpl(root.Handle, whatToShow, filter?.Handle ?? IntPtr.Zero, entityReferenceExpansion));

    public NodeIterator CreateNodeIterator(Element root, int whatToShow, NodeFilter? filter = null) =>
        new(CreateNodeIteratorImpl(root.Handle, whatToShow, filter?.Handle ?? IntPtr.Zero));

    public Element? Body
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("body");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? Head
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("head");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? DocumentElement
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("documentElement");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? ActiveElement
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("activeElement");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? FullscreenElement
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("fullscreenElement");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? PointerLockElement
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("pointerLockElement");
            return handle == null ? null : new Element(handle);
        }
    }

    public HTMLCollection Scripts => new(DocumentObject.GetPropertyAsJSObject("scripts")!);
    public HTMLCollection Images => new(DocumentObject.GetPropertyAsJSObject("images")!);
    public HTMLCollection Links => new(DocumentObject.GetPropertyAsJSObject("links")!);
    public HTMLCollection Forms => new(DocumentObject.GetPropertyAsJSObject("forms")!);
    public HTMLCollection Anchors => new(DocumentObject.GetPropertyAsJSObject("anchors")!);
    public HTMLCollection Embeds => new(DocumentObject.GetPropertyAsJSObject("embeds")!);
    public HTMLCollection Plugins => new(DocumentObject.GetPropertyAsJSObject("plugins")!);
    public StyleSheetList StyleSheets => new(GetStyleSheetsImpl());
    public string PreferredStyleSheetSet => DocumentObject.GetPropertyAsString("preferredStyleSheetSet")!;

    public string SelectedStyleSheetSet
    {
        get => DocumentObject.GetPropertyAsString("selectedStyleSheetSet")!;
        set => DocumentObject.SetProperty("selectedStyleSheetSet", value);
    }

    public HTMLCollection DocumentChildren => new(DocumentObject.GetPropertyAsJSObject("children")!);
    public int DocumentChildElementCount => DocumentObject.GetPropertyAsInt32("childElementCount");

    public Element? DocumentFirstElementChild
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("firstElementChild");
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? DocumentLastElementChild
    {
        get
        {
            var handle = DocumentObject.GetPropertyAsJSObject("lastElementChild");
            return handle == null ? null : new Element(handle);
        }
    }

    public void Open(string? url = null, string? name = null, string? features = null, bool replace = false) =>
        OpenImpl(url, name, features, replace);

    public Element ImportNode(Element importedNode, bool deep = false) =>
        new(ImportNodeImpl(importedNode.Handle, deep));

    public Element AdoptNode(Element node) =>
        new(AdoptNodeImpl(node.Handle));

    public Selection GetSelection() => new(GetSelectionImpl());

    public bool ExecCommand(string commandId, bool showUI = false, string? value = null) =>
        ExecCommandImpl(commandId, showUI, value);

    public bool QueryCommandEnabled(string commandId) => QueryCommandEnabledImpl(commandId);
    public bool QueryCommandSupported(string commandId) => QueryCommandSupportedImpl(commandId);

    public void Write(string? text) => WriteImpl(text);
    public void Writeln(string? text) => WritelnImpl(text);
}
