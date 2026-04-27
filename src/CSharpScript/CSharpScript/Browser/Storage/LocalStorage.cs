namespace CSharpScript.Browser.Storage;

[SupportedOSPlatform("browser")]
public static partial class LocalStorage
{
    [JSImport("globalThis.localStorage.length")]
    public static partial int GetLength();

    [JSImport("globalThis.localStorage.key")]
    public static partial string? Key(int index);

    [JSImport("globalThis.localStorage.getItem")]
    public static partial string? GetItem(string key);

    [JSImport("globalThis.localStorage.setItem")]
    public static partial void SetItem(string key, string value);

    [JSImport("globalThis.localStorage.removeItem")]
    public static partial void RemoveItem(string key);

    [JSImport("globalThis.localStorage.clear")]
    public static partial void Clear();
}
