using System.Runtime.CompilerServices;
using CSharpScript.Core.CSS;

namespace CSharpScript.CSS;

[SupportedOSPlatform("browser")]
public partial class CSSStyleDeclaration
{
    private readonly IntPtr _jsHandle;

    public CSSStyleDeclaration(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public string CssText
    {
        get => CSSStyleDeclarationCore.GetCssText(_jsHandle);
        set => CSSStyleDeclarationCore.SetCssText(_jsHandle, value);
    }

    public int Length => CSSStyleDeclarationCore.GetLength(_jsHandle);

    public CSSRule? ParentRule
    {
        get
        {
            var handle = CSSStyleDeclarationCore.GetParentRule(_jsHandle);
            return handle == IntPtr.Zero ? null : new CSSRule(handle);
        }
    }

    public string GetPropertyPriority(string property) =>
        CSSStyleDeclarationCore.GetPropertyPriority(_jsHandle, property);

    public string GetPropertyValue(string property) =>
        CSSStyleDeclarationCore.GetPropertyValue(_jsHandle, property);

    public string GetItem(int index) => CSSStyleDeclarationCore.ItemImpl(_jsHandle, index);

    public string RemoveProperty(string property) =>
        CSSStyleDeclarationCore.RemoveProperty(_jsHandle, property);

    public void SetProperty(string property, string value, string? priority = null) =>
        CSSStyleDeclarationCore.SetProperty(_jsHandle, property, value, priority);

    public string this[string property]
    {
        get => GetPropertyValue(property);
        set => SetProperty(property, value);
    }
}
