using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.CSS;

[SupportedOSPlatform("browser")]
internal partial class CSSStyleDeclarationCore
{
    [JSImport("globalThis.CSSStyleDeclaration.prototype.cssText")]
    public static partial string GetCssText(JSObject handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.cssText")]
    public static partial void SetCssText(JSObject handle, string value);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.length")]
    public static partial int GetLength(JSObject handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.parentRule")]
    public static partial IntPtr GetParentRule(JSObject handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyPriority")]
    public static partial string GetPropertyPriority(JSObject handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyValue")]
    public static partial string GetPropertyValue(JSObject handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.item")]
    public static partial string ItemImpl(JSObject handle, int index);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.removeProperty")]
    public static partial string RemoveProperty(JSObject handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.setProperty")]
    public static partial void SetProperty(JSObject handle, string property, string value, string? priority = null);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyCSSValue")]
    public static partial IntPtr GetPropertyCSSValue(JSObject handle, string property);
}
