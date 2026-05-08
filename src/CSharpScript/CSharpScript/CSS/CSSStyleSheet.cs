using System.Runtime.CompilerServices;
using CSharpScript.DOM;
using CSharpScript.Core.CSS;

namespace CSharpScript.CSS;

[SupportedOSPlatform("browser")]
public partial class CSSStyleSheet
{
    private readonly IntPtr _jsHandle;

    public CSSStyleSheet(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public string? Href => CSSStyleSheetCore.GetHref(_jsHandle);

    public Element? OwnerNode
    {
        get
        {
            var handle = CSSStyleSheetCore.GetOwnerNode(_jsHandle);
            return handle == null ? null : new Element(handle);
        }
    }

    public string? Title => CSSStyleSheetCore.GetTitle(_jsHandle);

    public bool Disabled
    {
        get => CSSStyleSheetCore.GetDisabled(_jsHandle);
        set => CSSStyleSheetCore.SetDisabled(_jsHandle, value);
    }

    public CSSRuleList CssRules => new(CSSStyleSheetCore.GetCssRules(_jsHandle));

    public int InsertRule(string rule, int index = 0) =>
        CSSStyleSheetCore.InsertRule(_jsHandle, rule, index);

    public void DeleteRule(int index) => CSSStyleSheetCore.DeleteRule(_jsHandle, index);
}
