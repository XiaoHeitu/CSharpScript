using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.Event;

namespace CSharpScript.Event;

[SupportedOSPlatform("browser")]
public partial class TouchList
{
    private readonly JSObject _jsHandle;

    public TouchList(JSObject handle)
    {
        _jsHandle = handle;
    }

    public int Length => TouchListCore.GetLength(_jsHandle);

    public Touch? this[int index]
    {
        get
        {
            var handle = TouchListCore.ItemTouchList(_jsHandle, index);
            return handle == null ? null : new Touch(handle);
        }
    }

    public Touch? GetItem(int index)
    {
        var handle = TouchListCore.ItemTouchList(_jsHandle, index);
        return handle == null ? null : new Touch(handle);
    }
}
