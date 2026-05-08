using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Api;

[SupportedOSPlatform("browser")]
internal partial class HistoryCore
{
    [JSImport("globalThis.history.back")]
    public static partial void Back();

    [JSImport("globalThis.history.forward")]
    public static partial void Forward();

    [JSImport("globalThis.history.go")]
    public static partial void Go(int? delta = null);
}