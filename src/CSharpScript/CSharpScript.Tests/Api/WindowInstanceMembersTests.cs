using System.Runtime.Versioning;
using CSharpScript.Api;
using CSharpScript.Storage;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Api;

[SupportedOSPlatform("browser")]
public sealed class WindowInstanceMembersTests : BrowserTestBase
{
    [Fact]
    public void Instance_returns_singleton_instance() => Assert.Same(Window.Instance, Window);

    [Fact]
    public void Document_returns_document_singleton() => Assert.Same(Document.Instance, Window.Document);

    [Fact]
    public void Navigator_returns_navigator_singleton() => Assert.Same(Navigator.Instance, Window.Navigator);

    [Fact]
    public void Console_returns_console_singleton() => Assert.Same(CSharpScript.Api.Console.Instance, Window.Console);

    [Fact]
    public void LocalStorage_returns_local_storage_singleton() => Assert.Same(LocalStorage.Instance, Window.LocalStorage);

    [Fact]
    public void SessionStorage_returns_session_storage_singleton() => Assert.Same(SessionStorage.Instance, Window.SessionStorage);
}
