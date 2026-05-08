using System.Runtime.Versioning;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Api;

[SupportedOSPlatform("browser")]
public sealed class DocumentMemberTests : BrowserTestBase
{
    [Fact]
    public void Title_supports_roundtrip()
    {
        Document.Title = "CSharpScript Browser Tests";
        Assert.Equal("CSharpScript Browser Tests", Document.Title);
    }

    [Fact]
    public void Cookie_supports_write_then_read()
    {
        Document.Cookie = "unit_cookie=1";
        Assert.Contains("unit_cookie=1", Document.Cookie);
    }

    [Fact]
    public void Domain_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.Domain));

    [Fact]
    public void Referrer_returns_value() => Assert.NotNull(Document.Referrer);

    [Fact]
    public void URL_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.URL));

    [Fact]
    public void URLUnencoded_returns_value() => Assert.NotNull(Document.URLUnencoded);

    [Fact]
    public void ReadyState_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.ReadyState));

    [Fact]
    public void Hidden_returns_boolean() => _ = Document.Hidden;

    [Fact]
    public void VisibilityState_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.VisibilityState));

    [Fact]
    public void CharacterSet_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.CharacterSet));

    [Fact]
    public void ContentType_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.ContentType));

    [Fact]
    public void InputEncoding_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.InputEncoding));

    [Fact]
    public void LastModified_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.LastModified));

    [Fact]
    public void CompatMode_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Document.CompatMode));

    [Fact]
    public void DesignMode_supports_roundtrip()
    {
        Document.DesignMode = "off";
        Assert.Equal("off", Document.DesignMode);
    }

    [Fact]
    public void GetElementById_returns_matching_element() => Assert.Equal("first", Document.GetElementById("first")?.Id);

    [Fact]
    public void GetElementsByClassName_returns_collection() => Assert.Equal(3, Document.GetElementsByClassName("item").Length);

    [Fact]
    public void GetElementsByTagName_returns_collection() => Assert.True(Document.GetElementsByTagName("span").Length >= 2);

    [Fact]
    public void GetElementsByName_returns_collection() => Assert.True(Document.GetElementsByName("childName").Length >= 1);

    [Fact]
    public void QuerySelector_returns_matching_element() => Assert.Equal("second", Document.QuerySelector("#second")?.Id);

    [Fact]
    public void QuerySelectorAll_returns_collection() => Assert.Equal(3, Document.QuerySelectorAll(".item").Length);

    [Fact]
    public void CreateElement_returns_element() => Assert.Equal("DIV", Document.CreateElement("div").TagName);

    [Fact]
    public void CreateTextNode_returns_node() => Assert.NotNull(Document.CreateTextNode("plain text"));

    [Fact]
    public void CreateDocumentFragment_returns_node() => Assert.NotNull(Document.CreateDocumentFragment());

    [Fact]
    public void CreateComment_returns_node() => Assert.NotNull(Document.CreateComment("comment"));

    [Fact]
    public void CreateAttribute_returns_attribute() => Assert.Equal("data-test", Document.CreateAttribute("data-test").Name);

    [Fact]
    public void CreateEvent_returns_event() => Assert.Equal("custom", CreateCustomEventType());

    [Fact]
    public void CreateRange_returns_range() => Assert.NotNull(Document.CreateRange());

    [Fact]
    public void Body_returns_element() => Assert.NotNull(Document.Body);

    [Fact]
    public void Head_returns_element() => Assert.NotNull(Document.Head);

    [Fact]
    public void DocumentElement_returns_element() => Assert.NotNull(Document.DocumentElement);

    [Fact]
    public void ActiveElement_returns_value() => Assert.NotNull(Document.ActiveElement);

    [Fact]
    public void Scripts_returns_collection() => Assert.NotNull(Document.Scripts);

    [Fact]
    public void Images_returns_collection() => Assert.NotNull(Document.Images);

    [Fact]
    public void Links_returns_collection() => Assert.NotNull(Document.Links);

    [Fact]
    public void Forms_returns_collection() => Assert.NotNull(Document.Forms);

    [Fact]
    public void Anchors_returns_collection() => Assert.NotNull(Document.Anchors);

    [Fact]
    public void Embeds_returns_collection() => Assert.NotNull(Document.Embeds);

    [Fact]
    public void Plugins_returns_collection() => Assert.NotNull(Document.Plugins);

    [Fact]
    public void StyleSheets_returns_collection() => Assert.NotNull(Document.StyleSheets);

    [Fact]
    public void PreferredStyleSheetSet_returns_value() => Assert.NotNull(Document.PreferredStyleSheetSet);

    [Fact]
    public void SelectedStyleSheetSet_supports_roundtrip()
    {
        var original = Document.SelectedStyleSheetSet;
        Document.SelectedStyleSheetSet = original;
        Assert.Equal(original, Document.SelectedStyleSheetSet);
    }

    [Fact]
    public void DocumentChildren_returns_collection() => Assert.NotNull(Document.DocumentChildren);

    [Fact]
    public void DocumentChildElementCount_returns_non_negative_value() => Assert.True(Document.DocumentChildElementCount >= 1);

    [Fact]
    public void DocumentFirstElementChild_returns_element() => Assert.NotNull(Document.DocumentFirstElementChild);

    [Fact]
    public void DocumentLastElementChild_returns_element() => Assert.NotNull(Document.DocumentLastElementChild);

    [Fact]
    public void HasFocus_returns_boolean() => _ = Document.HasFocus();

    [Fact]
    public void Normalize_executes_without_throw() => Document.Normalize();

    [Fact]
    public void GetSelection_returns_selection_wrapper()
    {
        BrowserTestContext.SelectFixtureText();
        Assert.NotNull(Document.GetSelection());
    }

    private static string CreateCustomEventType()
    {
        var evt = Document.CreateEvent("Event");
        evt.InitEvent("custom", true, true);
        return evt.Type;
    }
}
