using System.Runtime.CompilerServices;
using CSharpScript.Browser.DOM;
using CSharpScript.Browser.Core.DOM;
using CSharpScript.Browser.Core.Event;

namespace CSharpScript.Browser.Event;

[SupportedOSPlatform("browser")]
public partial class BrowserEvent
{
    protected internal readonly IntPtr _jsHandle;

    public BrowserEvent(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public string Type => EventCore.GetType(_jsHandle);

    public Element? Target
    {
        get
        {
            var handle = EventCore.GetTarget(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? CurrentTarget
    {
        get
        {
            var handle = EventCore.GetCurrentTarget(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public int EventPhase => EventCore.GetEventPhase(_jsHandle);
    public bool Bubbles => EventCore.GetBubbles(_jsHandle);
    public bool Cancelable => EventCore.GetCancelable(_jsHandle);
    public bool DefaultPrevented => EventCore.GetDefaultPrevented(_jsHandle);
    public bool Composed => EventCore.GetComposed(_jsHandle);
    public double TimeStamp => EventCore.GetTimeStamp(_jsHandle);
    public bool IsTrusted => EventCore.GetIsTrusted(_jsHandle);

    public IntPtr Handle => _jsHandle;

    public void StopPropagation() => EventCore.StopPropagation(_jsHandle);
    public void StopImmediatePropagation() => EventCore.StopImmediatePropagation(_jsHandle);
    public void PreventDefault() => EventCore.PreventDefault(_jsHandle);

    public void InitEvent(string type, bool bubbles = false, bool cancelable = false) =>
        EventCore.InitEvent(_jsHandle, type, bubbles, cancelable);

    public const int NONE = 0;
    public const int CAPTURING_PHASE = 1;
    public const int AT_TARGET = 2;
    public const int BUBBLING_PHASE = 3;
}