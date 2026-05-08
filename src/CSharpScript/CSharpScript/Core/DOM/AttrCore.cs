using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class AttrCore
{
    [JSImport("globalThis.Attr.prototype.name")]
    public static partial string GetName(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.value")]
    public static partial string GetValue(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.value")]
    public static partial void SetValue(IntPtr handle, string value);

    [JSImport("globalThis.Attr.prototype.namespaceURI")]
    public static partial string? GetNamespaceURI(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.prefix")]
    public static partial string? GetPrefix(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.localName")]
    public static partial string GetLocalName(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.specified")]
    public static partial bool GetSpecified(IntPtr handle);

    [JSImport("globalThis.Attr.prototype.ownerElement")]
    public static partial IntPtr GetOwnerElement(IntPtr handle);
}
