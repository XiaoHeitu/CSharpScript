namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public partial class BrowserEvent
{
    internal readonly IntPtr _jsHandle;

    public BrowserEvent(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.Event.prototype.type")]
    public static partial string GetType(IntPtr handle);

    [JSImport("globalThis.Event.prototype.target")]
    public static partial IntPtr GetTarget(IntPtr handle);

    [JSImport("globalThis.Event.prototype.currentTarget")]
    public static partial IntPtr GetCurrentTarget(IntPtr handle);

    [JSImport("globalThis.Event.prototype.eventPhase")]
    public static partial int GetEventPhase(IntPtr handle);

    [JSImport("globalThis.Event.prototype.bubbles")]
    public static partial bool GetBubbles(IntPtr handle);

    [JSImport("globalThis.Event.prototype.cancelable")]
    public static partial bool GetCancelable(IntPtr handle);

    [JSImport("globalThis.Event.prototype.defaultPrevented")]
    public static partial bool GetDefaultPrevented(IntPtr handle);

    [JSImport("globalThis.Event.prototype.composed")]
    public static partial bool GetComposed(IntPtr handle);

    [JSImport("globalThis.Event.prototype.timeStamp")]
    public static partial double GetTimeStamp(IntPtr handle);

    [JSImport("globalThis.Event.prototype.isTrusted")]
    public static partial bool GetIsTrusted(IntPtr handle);

    [JSImport("globalThis.Event.prototype.preventDefault")]
    public static partial void PreventDefault(IntPtr handle);

    [JSImport("globalThis.Event.prototype.stopImmediatePropagation")]
    public static partial void StopImmediatePropagation(IntPtr handle);

    [JSImport("globalThis.Event.prototype.stopPropagation")]
    public static partial void StopPropagation(IntPtr handle);

    [JSImport("globalThis.Event.prototype.composedPath")]
    public static partial IntPtr GetComposedPath(IntPtr handle);

    public string Type => GetType(_jsHandle);

    public Element? Target
    {
        get
        {
            var handle = GetTarget(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public Element? CurrentTarget
    {
        get
        {
            var handle = GetCurrentTarget(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public int EventPhase => GetEventPhase(_jsHandle);
    public bool Bubbles => GetBubbles(_jsHandle);
    public bool Cancelable => GetCancelable(_jsHandle);
    public bool DefaultPrevented => GetDefaultPrevented(_jsHandle);
    public bool Composed => GetComposed(_jsHandle);
    public double TimeStamp => GetTimeStamp(_jsHandle);
    public bool IsTrusted => GetIsTrusted(_jsHandle);

    public static int CAPTURING_PHASE => 1;
    public static int AT_TARGET => 2;
    public static int BUBBLING_PHASE => 3;

    public void PreventDefault() => PreventDefault(_jsHandle);
    public void StopImmediatePropagation() => StopImmediatePropagation(_jsHandle);
    public void StopPropagation() => StopPropagation(_jsHandle);

    public NodeList ComposedPath() => new(GetComposedPath(_jsHandle));

    public IntPtr Handle => _jsHandle;
}

[SupportedOSPlatform("browser")]
public partial class MouseEvent : BrowserEvent
{
    public MouseEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.MouseEvent.prototype.screenX")]
    public static partial int GetScreenX(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.screenY")]
    public static partial int GetScreenY(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.clientX")]
    public static partial int GetClientX(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.clientY")]
    public static partial int GetClientY(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.ctrlKey")]
    public static partial bool GetCtrlKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.shiftKey")]
    public static partial bool GetShiftKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.altKey")]
    public static partial bool GetAltKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.metaKey")]
    public static partial bool GetMetaKey(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.button")]
    public static partial short GetButton(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.buttons")]
    public static partial short GetButtons(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.relatedTarget")]
    public static partial IntPtr GetRelatedTarget(IntPtr handle);

    [JSImport("globalThis.MouseEvent.prototype.region")]
    public static partial string? GetRegion(IntPtr handle);

    public int ScreenX => GetScreenX(_jsHandle);
    public int ScreenY => GetScreenY(_jsHandle);
    public int ClientX => GetClientX(_jsHandle);
    public int ClientY => GetClientY(_jsHandle);
    public bool CtrlKey => GetCtrlKey(_jsHandle);
    public bool ShiftKey => GetShiftKey(_jsHandle);
    public bool AltKey => GetAltKey(_jsHandle);
    public bool MetaKey => GetMetaKey(_jsHandle);
    public short Button => GetButton(_jsHandle);
    public short Buttons => GetButtons(_jsHandle);

    public Element? RelatedTarget
    {
        get
        {
            var handle = GetRelatedTarget(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public string? Region => GetRegion(_jsHandle);

    public static short MOUSEBUTTON_LEFT => 0;
    public static short MOUSEBUTTON_MIDDLE => 1;
    public static short MOUSEBUTTON_RIGHT => 2;
}

[SupportedOSPlatform("browser")]
public partial class KeyboardEvent : BrowserEvent
{
    public KeyboardEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.KeyboardEvent.prototype.key")]
    public static partial string GetKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.code")]
    public static partial string GetCode(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.location")]
    public static partial int GetLocation(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.ctrlKey")]
    public static partial bool GetCtrlKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.shiftKey")]
    public static partial bool GetShiftKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.altKey")]
    public static partial bool GetAltKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.metaKey")]
    public static partial bool GetMetaKey(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.repeat")]
    public static partial bool GetRepeat(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.isComposing")]
    public static partial bool GetIsComposing(IntPtr handle);

    [JSImport("globalThis.KeyboardEvent.prototype.keyCode")]
    public static partial int GetKeyCode(IntPtr handle);

    public string Key => GetKey(_jsHandle);
    public string Code => GetCode(_jsHandle);
    public int Location => GetLocation(_jsHandle);
    public bool CtrlKeyValue => GetCtrlKey(_jsHandle);
    public bool ShiftKeyValue => GetShiftKey(_jsHandle);
    public bool AltKeyValue => GetAltKey(_jsHandle);
    public bool MetaKeyValue => GetMetaKey(_jsHandle);
    public bool Repeat => GetRepeat(_jsHandle);
    public bool IsComposing => GetIsComposing(_jsHandle);
    public int KeyCodeValue => GetKeyCode(_jsHandle);

    public static int DOM_KEY_LOCATION_STANDARD => 0;
    public static int DOM_KEY_LOCATION_LEFT => 1;
    public static int DOM_KEY_LOCATION_RIGHT => 2;
    public static int DOM_KEY_LOCATION_NUMPAD => 3;
}

[SupportedOSPlatform("browser")]
public partial class Touch
{
    [JSImport("globalThis.Touch.prototype.identifier")]
    public static partial int GetIdentifier(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.target")]
    public static partial IntPtr GetTarget(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.clientX")]
    public static partial double GetClientX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.clientY")]
    public static partial double GetClientY(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.screenX")]
    public static partial double GetScreenX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.screenY")]
    public static partial double GetScreenY(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.pageX")]
    public static partial double GetPageX(IntPtr handle);

    [JSImport("globalThis.Touch.prototype.pageY")]
    public static partial double GetPageY(IntPtr handle);
}

[SupportedOSPlatform("browser")]
public partial class TouchList
{
    internal readonly IntPtr _jsHandle;

    public TouchList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.TouchList.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.TouchList.prototype.item")]
    public static partial IntPtr Item(IntPtr handle, int index);

    public int Length => GetLength(_jsHandle);
    public IntPtr Handle => _jsHandle;
}

[SupportedOSPlatform("browser")]
public partial class TouchEvent : BrowserEvent
{
    public TouchEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.TouchEvent.prototype.touches")]
    public static partial IntPtr GetTouches(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.targetTouches")]
    public static partial IntPtr GetTargetTouches(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.changedTouches")]
    public static partial IntPtr GetChangedTouches(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.ctrlKey")]
    public static partial bool GetCtrlKey(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.shiftKey")]
    public static partial bool GetShiftKey(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.altKey")]
    public static partial bool GetAltKey(IntPtr handle);

    [JSImport("globalThis.TouchEvent.prototype.metaKey")]
    public static partial bool GetMetaKey(IntPtr handle);

    public TouchList Touches => new(GetTouches(_jsHandle));
    public TouchList TargetTouches => new(GetTargetTouches(_jsHandle));
    public TouchList ChangedTouches => new(GetChangedTouches(_jsHandle));
    public bool CtrlKeyValue => GetCtrlKey(_jsHandle);
    public bool ShiftKeyValue => GetShiftKey(_jsHandle);
    public bool AltKeyValue => GetAltKey(_jsHandle);
    public bool MetaKeyValue => GetMetaKey(_jsHandle);
}

[SupportedOSPlatform("browser")]
public partial class DragEvent : MouseEvent
{
    public DragEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.DragEvent.prototype.dataTransfer")]
    public static partial IntPtr GetDataTransfer(IntPtr handle);

    public IntPtr DataTransferHandle => GetDataTransfer(_jsHandle);
}

[SupportedOSPlatform("browser")]
public partial class ProgressEvent : BrowserEvent
{
    public ProgressEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.ProgressEvent.prototype.lengthComputable")]
    public static partial bool GetLengthComputable(IntPtr handle);

    [JSImport("globalThis.ProgressEvent.prototype.loaded")]
    public static partial double GetLoaded(IntPtr handle);

    [JSImport("globalThis.ProgressEvent.prototype.total")]
    public static partial double GetTotal(IntPtr handle);

    public bool LengthComputable => GetLengthComputable(_jsHandle);
    public double Loaded => GetLoaded(_jsHandle);
    public double Total => GetTotal(_jsHandle);
}

[SupportedOSPlatform("browser")]
public partial class ErrorEvent : BrowserEvent
{
    public ErrorEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.ErrorEvent.prototype.message")]
    public static partial string GetMessage(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.filename")]
    public static partial string GetFilename(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.lineno")]
    public static partial int GetLineno(IntPtr handle);

    [JSImport("globalThis.ErrorEvent.prototype.colno")]
    public static partial int GetColno(IntPtr handle);

    public string Message => GetMessage(_jsHandle);
    public string Filename => GetFilename(_jsHandle);
    public int Lineno => GetLineno(_jsHandle);
    public int Colno => GetColno(_jsHandle);
}

[SupportedOSPlatform("browser")]
public partial class AnimationEvent : BrowserEvent
{
    public AnimationEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.AnimationEvent.prototype.animationName")]
    public static partial string GetAnimationName(IntPtr handle);

    [JSImport("globalThis.AnimationEvent.prototype.elapsedTime")]
    public static partial double GetElapsedTime(IntPtr handle);

    [JSImport("globalThis.AnimationEvent.prototype.pseudoElement")]
    public static partial string GetPseudoElement(IntPtr handle);

    public string AnimationName => GetAnimationName(_jsHandle);
    public double ElapsedTime => GetElapsedTime(_jsHandle);
    public string PseudoElement => GetPseudoElement(_jsHandle);
}

[SupportedOSPlatform("browser")]
public partial class TransitionEvent : BrowserEvent
{
    public TransitionEvent(IntPtr handle) : base(handle)
    {
    }

    [JSImport("globalThis.TransitionEvent.prototype.propertyName")]
    public static partial string GetPropertyName(IntPtr handle);

    [JSImport("globalThis.TransitionEvent.prototype.elapsedTime")]
    public static partial double GetElapsedTime(IntPtr handle);

    [JSImport("globalThis.TransitionEvent.prototype.pseudoElement")]
    public static partial string GetPseudoElement(IntPtr handle);

    public string PropertyName => GetPropertyName(_jsHandle);
    public double ElapsedTime => GetElapsedTime(_jsHandle);
    public string PseudoElement => GetPseudoElement(_jsHandle);
}
