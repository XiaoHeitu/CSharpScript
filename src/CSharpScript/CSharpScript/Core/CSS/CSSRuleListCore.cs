using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.CSS;

[SupportedOSPlatform("browser")]
internal partial class CSSRuleListCore
{
    [JSImport("globalThis.CSSRuleList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.CSSRuleList.prototype.item")]
    public static partial IntPtr Item(IntPtr handle, int index);
}
