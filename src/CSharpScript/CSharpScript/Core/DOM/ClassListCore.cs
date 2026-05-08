using Microsoft.JSInterop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace CSharpScript.Core.DOM;

[SupportedOSPlatform("browser")]
internal partial class ClassListCore
{
    [JSImport("globalThis.DOMTokenList.prototype.length")]
    public static partial int GetLength(JSObject handle);

    [JSImport("globalThis.DOMTokenList.prototype.item")]
    public static partial string? Item(JSObject handle, int index);

    [JSImport("globalThis.DOMTokenList.prototype.contains")]
    public static partial bool Contains(JSObject handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.add")]
    public static partial void Add(JSObject handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.remove")]
    public static partial void Remove(JSObject handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.toggle")]
    public static partial bool Toggle(JSObject handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.replace")]
    public static partial bool Replace(JSObject handle, string oldToken, string newToken);

    [JSImport("globalThis.DOMTokenList.prototype.supports")]
    public static partial bool Supports(JSObject handle, string token);

    [JSImport("globalThis.DOMTokenList.prototype.value")]
    public static partial string GetValue(JSObject handle);

    [JSImport("globalThis.DOMTokenList.prototype.value")]
    public static partial void SetValue(JSObject handle, string value);
}
