using System.Runtime.CompilerServices;
using CSharpScript.DOM;
using CSharpScript.Core.Event;

namespace CSharpScript.Event;

[SupportedOSPlatform("browser")]
public partial class Touch
{
    private readonly IntPtr _jsHandle;

    public Touch(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Identifier => TouchCore.GetIdentifier(_jsHandle);

    public Element? Target
    {
        get
        {
            var handle = TouchCore.GetTarget(_jsHandle);
            return handle == IntPtr.Zero ? null : new Element(handle);
        }
    }

    public double ClientX => TouchCore.GetClientX(_jsHandle);
    public double ClientY => TouchCore.GetClientY(_jsHandle);
    public double ScreenX => TouchCore.GetScreenX(_jsHandle);
    public double ScreenY => TouchCore.GetScreenY(_jsHandle);
    public double PageX => TouchCore.GetPageX(_jsHandle);
    public double PageY => TouchCore.GetPageY(_jsHandle);
    public double RadiusX => TouchCore.GetRadiusX(_jsHandle);
    public double RadiusY => TouchCore.GetRadiusY(_jsHandle);
    public double RotationAngle => TouchCore.GetRotationAngle(_jsHandle);
    public double Force => TouchCore.GetForce(_jsHandle);
}
