using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.CSS;

[SupportedOSPlatform("browser")]
internal partial class StyleSheetListCore
{
    [JSImport("globalThis.StyleSheetList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.StyleSheetList.prototype.item")]
    public static partial IntPtr Item(IntPtr handle, int index);
}
