using Microsoft.JSInterop;
using System.Runtime.CompilerServices;

namespace CSharpScript.Browser.Core.Event;

[SupportedOSPlatform("browser")]
internal partial class AnimationEventCore
{
    [JSImport("globalThis.AnimationEvent.prototype.animationName")]
    public static partial string GetAnimationName(IntPtr handle);

    [JSImport("globalThis.AnimationEvent.prototype.elapsedTime")]
    public static partial double GetElapsedTime(IntPtr handle);

    [JSImport("globalThis.AnimationEvent.prototype.pseudoElement")]
    public static partial string GetPseudoElement(IntPtr handle);

    [JSImport("globalThis.AnimationEvent.prototype.initAnimationEvent")]
    public static partial void InitAnimationEvent(IntPtr handle, string type, bool bubbles, bool cancelable, string animationName, double elapsedTime);
}