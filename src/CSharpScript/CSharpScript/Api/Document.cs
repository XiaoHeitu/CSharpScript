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
        get => Window.EvalString("document.title");
        set => Window.EvalString($"document.title='{value}'");
    }

    public JSObject GetBodyImpl() => DocumentCore.GetBodyImpl();
    public JSObject GetHeadImpl() => DocumentCore.GetHeadImpl();
    public JSObject GetDocumentElementImpl() => DocumentCore.GetDocumentElementImpl();

    public string Cookie
    {
        get => Window.EvalString("document.cookie");
        set => Window.EvalString($"document.cookie='{value}'");
    }

    public string Domain => Window.EvalString("document.domain");
    public string Referrer => Window.EvalString("document.referrer");
    public string URL => Window.EvalString("document.URL");
    public string URLUnencoded => Window.EvalString("document.URLUnencoded");
    public string ReadyState => Window.EvalString("document.readyState");
    public bool Hidden => Window.EvalBool("document.hidden");
    public string VisibilityState => Window.EvalString("document.visibilityState");
    public string CharacterSet => Window.EvalString("document.characterSet");
    public string ContentType => Window.EvalString("document.contentType");
    public string InputEncoding => Window.EvalString("document.inputEncoding");
    public string LastModified => Window.EvalString("document.lastModified");
    public string CompatMode => Window.EvalString("document.compatMode");

    public string DesignMode
    {
        get => Window.EvalString("document.designMode");
        set => Window.EvalString($"document.designMode='{value}'");
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

    public JSObject GetActiveElementImpl() => DocumentCore.GetActiveElementImpl();
    public JSObject GetFullscreenElementImpl() => DocumentCore.GetFullscreenElementImpl();
    public JSObject GetPointerLockElementImpl() => DocumentCore.GetPointerLockElementImpl();
    public JSObject GetScriptsImpl() => DocumentCore.GetScriptsImpl();
    public JSObject GetImagesImpl() => DocumentCore.GetImagesImpl();
    public JSObject GetLinksImpl() => DocumentCore.GetLinksImpl();
    public JSObject GetFormsImpl() => DocumentCore.GetFormsImpl();
    public JSObject GetAnchorsImpl() => DocumentCore.GetAnchorsImpl();
    public JSObject GetEmbedsImpl() => DocumentCore.GetEmbedsImpl();
    public JSObject GetPluginsImpl() => DocumentCore.GetPluginsImpl();
    public IntPtr GetStyleSheetsImpl() => DocumentCore.GetStyleSheetsImpl();
    public string GetPreferredStyleSheetSetImpl() => DocumentCore.GetPreferredStyleSheetSetImpl();
    public string GetSelectedStyleSheetSetImpl() => DocumentCore.GetSelectedStyleSheetSetImpl();
    public void SetSelectedStyleSheetSetImpl(string value) => DocumentCore.SetSelectedStyleSheetSetImpl(value);

    public JSObject GetDocumentChildrenImpl() => DocumentCore.GetDocumentChildrenImpl();
    public int GetDocumentChildElementCountImpl() => DocumentCore.GetDocumentChildElementCountImpl();
    public JSObject GetDocumentFirstElementChildImpl() => DocumentCore.GetDocumentFirstElementChildImpl();
    public JSObject GetDocumentLastElementChildImpl() => DocumentCore.GetDocumentLastElementChildImpl();

    public JSObject DocCreateTreeWalker(JSObject root, int whatToShow, IntPtr filter) =>
        DocumentCore.DocCreateTreeWalker(root, whatToShow, filter);

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
            var handle = GetBodyImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? Head
    {
        get
        {
            var handle = GetHeadImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? DocumentElement
    {
        get
        {
            var handle = GetDocumentElementImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? ActiveElement
    {
        get
        {
            var handle = GetActiveElementImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? FullscreenElement
    {
        get
        {
            var handle = GetFullscreenElementImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? PointerLockElement
    {
        get
        {
            var handle = GetPointerLockElementImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public HTMLCollection Scripts => new(GetScriptsImpl());
    public HTMLCollection Images => new(GetImagesImpl());
    public HTMLCollection Links => new(GetLinksImpl());
    public HTMLCollection Forms => new(GetFormsImpl());
    public HTMLCollection Anchors => new(GetAnchorsImpl());
    public HTMLCollection Embeds => new(GetEmbedsImpl());
    public HTMLCollection Plugins => new(GetPluginsImpl());
    public StyleSheetList StyleSheets => new(GetStyleSheetsImpl());
    public string PreferredStyleSheetSet => GetPreferredStyleSheetSetImpl();

    public string SelectedStyleSheetSet
    {
        get => GetSelectedStyleSheetSetImpl();
        set => SetSelectedStyleSheetSetImpl(value);
    }

    public HTMLCollection DocumentChildren => new(GetDocumentChildrenImpl());
    public int DocumentChildElementCount => GetDocumentChildElementCountImpl();

    public Element? DocumentFirstElementChild
    {
        get
        {
            var handle = GetDocumentFirstElementChildImpl();
            return handle == null ? null : new Element(handle);
        }
    }

    public Element? DocumentLastElementChild
    {
        get
        {
            var handle = GetDocumentLastElementChildImpl();
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
