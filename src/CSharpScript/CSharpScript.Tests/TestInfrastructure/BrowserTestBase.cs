using CSharpScript.Api;

namespace CSharpScript.Tests.TestInfrastructure;

[Collection(BrowserTestCollection.Name)]
public abstract class BrowserTestBase
{
    protected static Window Window => Window.Instance;
    protected static Document Document => Document.Instance;
}
