using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.CSS;

[SupportedOSPlatform("browser")]
internal partial class CSSStyleSheetCore
{
    [JSImport("globalThis.CSSStyleSheet.prototype.href")]
    public static partial string? GetHref(IntPtr handle);

    [JSImport("globalThis.CSSStyleSheet.prototype.ownerNode")]
    public static partial JSObject GetOwnerNode(IntPtr handle);

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
}
