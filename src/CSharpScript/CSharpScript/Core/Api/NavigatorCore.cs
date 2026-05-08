using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Api;

[SupportedOSPlatform("browser")]
internal partial class NavigatorCore
{
    [JSImport("globalThis.navigator.javaEnabled")]
    public static partial bool JavaEnabled();
}
