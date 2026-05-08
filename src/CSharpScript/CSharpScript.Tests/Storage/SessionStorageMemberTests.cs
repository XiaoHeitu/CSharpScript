using System.Runtime.Versioning;
using CSharpScript.Storage;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Storage;

[SupportedOSPlatform("browser")]
public sealed class SessionStorageMemberTests : BrowserTestBase
{
    [Fact]
    public void GetLength_returns_non_negative_value() => Assert.True(SessionStorage.Instance.GetLength() >= 0);

    [Fact]
    public void Key_returns_value_for_existing_index()
    {
        SessionStorage.Instance.SetItem("alpha", "1");
        Assert.NotNull(SessionStorage.Instance.Key(0));
    }

    [Fact]
    public void GetItem_returns_stored_value()
    {
        SessionStorage.Instance.SetItem("alpha", "1");
        Assert.Equal("1", SessionStorage.Instance.GetItem("alpha"));
    }

    [Fact]
    public void SetItem_stores_value()
    {
        SessionStorage.Instance.SetItem("alpha", "1");
        Assert.Equal("1", SessionStorage.Instance.GetItem("alpha"));
    }

    [Fact]
    public void RemoveItem_removes_value()
    {
        SessionStorage.Instance.SetItem("alpha", "1");
        SessionStorage.Instance.RemoveItem("alpha");
        Assert.Null(SessionStorage.Instance.GetItem("alpha"));
    }

    [Fact]
    public void Clear_removes_all_values()
    {
        SessionStorage.Instance.SetItem("alpha", "1");
        SessionStorage.Instance.SetItem("beta", "2");
        SessionStorage.Instance.Clear();
        Assert.Equal(0, SessionStorage.Instance.GetLength());
    }
}
