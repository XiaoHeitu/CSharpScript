using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class TransitionEventCore
{
    [JSImport("globalThis.TransitionEvent.prototype.propertyName")]
    public static partial string GetPropertyName(IntPtr handle);

    [JSImport("globalThis.TransitionEvent.prototype.elapsedTime")]
    public static partial double GetElapsedTime(IntPtr handle);

    [JSImport("globalThis.TransitionEvent.prototype.pseudoElement")]
    public static partial string GetPseudoElement(IntPtr handle);

    [JSImport("globalThis.TransitionEvent.prototype.initTransitionEvent")]
    public static partial void InitTransitionEvent(IntPtr handle, string type, bool bubbles, bool cancelable, string propertyName, double elapsedTime);
}