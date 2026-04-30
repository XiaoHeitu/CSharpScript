namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class History
{
    public static int Length => Window.EvalInt("history.length");

    [JSImport("globalThis.history.back")]
    public static partial void Back();

    [JSImport("globalThis.history.forward")]
    public static partial void Forward();

    [JSImport("globalThis.history.go")]
    public static partial void Go(int? delta = null);
}