namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class History
{
    [JSImport("globalThis.history.length")]
    public static partial int GetLength();

    [JSImport("globalThis.history.back")]
    public static partial void Back();

    [JSImport("globalThis.history.forward")]
    public static partial void Forward();

    [JSImport("globalThis.history.go")]
    public static partial void Go(int? delta = null);
}