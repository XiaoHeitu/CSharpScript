using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Api;

[SupportedOSPlatform("browser")]
internal partial class DocumentCore
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

    [JSImport("globalThis.document.body")]
    public static partial IntPtr GetBodyImpl();

    [JSImport("globalThis.document.head")]
    public static partial IntPtr GetHeadImpl();

    [JSImport("globalThis.document.documentElement")]
    public static partial IntPtr GetDocumentElementImpl();

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
}
