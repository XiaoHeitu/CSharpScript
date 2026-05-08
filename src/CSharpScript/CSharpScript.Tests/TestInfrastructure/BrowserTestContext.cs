using System.Text.Json;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using CSharpScript.Api;
using CSharpScript.DOM;
using CSharpScript.Event;
using CSharpScript.CSS;

namespace CSharpScript.Tests.TestInfrastructure;

[SupportedOSPlatform("browser")]
internal static class BrowserTestContext
{
    public static void Reset() => TestJs.ResetState();

    public static IReadOnlyList<JsonElement> GetCalls(string name)
    {
        var json = TestJs.GetCallLogJson(name);
        return JsonSerializer.Deserialize<List<JsonElement>>(json) ?? new List<JsonElement>();
    }

    public static Element GetElement(string selector)
    {
        var handle = TestJs.GetFixtureElement(selector);
        Assert.NotNull(handle);
        return new Element(handle!);
    }

    public static NamedNodeMap GetAttributes(string selector)
    {
        var handle = TestJs.GetFixtureAttributes(selector);
        Assert.NotNull(handle);
        return new NamedNodeMap(handle!);
    }

    public static Touch CreateTouch(string selector) => new(TestJs.GetTouchObject(selector));

    public static TouchList CreateTouchList(string selector) => new(TestJs.GetTouchListObject(selector));

    public static Selection GetSelection() => new(TestJs.GetSelectionObject());

    public static void SelectFixtureText() => TestJs.SetTextSelection();

    public static StyleSheetList GetStyleSheetList() => new(TestJs.GetStyleSheetListHandle());

    public static CSSStyleSheet GetStyleSheet(int index) => new(TestJs.GetStyleSheetHandle(index));

    public static CSSRule GetCssRule(int sheetIndex, int ruleIndex) => new(TestJs.GetCssRuleHandle(sheetIndex, ruleIndex));

    public static CSSRuleList GetCssRuleList(int sheetIndex) => new(TestJs.GetCssRuleListHandle(sheetIndex));

    public static CSSStyleSheet GetFixtureStyleSheet() => new(TestJs.GetFixtureStyleSheetHandle());

    public static CSSRule GetFixtureCssRule(int index) => new(TestJs.GetFixtureCssRuleHandle(index));

    public static CSSRuleList GetFixtureCssRuleList() => new(TestJs.GetFixtureCssRuleListHandle());

    public static BrowserEvent CreateBrowserEvent(string type) => new(TestJs.CreateEventObject(type));
}
