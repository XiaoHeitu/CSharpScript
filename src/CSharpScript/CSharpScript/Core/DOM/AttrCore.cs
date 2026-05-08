using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class AttrCore
{
    [JSImport("globalThis.Attr.prototype.name")]
    public static partial string GetName(JSObject handle);

    [JSImport("globalThis.Attr.prototype.value")]
    public static partial string GetValue(JSObject handle);

    [JSImport("globalThis.Attr.prototype.value")]
    public static partial void SetValue(JSObject handle, string value);

    [JSImport("globalThis.Attr.prototype.namespaceURI")]
    public static partial string? GetNamespaceURI(JSObject handle);

    [JSImport("globalThis.Attr.prototype.prefix")]
    public static partial string? GetPrefix(JSObject handle);

    [JSImport("globalThis.Attr.prototype.localName")]
    public static partial string GetLocalName(JSObject handle);

    [JSImport("globalThis.Attr.prototype.specified")]
    public static partial bool GetSpecified(JSObject handle);

    [JSImport("globalThis.Attr.prototype.ownerElement")]
    public static partial JSObject GetOwnerElement(JSObject handle);
}
