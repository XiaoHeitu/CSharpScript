namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Document
{
    [JSImport("globalThis.document.getElementById")]
    public static partial IntPtr GetElementByIdImpl(string id);

    [JSImport("globalThis.document.getElementsByClassName")]
    public static partial IntPtr GetElementsByClassNameImpl(string className);

    [JSImport("globalThis.document.getElementsByTagName")]
    public static partial IntPtr GetElementsByTagNameImpl(string tagName);

    [JSImport("globalThis.document.getElementsByName")]
    public static partial IntPtr GetElementsByNameImpl(string name);

    [JSImport("globalThis.document.querySelector")]
    public static partial IntPtr QuerySelectorImpl(string selectors);

    [JSImport("globalThis.document.querySelectorAll")]
    public static partial IntPtr QuerySelectorAllImpl(string selectors);

    [JSImport("globalThis.document.createElement")]
    public static partial IntPtr CreateElementImpl(string tagName);

    [JSImport("globalThis.document.createTextNode")]
    public static partial IntPtr CreateTextNodeImpl(string text);

    [JSImport("globalThis.document.createDocumentFragment")]
    public static partial IntPtr CreateDocumentFragmentImpl();

    [JSImport("globalThis.document.createComment")]
    public static partial IntPtr CreateCommentImpl(string text);

    [JSImport("globalThis.document.createAttribute")]
    public static partial IntPtr CreateAttributeImpl(string name);

    [JSImport("globalThis.document.createEvent")]
    public static partial IntPtr CreateEventImpl(string eventType);

    [JSImport("globalThis.document.createRange")]
    public static partial IntPtr CreateRangeImpl();

    [JSImport("globalThis.document.createTreeWalker")]
    public static partial IntPtr CreateTreeWalkerImpl(IntPtr root, int whatToShow, IntPtr filter, bool entityReferenceExpansion);

    [JSImport("globalThis.document.createNodeIterator")]
    public static partial IntPtr CreateNodeIteratorImpl(IntPtr root, int whatToShow, IntPtr filter);


    public static string Title
    {
        get => Reflect.EvalString("document.title");
        set => Reflect.EvalString($"document.title='{value}'");
    }

    [JSImport("globalThis.document.body")]
    public static partial IntPtr GetBodyImpl();

    [JSImport("globalThis.document.head")]
    public static partial IntPtr GetHeadImpl();

    [JSImport("globalThis.document.documentElement")]
    public static partial IntPtr GetDocumentElementImpl();

    public static string Cookie
    {
        get => Reflect.EvalString("document.cookie");
        set => Reflect.EvalString($"document.cookie='{value}'");
    }

    public static string Domain
    {
        get => Reflect.EvalString("document.domain");
    }

    public static string Referrer => Reflect.EvalString("document.referrer");

    public static string URL => Reflect.EvalString("document.URL");

    public static string URLUnencoded => Reflect.EvalString("document.URLUnencoded");

    public static string ReadyState => Reflect.EvalString("document.readyState");

    public static bool Hidden => Reflect.EvalBool("document.hidden");

    public static string VisibilityState => Reflect.EvalString("document.visibilityState");

    public static string CharacterSet => Reflect.EvalString("document.characterSet");

    public static string ContentType => Reflect.EvalString("document.contentType");

    public static string InputEncoding => Reflect.EvalString("document.inputEncoding");

    public static string LastModified => Reflect.EvalString("document.lastModified");

    public static string CompatMode => Reflect.EvalString("document.compatMode");

    public static string DesignMode
    {
        get => Reflect.EvalString("document.designMode");
        set => Reflect.EvalString($"document.designMode='{value}'");
    }

    [JSImport("globalThis.document.write")]
    public static partial void WriteImpl(string? text);

    [JSImport("globalThis.document.writeln")]
    public static partial void WritelnImpl(string? text);

    [JSImport("globalThis.document.open")]
    public static partial IntPtr OpenImpl(string? url, string? name, string? features, bool replace);

    [JSImport("globalThis.document.close")]
    public static partial void Close();

    [JSImport("globalThis.document.hasFocus")]
    public static partial bool HasFocus();

    [JSImport("globalThis.document.importNode")]
    public static partial IntPtr ImportNodeImpl(IntPtr importedNode, bool deep);

    [JSImport("globalThis.document.adoptNode")]
    public static partial IntPtr AdoptNodeImpl(IntPtr node);

    [JSImport("globalThis.document.normalize")]
    public static partial void Normalize();

    [JSImport("globalThis.document.getSelection")]
    public static partial IntPtr GetSelectionImpl();

    [JSImport("globalThis.document.execCommand")]
    public static partial bool ExecCommandImpl(string commandId, bool showUI, string? value);

    [JSImport("globalThis.document.queryCommandEnabled")]
    public static partial bool QueryCommandEnabledImpl(string commandId);

    [JSImport("globalThis.document.queryCommandSupported")]
    public static partial bool QueryCommandSupportedImpl(string commandId);

    [JSImport("globalThis.document.activeElement")]
    public static partial IntPtr GetActiveElementImpl();

    [JSImport("globalThis.document.fullscreenElement")]
    public static partial IntPtr GetFullscreenElementImpl();

    [JSImport("globalThis.document.pointerLockElement")]
    public static partial IntPtr GetPointerLockElementImpl();

    [JSImport("globalThis.document.scripts")]
    public static partial IntPtr GetScriptsImpl();

    [JSImport("globalThis.document.images")]
    public static partial IntPtr GetImagesImpl();

    [JSImport("globalThis.document.links")]
    public static partial IntPtr GetLinksImpl();

    [JSImport("globalThis.document.forms")]
    public static partial IntPtr GetFormsImpl();

    [JSImport("globalThis.document.anchors")]
    public static partial IntPtr GetAnchorsImpl();

    [JSImport("globalThis.document.embeds")]
    public static partial IntPtr GetEmbedsImpl();

    [JSImport("globalThis.document.plugins")]
    public static partial IntPtr GetPluginsImpl();

    [JSImport("globalThis.document.styleSheets")]
    public static partial IntPtr GetStyleSheetsImpl();

    [JSImport("globalThis.document.preferredStyleSheetSet")]
    public static partial string GetPreferredStyleSheetSetImpl();

    [JSImport("globalThis.document.selectedStyleSheetSet")]
    public static partial string GetSelectedStyleSheetSetImpl();

    [JSImport("globalThis.document.selectedStyleSheetSet")]
    public static partial void SetSelectedStyleSheetSetImpl(string value);

    [JSImport("globalThis.document.children")]
    public static partial IntPtr GetDocumentChildrenImpl();

    [JSImport("globalThis.document.childElementCount")]
    public static partial int GetDocumentChildElementCountImpl();

    [JSImport("globalThis.document.firstElementChild")]
    public static partial IntPtr GetDocumentFirstElementChildImpl();

    [JSImport("globalThis.document.lastElementChild")]
    public static partial IntPtr GetDocumentLastElementChildImpl();

    [JSImport("globalThis.document.createTreeWalker")]
    public static partial IntPtr DocCreateTreeWalker(IntPtr root, [JSMarshalAs<JSType.Number>] int whatToShow, IntPtr filter);

    public static Element? GetElementById(string id)
    {
        var handle = GetElementByIdImpl(id);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public static HTMLCollection GetElementsByClassName(string className) =>
        new(GetElementsByClassNameImpl(className));

    public static HTMLCollection GetElementsByTagName(string tagName) =>
        new(GetElementsByTagNameImpl(tagName));

    public static HTMLCollection GetElementsByName(string name) =>
        new(GetElementsByNameImpl(name));

    public static Element? QuerySelector(string selectors)
    {
        var handle = QuerySelectorImpl(selectors);
        return handle == IntPtr.Zero ? null : new Element(handle);
    }

    public static NodeList QuerySelectorAll(string selectors) =>
        new(QuerySelectorAllImpl(selectors));

    public static Element CreateElement(string tagName) =>
        new(CreateElementImpl(tagName));

    public static Element CreateTextNode(string text) =>
        new(CreateTextNodeImpl(text));

    public static Element CreateDocumentFragment() =>
        new(CreateDocumentFragmentImpl());

    public static Element CreateComment(string text) =>
        new(CreateCommentImpl(text));

    public static Attr CreateAttribute(string name) =>
        new(CreateAttributeImpl(name));

    public static BrowserEvent CreateEvent(string eventType) =>
        new(CreateEventImpl(eventType));

    public static DOMRange CreateRange() =>
        new(CreateRangeImpl());

    public static TreeWalker CreateTreeWalker(Element root, int whatToShow, NodeFilter? filter = null, bool entityReferenceExpansion = false) =>
        new(CreateTreeWalkerImpl(root.Handle, whatToShow, filter?.Handle ?? IntPtr.Zero, entityReferenceExpansion));

    public static NodeIterator CreateNodeIterator(Element root, int whatToShow, NodeFilter? filter = null) =>
        new(CreateNodeIteratorImpl(root.Handle, whatToShow, filter?.Handle ?? IntPtr.Zero));

    public static Element? Body
    {
        get
        {
            var handle = GetBodyImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static Element? Head
    {
        get
        {
            var handle = GetHeadImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static Element? DocumentElement
    {
        get
        {
            var handle = GetDocumentElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static Element? ActiveElement
    {
        get
        {
            var handle = GetActiveElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static Element? FullscreenElement
    {
        get
        {
            var handle = GetFullscreenElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static Element? PointerLockElement
    {
        get
        {
            var handle = GetPointerLockElementImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static HTMLCollection Scripts => new(GetScriptsImpl());
    public static HTMLCollection Images => new(GetImagesImpl());
    public static HTMLCollection Links => new(GetLinksImpl());
    public static HTMLCollection Forms => new(GetFormsImpl());
    public static HTMLCollection Anchors => new(GetAnchorsImpl());
    public static HTMLCollection Embeds => new(GetEmbedsImpl());
    public static HTMLCollection Plugins => new(GetPluginsImpl());
    public static StyleSheetList StyleSheets => new(GetStyleSheetsImpl());
    public static string PreferredStyleSheetSet => GetPreferredStyleSheetSetImpl();
    public static string SelectedStyleSheetSet
    {
        get => GetSelectedStyleSheetSetImpl();
        set => SetSelectedStyleSheetSetImpl(value);
    }

    public static HTMLCollection DocumentChildren => new(GetDocumentChildrenImpl());
    public static int DocumentChildElementCount => GetDocumentChildElementCountImpl();

    public static Element? DocumentFirstElementChild
    {
        get
        {
            var handle = GetDocumentFirstElementChildImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static Element? DocumentLastElementChild
    {
        get
        {
            var handle = GetDocumentLastElementChildImpl();
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public static void Open(string? url = null, string? name = null, string? features = null, bool replace = false) =>
        OpenImpl(url, name, features, replace);

    public static Element ImportNode(Element importedNode, bool deep = false) =>
        new(ImportNodeImpl(importedNode.Handle, deep));

    public static Element AdoptNode(Element node) =>
        new(AdoptNodeImpl(node.Handle));

    public static Selection GetSelection() => new(GetSelectionImpl());

    public static bool ExecCommand(string commandId, bool showUI = false, string? value = null) =>
        ExecCommandImpl(commandId, showUI, value);

    public static bool QueryCommandEnabled(string commandId) => QueryCommandEnabledImpl(commandId);
    public static bool QueryCommandSupported(string commandId) => QueryCommandSupportedImpl(commandId);

    public static void Write(string? text) => WriteImpl(text);
    public static void Writeln(string? text) => WritelnImpl(text);
}

public partial class DOMRange
{
    internal readonly IntPtr _jsHandle;
    public DOMRange(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.Range.prototype.startContainer")]
    public static partial IntPtr GetStartContainer(IntPtr handle);

    [JSImport("globalThis.Range.prototype.startOffset")]
    public static partial int GetStartOffset(IntPtr handle);

    [JSImport("globalThis.Range.prototype.endContainer")]
    public static partial IntPtr GetEndContainer(IntPtr handle);

    [JSImport("globalThis.Range.prototype.endOffset")]
    public static partial int GetEndOffset(IntPtr handle);

    [JSImport("globalThis.Range.prototype.commonAncestorContainer")]
    public static partial IntPtr GetCommonAncestorContainer(IntPtr handle);

    [JSImport("globalThis.Range.prototype.collapsed")]
    public static partial bool GetCollapsed(IntPtr handle);

    [JSImport("globalThis.Range.prototype.compareBoundaryPoints")]
    public static partial int CompareBoundaryPoints(IntPtr handle, string how, IntPtr sourceRange);

    [JSImport("globalThis.Range.prototype.deleteContents")]
    public static partial void DeleteContents(IntPtr handle);

    [JSImport("globalThis.Range.prototype.extractContents")]
    public static partial IntPtr ExtractContents(IntPtr handle);

    [JSImport("globalThis.Range.prototype.cloneContents")]
    public static partial IntPtr CloneContents(IntPtr handle);

    [JSImport("globalThis.Range.prototype.insertNode")]
    public static partial void InsertNode(IntPtr handle, IntPtr newNode);

    [JSImport("globalThis.Range.prototype.surroundContents")]
    public static partial void SurroundContents(IntPtr handle, IntPtr newParent);

    [JSImport("globalThis.Range.prototype.cloneRange")]
    public static partial IntPtr CloneRange(IntPtr handle);

    [JSImport("globalThis.Range.prototype.toString")]
    public static partial string RangeToString(IntPtr handle);

    public Element? StartContainer { get { var h = GetStartContainer(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public int StartOffset => GetStartOffset(_jsHandle);
    public Element? EndContainer { get { var h = GetEndContainer(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public int EndOffset => GetEndOffset(_jsHandle);
    public Element? CommonAncestorContainer { get { var h = GetCommonAncestorContainer(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public bool Collapsed => GetCollapsed(_jsHandle);
    public int CompareBoundaryPoints(string how, DOMRange sourceRange) => CompareBoundaryPoints(_jsHandle, how, sourceRange._jsHandle);
    public void DeleteContents() => DeleteContents(_jsHandle);
    public Element ExtractContents() => new(ExtractContents(_jsHandle));
    public Element CloneContents() => new(CloneContents(_jsHandle));
    public void InsertNode(Element newNode) => InsertNode(_jsHandle, newNode._jsHandle);
    public void SurroundContents(Element newParent) => SurroundContents(_jsHandle, newParent._jsHandle);
    public DOMRange CloneRange() => new(CloneRange(_jsHandle));
    public override string ToString() => RangeToString(_jsHandle);
    public IntPtr Handle => _jsHandle;
}

public partial class TreeWalker
{
    internal readonly IntPtr _jsHandle;
    public TreeWalker(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.TreeWalker.prototype.root")]
    public static partial IntPtr GetRoot(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.currentNode")]
    public static partial IntPtr GetCurrentNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.currentNode")]
    public static partial void SetCurrentNode(IntPtr handle, IntPtr value);

    [JSImport("globalThis.TreeWalker.prototype.nextNode")]
    public static partial IntPtr NextNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.previousNode")]
    public static partial IntPtr PreviousNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.nextSibling")]
    public static partial IntPtr NextSibling(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.previousSibling")]
    public static partial IntPtr PreviousSibling(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.parentNode")]
    public static partial IntPtr ParentNode(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.firstChild")]
    public static partial IntPtr FirstChild(IntPtr handle);

    [JSImport("globalThis.TreeWalker.prototype.lastChild")]
    public static partial IntPtr LastChild(IntPtr handle);

    public Element? Root { get { var h = GetRoot(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public Element? CurrentNode { get { var h = GetCurrentNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } set => SetCurrentNode(_jsHandle, value?._jsHandle ?? IntPtr.Zero); }
    public Element? NextNode() { var h = NextNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? PreviousNode() { var h = PreviousNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? NextSibling() { var h = NextSibling(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? PreviousSibling() { var h = PreviousSibling(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? ParentNode() { var h = ParentNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? FirstChild() { var h = FirstChild(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? LastChild() { var h = LastChild(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public IntPtr Handle => _jsHandle;
}

public partial class NodeIterator
{
    internal readonly IntPtr _jsHandle;
    public NodeIterator(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.NodeIterator.prototype.root")]
    public static partial IntPtr GetRoot(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.referenceNode")]
    public static partial IntPtr GetReferenceNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.pointerBeforeReferenceNode")]
    public static partial bool GetPointerBeforeReferenceNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.nextNode")]
    public static partial IntPtr NextNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.previousNode")]
    public static partial IntPtr PreviousNode(IntPtr handle);

    [JSImport("globalThis.NodeIterator.prototype.detach")]
    public static partial void Detach(IntPtr handle);

    public Element? Root { get { var h = GetRoot(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public Element? ReferenceNode { get { var h = GetReferenceNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public bool PointerBeforeReferenceNode => GetPointerBeforeReferenceNode(_jsHandle);
    public Element? NextNode() { var h = NextNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public Element? PreviousNode() { var h = PreviousNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); }
    public void Detach() => Detach(_jsHandle);
    public IntPtr Handle => _jsHandle;
}

public partial class NodeFilter
{
    internal readonly IntPtr _jsHandle;
    public NodeFilter(IntPtr handle) => _jsHandle = handle;
    public static int FILTER_ACCEPT => 1;
    public static int FILTER_REJECT => 2;
    public static int FILTER_SKIP => 3;
    public static int SHOW_ALL => unchecked((int)0xFFFFFFFF);
    public static int SHOW_ELEMENT => 0x00000001;
    public IntPtr Handle => _jsHandle;
}

public partial class StyleSheetList
{
    internal readonly IntPtr _jsHandle;
    public StyleSheetList(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.StyleSheetList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.StyleSheetList.prototype.item")]
    public static partial IntPtr ItemImpl(IntPtr handle, int index);

    public int Length => GetLength(_jsHandle);
    public CSSStyleSheet? this[int index] { get { var h = ItemImpl(_jsHandle, index); return h == IntPtr.Zero ? null : new CSSStyleSheet(h); } }
    public IntPtr Handle => _jsHandle;
}

public partial class CSSStyleSheet
{
    internal readonly IntPtr _jsHandle;
    public CSSStyleSheet(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.CSSStyleSheet.prototype.href")]
    public static partial string? GetHref(IntPtr handle);

    [JSImport("globalThis.CSSStyleSheet.prototype.ownerNode")]
    public static partial IntPtr GetOwnerNode(IntPtr handle);

    [JSImport("globalThis.CSSStyleSheet.prototype.title")]
    public static partial string? GetTitle(IntPtr handle);

    [JSImport("globalThis.CSSStyleSheet.prototype.disabled")]
    public static partial bool GetDisabled(IntPtr handle);

    [JSImport("globalThis.CSSStyleSheet.prototype.disabled")]
    public static partial void SetDisabled(IntPtr handle, bool value);

    [JSImport("globalThis.CSSStyleSheet.prototype.cssRules")]
    public static partial IntPtr GetCssRules(IntPtr handle);

    [JSImport("globalThis.CSSStyleSheet.prototype.insertRule")]
    public static partial int InsertRule(IntPtr handle, string rule, int index);

    [JSImport("globalThis.CSSStyleSheet.prototype.deleteRule")]
    public static partial void DeleteRule(IntPtr handle, int index);

    public string? Href => GetHref(_jsHandle);
    public Element? OwnerNode { get { var h = GetOwnerNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public string? Title => GetTitle(_jsHandle);
    public bool Disabled { get => GetDisabled(_jsHandle); set => SetDisabled(_jsHandle, value); }
    public CSSRuleList CssRules => new(GetCssRules(_jsHandle));
    public int InsertRule(string rule, int index = 0) => InsertRule(_jsHandle, rule, index);
    public void DeleteRule(int index) => DeleteRule(_jsHandle, index);
    public IntPtr Handle => _jsHandle;
}

public partial class CSSRuleList
{
    internal readonly IntPtr _jsHandle;
    public CSSRuleList(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.CSSRuleList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.CSSRuleList.prototype.item")]
    public static partial IntPtr ItemImpl(IntPtr handle, int index);

    public int Length => GetLength(_jsHandle);
    public CSSRule? this[int index] { get { var h = ItemImpl(_jsHandle, index); return h == IntPtr.Zero ? null : new CSSRule(h); } }
    public IntPtr Handle => _jsHandle;
}

public partial class CSSRule
{
    internal readonly IntPtr _jsHandle;
    public CSSRule(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.CSSRule.prototype.cssText")]
    public static partial string GetCssText(IntPtr handle);

    [JSImport("globalThis.CSSRule.prototype.cssText")]
    public static partial void SetCssText(IntPtr handle, string value);

    [JSImport("globalThis.CSSRule.prototype.parentStyleSheet")]
    public static partial IntPtr GetParentStyleSheet(IntPtr handle);

    [JSImport("globalThis.CSSRule.prototype.type")]
    public static partial int GetType(IntPtr handle);

    public string CssText { get => GetCssText(_jsHandle); set => SetCssText(_jsHandle, value); }
    public CSSStyleSheet? ParentStyleSheet { get { var h = GetParentStyleSheet(_jsHandle); return h == IntPtr.Zero ? null : new CSSStyleSheet(h); } }
    public int Type => GetType(_jsHandle);
    public IntPtr Handle => _jsHandle;
}

public partial class Selection
{
    internal readonly IntPtr _jsHandle;
    public Selection(IntPtr handle) => _jsHandle = handle;

    [JSImport("globalThis.Selection.prototype.anchorNode")]
    public static partial IntPtr GetAnchorNode(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.anchorOffset")]
    public static partial int GetAnchorOffset(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.focusNode")]
    public static partial IntPtr GetFocusNode(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.focusOffset")]
    public static partial int GetFocusOffset(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.isCollapsed")]
    public static partial bool GetIsCollapsed(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.rangeCount")]
    public static partial int GetRangeCount(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.toString")]
    public static partial string SelectionToString(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.getRangeAt")]
    public static partial IntPtr GetRangeAt(IntPtr handle, int index);

    [JSImport("globalThis.Selection.prototype.collapse")]
    public static partial void Collapse(IntPtr handle, IntPtr node, int offset);

    [JSImport("globalThis.Selection.prototype.removeAllRanges")]
    public static partial void RemoveAllRanges(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.addRange")]
    public static partial void AddRange(IntPtr handle, IntPtr range);

    [JSImport("globalThis.Selection.prototype.deleteFromDocument")]
    public static partial void DeleteFromDocument(IntPtr handle);

    [JSImport("globalThis.Selection.prototype.containsNode")]
    public static partial bool ContainsNode(IntPtr handle, IntPtr node, bool partial);

    public Element? AnchorNode { get { var h = GetAnchorNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public int AnchorOffset => GetAnchorOffset(_jsHandle);
    public Element? FocusNode { get { var h = GetFocusNode(_jsHandle); return h == IntPtr.Zero ? null : new Element(h); } }
    public int FocusOffset => GetFocusOffset(_jsHandle);
    public bool IsCollapsed => GetIsCollapsed(_jsHandle);
    public int RangeCount => GetRangeCount(_jsHandle);

    public DOMRange? GetRangeAt(int index) { var h = GetRangeAt(_jsHandle, index); return h == IntPtr.Zero ? null : new DOMRange(h); }
    public void Collapse(Element? node, int offset = 0) => Collapse(_jsHandle, node?._jsHandle ?? IntPtr.Zero, offset);
    public void RemoveAllRanges() => RemoveAllRanges(_jsHandle);
    public void AddRange(DOMRange range) => AddRange(_jsHandle, range._jsHandle);
    public void DeleteFromDocument() => DeleteFromDocument(_jsHandle);
    public bool ContainsNode(Element node, bool partial = false) => ContainsNode(_jsHandle, node._jsHandle, partial);
    public override string ToString() => SelectionToString(_jsHandle);
    public IntPtr Handle => _jsHandle;
}
