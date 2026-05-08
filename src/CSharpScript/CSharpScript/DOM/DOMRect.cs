using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.DOM;

namespace CSharpScript.Browser.DOM;

[SupportedOSPlatform("browser")]
public partial class DOMRect
{
    internal readonly IntPtr _jsHandle;

    public DOMRect(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public double X => DOMRectCore.GetX(_jsHandle);
    public double Y => DOMRectCore.GetY(_jsHandle);
    public double Width => DOMRectCore.GetWidth(_jsHandle);
    public double Height => DOMRectCore.GetHeight(_jsHandle);
    public double Top => DOMRectCore.GetTop(_jsHandle);
    public double Right => DOMRectCore.GetRight(_jsHandle);
    public double Bottom => DOMRectCore.GetBottom(_jsHandle);
    public double Left => DOMRectCore.GetLeft(_jsHandle);
}