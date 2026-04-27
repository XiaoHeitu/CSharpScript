namespace CSharpScript.Browser.Storage;

[SupportedOSPlatform("browser")]
public static partial class SessionStorage
{
    [JSImport("globalThis.sessionStorage.length")]
    public static partial int GetLength();

    [JSImport("globalThis.sessionStorage.key")]
    public static partial string? Key(int index);

    [JSImport("globalThis.sessionStorage.getItem")]
    public static partial string? GetItem(string key);

    [JSImport("globalThis.sessionStorage.setItem")]
    public static partial void SetItem(string key, string value);

    [JSImport("globalThis.sessionStorage.removeItem")]
    public static partial void RemoveItem(string key);

    [JSImport("globalThis.sessionStorage.clear")]
    public static partial void Clear();
}
