using System.Runtime.Versioning;
using CSharpScript.Api;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Api;

[SupportedOSPlatform("browser")]
public sealed class WindowStaticMembersTests : BrowserTestBase
{
    [Fact]
    public void Alert_invokes_window_alert()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.Alert("hello");
        Assert.Single(BrowserTestContext.GetCalls("alert"));
    }

    [Fact]
    public void Confirm_returns_stubbed_value()
    {
        TestJs.InstallWindowStubs();
        Assert.True(CSharpScript.Api.Window.Confirm("ok"));
    }

    [Fact]
    public void Prompt_returns_stubbed_value()
    {
        TestJs.InstallWindowStubs();
        Assert.Equal("prompt-result", CSharpScript.Api.Window.Prompt("input", "value"));
    }

    [Fact]
    public void ClearTimeout_accepts_identifier() => CSharpScript.Api.Window.ClearTimeout(0);

    [Fact]
    public void ClearInterval_accepts_identifier() => CSharpScript.Api.Window.ClearInterval(0);

    [Fact]
    public void Open_invokes_window_open()
    {
        TestJs.InstallWindowStubs();
        Assert.Equal("opened-window", CSharpScript.Api.Window.Open("/", "_blank", "width=100"));
    }

    [Fact]
    public void Close_invokes_window_close()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.Close();
        Assert.Single(BrowserTestContext.GetCalls("close"));
    }

    [Fact]
    public void Print_invokes_window_print()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.Print();
        Assert.Single(BrowserTestContext.GetCalls("print"));
    }

    [Fact]
    public void ScrollTo_invokes_window_scrollTo()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.ScrollTo(3, 4);
        Assert.Single(BrowserTestContext.GetCalls("scrollTo"));
    }

    [Fact]
    public void Scroll_invokes_window_scroll()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.Scroll(1, 2);
        Assert.Single(BrowserTestContext.GetCalls("scroll"));
    }

    [Fact]
    public void ScrollBy_invokes_window_scrollBy()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.ScrollBy(5, 6);
        Assert.Single(BrowserTestContext.GetCalls("scrollBy"));
    }

    [Fact]
    public void Focus_invokes_window_focus()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.Focus();
        Assert.Single(BrowserTestContext.GetCalls("focus"));
    }

    [Fact]
    public void Blur_invokes_window_blur()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.Blur();
        Assert.Single(BrowserTestContext.GetCalls("blur"));
    }

    [Fact]
    public void InnerWidth_returns_positive_value() => Assert.True(CSharpScript.Api.Window.InnerWidth > 0);

    [Fact]
    public void InnerHeight_returns_positive_value() => Assert.True(CSharpScript.Api.Window.InnerHeight > 0);

    [Fact]
    public void OuterWidth_returns_positive_value() => Assert.True(CSharpScript.Api.Window.OuterWidth > 0);

    [Fact]
    public void OuterHeight_returns_positive_value() => Assert.True(CSharpScript.Api.Window.OuterHeight > 0);

    [Fact]
    public void ScreenX_returns_value() => _ = CSharpScript.Api.Window.ScreenX;

    [Fact]
    public void ScreenY_returns_value() => _ = CSharpScript.Api.Window.ScreenY;

    [Fact]
    public void DevicePixelRatio_returns_positive_value() => Assert.True(CSharpScript.Api.Window.DevicePixelRatio > 0);

    [Fact]
    public void Origin_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(CSharpScript.Api.Window.Origin));

    [Fact]
    public void Closed_returns_boolean() => _ = CSharpScript.Api.Window.Closed;

    [Fact]
    public void Name_supports_roundtrip()
    {
        var original = CSharpScript.Api.Window.Name;
        CSharpScript.Api.Window.Name = "unit-test-window";
        Assert.Equal("unit-test-window", CSharpScript.Api.Window.Name);
        CSharpScript.Api.Window.Name = original;
    }

    [Fact]
    public void Status_supports_roundtrip()
    {
        var original = CSharpScript.Api.Window.Status;
        CSharpScript.Api.Window.Status = "unit-test-status";
        Assert.Equal("unit-test-status", CSharpScript.Api.Window.Status);
        CSharpScript.Api.Window.Status = original;
    }

    [Fact]
    public void ResizeTo_invokes_window_resizeTo()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.ResizeTo(7, 8);
        Assert.Single(BrowserTestContext.GetCalls("resizeTo"));
    }

    [Fact]
    public void ResizeBy_invokes_window_resizeBy()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.ResizeBy(9, 10);
        Assert.Single(BrowserTestContext.GetCalls("resizeBy"));
    }

    [Fact]
    public void MoveTo_invokes_window_moveTo()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.MoveTo(11, 12);
        Assert.Single(BrowserTestContext.GetCalls("moveTo"));
    }

    [Fact]
    public void MoveBy_invokes_window_moveBy()
    {
        TestJs.InstallWindowStubs();
        CSharpScript.Api.Window.MoveBy(13, 14);
        Assert.Single(BrowserTestContext.GetCalls("moveBy"));
    }

    [Fact]
    public void EvalString_returns_string_result() => Assert.Equal("abc", CSharpScript.Api.Window.EvalString("'abc'"));

    [Fact]
    public void EvalInt_returns_integer_result() => Assert.Equal(3, CSharpScript.Api.Window.EvalInt("1 + 2"));

    [Fact]
    public void EvalBool_returns_boolean_result() => Assert.True(CSharpScript.Api.Window.EvalBool("1 < 2"));

    [Fact]
    public void EvalDouble_returns_double_result() => Assert.Equal(2.5, CSharpScript.Api.Window.EvalDouble("5 / 2"), 6);
}
