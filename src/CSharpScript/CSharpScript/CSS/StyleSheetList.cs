using System.Runtime.CompilerServices;
using CSharpScript.Core.CSS;

namespace CSharpScript.CSS;

[SupportedOSPlatform("browser")]
public partial class StyleSheetList
{
    private readonly IntPtr _jsHandle;

    public StyleSheetList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Length => StyleSheetListCore.GetLength(_jsHandle);

    public CSSStyleSheet? this[int index]
    {
        get
        {
            var handle = StyleSheetListCore.ItemStyleSheetList(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new CSSStyleSheet(handle);
        }
    }

    public CSSStyleSheet? GetItem(int index)
    {
        var handle = StyleSheetListCore.ItemStyleSheetList(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new CSSStyleSheet(handle);
    }
}
