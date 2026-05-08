using System.Runtime.CompilerServices;
using CSharpScript.Core.CSS;

namespace CSharpScript.CSS;

[SupportedOSPlatform("browser")]
public partial class CSSRule
{
    private readonly IntPtr _jsHandle;

    public CSSRule(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public string CssText
    {
        get => CSSRuleCore.GetCssText(_jsHandle);
        set => CSSRuleCore.SetCssText(_jsHandle, value);
    }

    public CSSStyleSheet? ParentStyleSheet
    {
        get
        {
            var handle = CSSRuleCore.GetParentStyleSheet(_jsHandle);
            return handle == IntPtr.Zero ? null : new CSSStyleSheet(handle);
        }
    }

    public int Type => CSSRuleCore.GetType(_jsHandle);

    public const int STYLE_RULE = 1;
    public const int CHARSET_RULE = 2;
    public const int IMPORT_RULE = 3;
    public const int MEDIA_RULE = 4;
    public const int FONT_FACE_RULE = 5;
    public const int PAGE_RULE = 6;
    public const int KEYFRAMES_RULE = 7;
    public const int KEYFRAME_RULE = 8;
    public const int MARGIN_RULE = 9;
    public const int NAMESPACE_RULE = 10;
}
