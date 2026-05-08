using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Api;

[SupportedOSPlatform("browser")]
internal partial class LocationCore
{
    [JSImport("globalThis.location.assign")]
    public static partial void Assign(string url);

    [JSImport("globalThis.location.replace")]
    public static partial void Replace(string url);

    [JSImport("globalThis.location.reload")]
    public static partial void Reload();
}