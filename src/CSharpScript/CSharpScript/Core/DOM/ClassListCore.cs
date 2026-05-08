using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class ClassListCore
{
    [JSImport("globalThis.DOMTokenList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.DOMTokenList.prototype.item")]
    public static partial string? Item(IntPtr handle, int index);

    [JSImport("globalThis.DOMTokenList.prototype.contains")]
    public static partial bool Contains(IntPtr handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.add")]
    public static partial void Add(IntPtr handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.remove")]
    public static partial void Remove(IntPtr handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.toggle")]
    public static partial bool Toggle(IntPtr handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.replace")]
    public static partial bool Replace(IntPtr handle, string oldToken, string newToken);

    [JSImport("globalThis.DOMTokenList.prototype.supports")]
    public static partial bool Supports(IntPtr handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.value")]
    public static partial string GetValue(IntPtr handle);

    [JSImport("globalThis.DOMTokenList.prototype.value")]
    public static partial void SetValue(IntPtr handle, string value);
}