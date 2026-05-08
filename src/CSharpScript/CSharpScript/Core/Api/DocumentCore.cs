using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.Api;

[SupportedOSPlatform("browser")]
internal partial class DocumentCore
{
    [JSImport("globalThis.document.getElementById")]
    public static partial JSObject GetElementByIdImpl(string id);

    [JSImport("globalThis.document.getElementsByClassName")]
    public static partial JSObject GetElementsByClassNameImpl(string className);

    [JSImport("globalThis.document.getElementsByTagName")]
    public static partial JSObject GetElementsByTagNameImpl(string tagName);

    [JSImport("globalThis.document.getElementsByName")]
    public static partial JSObject GetElementsByNameImpl(string name);

    [JSImport("globalThis.document.querySelector")]
    public static partial JSObject QuerySelectorImpl(string selectors);

    [JSImport("globalThis.document.querySelectorAll")]
    public static partial JSObject QuerySelectorAllImpl(string selectors);

    [JSImport("globalThis.document.createElement")]
    public static partial JSObject CreateElementImpl(string tagName);

    [JSImport("globalThis.document.createTextNode")]
    public static partial JSObject CreateTextNodeImpl(string text);

    [JSImport("globalThis.document.createDocumentFragment")]
    public static partial JSObject CreateDocumentFragmentImpl();

    [JSImport("globalThis.document.createComment")]
    public static partial JSObject CreateCommentImpl(string text);

    [JSImport("globalThis.document.createAttribute")]
    public static partial JSObject CreateAttributeImpl(string name);

    [JSImport("globalThis.document.createEvent")]
    public static partial JSObject CreateEventImpl(string eventType);

    [JSImport("globalThis.document.createRange")]
    public static partial JSObject CreateRangeImpl();

    [JSImport("globalThis.document.createTreeWalker")]
    public static partial JSObject CreateTreeWalkerImpl(JSObject root, int whatToShow, IntPtr filter, bool entityReferenceExpansion);

    [JSImport("globalThis.document.createNodeIterator")]
    public static partial JSObject CreateNodeIteratorImpl(JSObject root, int whatToShow, IntPtr filter);

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
    public static partial JSObject ImportNodeImpl(JSObject importedNode, bool deep);

    [JSImport("globalThis.document.adoptNode")]
    public static partial JSObject AdoptNodeImpl(JSObject node);

    [JSImport("globalThis.document.normalize")]
    public static partial void Normalize();

    [JSImport("globalThis.document.getSelection")]
    public static partial JSObject GetSelectionImpl();

    [JSImport("globalThis.document.execCommand")]
    public static partial bool ExecCommandImpl(string commandId, bool showUI, string? value);

    [JSImport("globalThis.document.queryCommandEnabled")]
    public static partial bool QueryCommandEnabledImpl(string commandId);

    [JSImport("globalThis.document.queryCommandSupported")]
    public static partial bool QueryCommandSupportedImpl(string commandId);

    [JSImport("globalThis.document.styleSheets")]
    public static partial IntPtr GetStyleSheetsImpl();
}
