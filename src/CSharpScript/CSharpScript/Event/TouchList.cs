using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Event;

namespace CSharpScript.Browser.Event;

[SupportedOSPlatform("browser")]
public partial class TouchList
{
    private readonly IntPtr _jsHandle;

    public TouchList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Length => TouchListCore.GetLength(_jsHandle);

    public Touch? this[int index]
    {
        get
        {
            var handle = TouchListCore.ItemTouchList(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new Touch(handle);
        }
    }

    public Touch? GetItem(int index)
    {
        var handle = TouchListCore.ItemTouchList(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new Touch(handle);
    }
}