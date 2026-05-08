using System.Runtime.Versioning;
using CSharpScript.Storage;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Storage;

[SupportedOSPlatform("browser")]
public sealed class LocalStorageMemberTests : BrowserTestBase
{
    [Fact]
    public void GetLength_returns_non_negative_value() => Assert.True(LocalStorage.Instance.GetLength() >= 0);

    [Fact]
    public void Key_returns_value_for_existing_index()
    {
        LocalStorage.Instance.SetItem("alpha", "1");
        Assert.NotNull(LocalStorage.Instance.Key(0));
    }

    [Fact]
    public void GetItem_returns_stored_value()
    {
        LocalStorage.Instance.SetItem("alpha", "1");
        Assert.Equal("1", LocalStorage.Instance.GetItem("alpha"));
    }

    [Fact]
    public void SetItem_stores_value()
    {
        LocalStorage.Instance.SetItem("alpha", "1");
        Assert.Equal("1", LocalStorage.Instance.GetItem("alpha"));
    }

    [Fact]
    public void RemoveItem_removes_value()
    {
        LocalStorage.Instance.SetItem("alpha", "1");
        LocalStorage.Instance.RemoveItem("alpha");
        Assert.Null(LocalStorage.Instance.GetItem("alpha"));
    }

    [Fact]
    public void Clear_removes_all_values()
    {
        LocalStorage.Instance.SetItem("alpha", "1");
        LocalStorage.Instance.SetItem("beta", "2");
        LocalStorage.Instance.Clear();
        Assert.Equal(0, LocalStorage.Instance.GetLength());
    }
}
