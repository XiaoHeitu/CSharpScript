using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.CSS;

[SupportedOSPlatform("browser")]
internal partial class CSSStyleDeclarationCore
{
    [JSImport("globalThis.CSSStyleDeclaration.prototype.cssText")]
    public static partial string GetCssText(IntPtr handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.cssText")]
    public static partial void SetCssText(IntPtr handle, string value);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.parentRule")]
    public static partial IntPtr GetParentRule(IntPtr handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyPriority")]
    public static partial string GetPropertyPriority(IntPtr handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyValue")]
    public static partial string GetPropertyValue(IntPtr handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.item")]
    public static partial string ItemImpl(IntPtr handle, int index);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.removeProperty")]
    public static partial string RemoveProperty(IntPtr handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.setProperty")]
    public static partial void SetProperty(IntPtr handle, string property, string value, string? priority = null);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyCSSValue")]
    public static partial IntPtr GetPropertyCSSValue(IntPtr handle, string property);
}