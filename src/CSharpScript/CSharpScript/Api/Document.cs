using System.Runtime.CompilerServices;
using CSharpScript.Browser.DOM;
using CSharpScript.Browser.Event;
using CSharpScript.Browser.CSS;
using CSharpScript.Browser.Core.Api;

namespace CSharpScript.Browser.Api;

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

    public IntPtr GetElementByIdImpl(string id) => DocumentCore.GetElementByIdImpl(id);

    public IntPtr GetElementsByClassNameImpl(string className) => DocumentCore.GetElementsByClassNameImpl(className);

    public IntPtr GetElementsByTagNameImpl(string tagName) => DocumentCore.GetElementsByTagNameImpl(tagName);

    public IntPtr GetElementsByNameImpl(string name) => DocumentCore.GetElementsByNameImpl(name);

    public IntPtr QuerySelectorImpl(string selectors) => DocumentCore.QuerySelectorImpl(selectors);

    public IntPtr QuerySelectorAllImpl(string selectors) => DocumentCore.QuerySelectorAllImpl(selectors);

    public IntPtr CreateElementImpl(string tagName) => DocumentCore.CreateElementImpl(tagName);

    public IntPtr CreateTextNodeImpl(string text) => DocumentCore.CreateTextNodeImpl(text);

    public IntPtr CreateDocumentFragmentImpl() => DocumentCore.CreateDocumentFragmentImpl();

    public IntPtr CreateCommentImpl(string text) => DocumentCore.CreateCommentImpl(text);

    public IntPtr CreateAttributeImpl(string name) => DocumentCore.CreateAttributeImpl(name);

    public IntPtr CreateEventImpl(string eventType) => DocumentCore.CreateEventImpl(eventType);

    public IntPtr CreateRangeImpl() => DocumentCore.CreateRangeImpl();

    public IntPtr CreateTreeWalkerImpl(IntPtr root, int whatToShow, IntPtr filter, bool entityReferenceExpansion) =>
        DocumentCore.CreateTreeWalkerImpl(root, whatToShow, filter, entityReferenceExpansion);

    public IntPtr CreateNodeIteratorImpl(IntPtr root, int whatToShow, IntPtr filter) =>
        DocumentCore.CreateNodeIteratorImpl(root, whatToShow, filter);

    public string Title
    {
        get => Window.EvalString("document.title");
        set => Window.EvalString($"document.title='{value}'");
    }

    public IntPtr GetBodyImpl() => DocumentCore.GetBodyImpl();
    public IntPtr GetHeadImpl() => DocumentCore.GetHeadImpl();
    public IntPtr GetDocumentElementImpl() => DocumentCore.GetDocumentElementImpl();

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
    public IntPtr ImportNodeImpl(IntPtr importedNode, bool deep) => DocumentCore.ImportNodeImpl(importedNode, deep);
    public IntPtr AdoptNodeImpl(IntPtr node) => DocumentCore.AdoptNodeImpl(node);
    public void Normalize() => DocumentCore.Normalize();
    public IntPtr GetSelectionImpl() => DocumentCore.GetSelectionImpl();

    public bool ExecCommandImpl(string commandId, bool showUI, string? value) =>
        DocumentCore.ExecCommandImpl(commandId, showUI, value);

    public bool QueryCommandEnabledImpl(string commandId) => DocumentCore.QueryCommandEnabledImpl(commandId);
    public bool QueryCommandSupportedImpl(string commandId) => DocumentCore.QueryCommandSupportedImpl(commandId);

    public IntPtr GetActiveElementImpl() => DocumentCore.GetActiveElementImpl();
    public IntPtr GetFullscreenElementImpl() => DocumentCore.GetFullscreenElementImpl();
    public IntPtr GetPointerLockElementImpl() => DocumentCore.GetPointerLockElementImpl();
    public IntPtr GetScriptsImpl() => DocumentCore.GetScriptsImpl();
    public IntPtr GetImagesImpl() => DocumentCore.GetImagesImpl();
    public IntPtr GetLinksImpl() => DocumentCore.GetLinksImpl();
    public IntPtr GetFormsImpl() => DocumentCore.GetFormsImpl();
    public IntPtr GetAnchorsImpl() => DocumentCore.GetAnchorsImpl();
    public IntPtr GetEmbedsImpl() => DocumentCore.GetEmbedsImpl();
    public IntPtr GetPluginsImpl() => DocumentCore.GetPluginsImpl();
    public IntPtr GetStyleSheetsImpl() => DocumentCore.GetStyleSheetsImpl();
    public string GetPreferredStyleSheetSetImpl() => DocumentCore.GetPreferredStyleSheetSetImpl();
    public string GetSelectedStyleSheetSetImpl() => DocumentCore.GetSelectedStyleSheetSetImpl();
    public void SetSelectedStyleSheetSetImpl(string value) => DocumentCore.SetSelectedStyleSheetSetImpl(value);

    public IntPtr GetDocumentChildrenImpl() => DocumentCore.GetDocumentChildrenImpl();
    public int GetDocumentChildElementCountImpl() => DocumentCore.GetDocumentChildElementCountImpl();
    public IntPtr GetDocumentFirstElementChildImpl() => DocumentCore.GetDocumentFirstElementChildImpl();
    public IntPtr GetDocumentLastElementChildImpl() => DocumentCore.GetDocumentLastElementChildImpl();

    public IntPtr DocCreateTreeWalker(IntPtr root, int whatToShow, IntPtr filter) =>
        DocumentCore.DocCreateTreeWalker(root, whatToShow, filter);

    public Element? GetElementById(string id)
    {
        var handle = GetElementByIdImpl(id);
        return handle == IntPtr.Zero ? null : new Element(handle);
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
        return handle == IntPtr.Zero ? null : new Element(handle);
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
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? Head
    {
        get
        {
            var handle = GetHeadImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? DocumentElement
    {
        get
        {
            var handle = GetDocumentElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? ActiveElement
    {
        get
        {
            var handle = GetActiveElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? FullscreenElement
    {
        get
        {
            var handle = GetFullscreenElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? PointerLockElement
    {
        get
        {
            var handle = GetPointerLockElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
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
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? DocumentLastElementChild
    {
        get
        {
            var handle = GetDocumentLastElementChildImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
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