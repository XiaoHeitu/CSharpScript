using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.CSS;

[SupportedOSPlatform("browser")]
internal partial class CSSRuleCore
{
    [JSImport("globalThis.CSSRule.prototype.cssText")]
    public static partial string GetCssText(IntPtr handle);

    [JSImport("globalThis.CSSRule.prototype.cssText")]
    public static partial void SetCssText(IntPtr handle, string value);

    [JSImport("globalThis.CSSRule.prototype.parentStyleSheet")]
    public static partial IntPtr GetParentStyleSheet(IntPtr handle);

    [JSImport("globalThis.CSSRule.prototype.type")]
    public static partial int GetType(IntPtr handle);
}
