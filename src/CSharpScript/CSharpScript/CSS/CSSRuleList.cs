using System.Runtime.CompilerServices;
using CSharpScript.Core.CSS;

namespace CSharpScript.CSS;

[SupportedOSPlatform("browser")]
public partial class CSSRuleList
{
    private readonly IntPtr _jsHandle;

    public CSSRuleList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public int Length => CSSRuleListCore.GetLength(_jsHandle);

    public CSSRule? this[int index]
    {
        get
        {
            var handle = CSSRuleListCore.ItemCSSRuleList(_jsHandle, index);
            return handle == IntPtr.Zero ? null : new CSSRule(handle);
        }
    }

    public CSSRule? GetItem(int index)
    {
        var handle = CSSRuleListCore.ItemCSSRuleList(_jsHandle, index);
        return handle == IntPtr.Zero ? null : new CSSRule(handle);
    }
}
