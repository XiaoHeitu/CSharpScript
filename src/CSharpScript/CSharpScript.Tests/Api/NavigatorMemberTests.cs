using System.Runtime.Versioning;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Api;

[SupportedOSPlatform("browser")]
public sealed class NavigatorMemberTests : BrowserTestBase
{
    [Fact]
    public void UserAgent_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.UserAgent));

    [Fact]
    public void AppName_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.AppName));

    [Fact]
    public void AppVersion_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.AppVersion));

    [Fact]
    public void AppCodeName_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.AppCodeName));

    [Fact]
    public void Platform_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.Platform));

    [Fact]
    public void Product_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.Product));

    [Fact]
    public void Vendor_returns_value() => Assert.NotNull(Window.Navigator.Vendor);

    [Fact]
    public void Language_returns_non_empty_string() => Assert.False(string.IsNullOrWhiteSpace(Window.Navigator.Language));

    [Fact]
    public void Languages_returns_value() => Assert.NotNull(Window.Navigator.Languages);

    [Fact]
    public void OnLine_returns_boolean() => _ = Window.Navigator.OnLine;

    [Fact]
    public void CookieEnabled_returns_boolean() => _ = Window.Navigator.CookieEnabled;

    [Fact]
    public void JavaEnabled_returns_boolean() => _ = Window.Navigator.JavaEnabled();

    [Fact]
    public void MaxTouchPoints_returns_non_negative_value() => Assert.True(Window.Navigator.MaxTouchPoints >= 0);

    [Fact]
    public void HardwareConcurrency_returns_positive_value() => Assert.True(Window.Navigator.HardwareConcurrency >= 1);
}
