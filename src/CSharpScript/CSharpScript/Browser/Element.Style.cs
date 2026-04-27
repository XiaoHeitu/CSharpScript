namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public partial class Element
{
    [JSImport("globalThis.Element.prototype.style")]
    public static partial IntPtr GetStyle(IntPtr handle);

    public CSSStyleDeclaration Style => new(GetStyle(_jsHandle));
}

[SupportedOSPlatform("browser")]
public partial class CSSStyleDeclaration
{
    internal readonly IntPtr _jsHandle;

    public CSSStyleDeclaration(IntPtr handle)
    {
        _jsHandle = handle;
    }

    [JSImport("globalThis.CSSStyleDeclaration.prototype.cssText")]
    public static partial string GetCssText(IntPtr handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.cssText")]
    public static partial void SetCssText(IntPtr handle, string value);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyValue")]
    public static partial string GetPropertyValue(IntPtr handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.setProperty")]
    public static partial void SetProperty(IntPtr handle, string property, string value, string? priority);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.removeProperty")]
    public static partial string RemoveProperty(IntPtr handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.getPropertyPriority")]
    public static partial string GetPropertyPriority(IntPtr handle, string property);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.item")]
    public static partial string? ItemImpl(IntPtr handle, int index);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.length")]
    public static partial int GetLength(IntPtr handle);

    [JSImport("globalThis.CSSStyleDeclaration.prototype.parentRule")]
    public static partial IntPtr GetParentRule(IntPtr handle);

    [JSImport("globalThis.getComputedStyle")]
    public static partial IntPtr GetComputedStyle(IntPtr element, string? pseudoElement);

    public string CssText
    {
        get => GetCssText(_jsHandle);
        set => SetCssText(_jsHandle, value);
    }

    public string Width
    {
        get => GetCssText(_jsHandle);
        set => SetCssText(_jsHandle, value);
    }

    public string Height
    {
        get => GetCssText(_jsHandle);
        set => SetCssText(_jsHandle, value);
    }

    public string Display
    {
        get => GetPropertyValue(_jsHandle, "display");
        set => SetProperty(_jsHandle, "display", value, null);
    }

    public string Visibility
    {
        get => GetPropertyValue(_jsHandle, "visibility");
        set => SetProperty(_jsHandle, "visibility", value, null);
    }

    public string Position
    {
        get => GetPropertyValue(_jsHandle, "position");
        set => SetProperty(_jsHandle, "position", value, null);
    }

    public string Top
    {
        get => GetPropertyValue(_jsHandle, "top");
        set => SetProperty(_jsHandle, "top", value, null);
    }

    public string Bottom
    {
        get => GetPropertyValue(_jsHandle, "bottom");
        set => SetProperty(_jsHandle, "bottom", value, null);
    }

    public string Left
    {
        get => GetPropertyValue(_jsHandle, "left");
        set => SetProperty(_jsHandle, "left", value, null);
    }

    public string Right
    {
        get => GetPropertyValue(_jsHandle, "right");
        set => SetProperty(_jsHandle, "right", value, null);
    }

    public string Margin
    {
        get => GetPropertyValue(_jsHandle, "margin");
        set => SetProperty(_jsHandle, "margin", value, null);
    }

    public string Padding
    {
        get => GetPropertyValue(_jsHandle, "padding");
        set => SetProperty(_jsHandle, "padding", value, null);
    }

    public string Color
    {
        get => GetPropertyValue(_jsHandle, "color");
        set => SetProperty(_jsHandle, "color", value, null);
    }

    public string BackgroundColor
    {
        get => GetPropertyValue(_jsHandle, "background-color");
        set => SetProperty(_jsHandle, "background-color", value, null);
    }

    public string BackgroundImage
    {
        get => GetPropertyValue(_jsHandle, "background-image");
        set => SetProperty(_jsHandle, "background-image", value, null);
    }

    public string FontSize
    {
        get => GetPropertyValue(_jsHandle, "font-size");
        set => SetProperty(_jsHandle, "font-size", value, null);
    }

    public string FontFamily
    {
        get => GetPropertyValue(_jsHandle, "font-family");
        set => SetProperty(_jsHandle, "font-family", value, null);
    }

    public string ZIndex
    {
        get => GetPropertyValue(_jsHandle, "z-index");
        set => SetProperty(_jsHandle, "z-index", value, null);
    }

    public string Opacity
    {
        get => GetPropertyValue(_jsHandle, "opacity");
        set => SetProperty(_jsHandle, "opacity", value, null);
    }

    public string Overflow
    {
        get => GetPropertyValue(_jsHandle, "overflow");
        set => SetProperty(_jsHandle, "overflow", value, null);
    }

    public string Cursor
    {
        get => GetPropertyValue(_jsHandle, "cursor");
        set => SetProperty(_jsHandle, "cursor", value, null);
    }

    public string Transform
    {
        get => GetPropertyValue(_jsHandle, "transform");
        set => SetProperty(_jsHandle, "transform", value, null);
    }

    public string Flex
    {
        get => GetPropertyValue(_jsHandle, "flex");
        set => SetProperty(_jsHandle, "flex", value, null);
    }

    public string FlexDirection
    {
        get => GetPropertyValue(_jsHandle, "flex-direction");
        set => SetProperty(_jsHandle, "flex-direction", value, null);
    }

    public string JustifyContent
    {
        get => GetPropertyValue(_jsHandle, "justify-content");
        set => SetProperty(_jsHandle, "justify-content", value, null);
    }

    public string AlignItems
    {
        get => GetPropertyValue(_jsHandle, "align-items");
        set => SetProperty(_jsHandle, "align-items", value, null);
    }

    public int Length => GetLength(_jsHandle);

    public string? this[int index] => ItemImpl(_jsHandle, index);

    public string GetPropertyValue(string property) => GetPropertyValue(_jsHandle, property);

    public void SetProperty(string property, string value, string? priority = null) =>
        SetProperty(_jsHandle, property, value, priority);

    public string RemoveProperty(string property) => RemoveProperty(_jsHandle, property);

    public string GetPropertyPriority(string property) => GetPropertyPriority(_jsHandle, property);

    public static CSSStyleDeclaration GetComputedStyle(Element element, string? pseudoElement = null) =>
        new(GetComputedStyle(element.Handle, pseudoElement));

    public IntPtr Handle => _jsHandle;
}
