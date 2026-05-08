using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.Api;

namespace CSharpScript.Api;

[SupportedOSPlatform("browser")]
public partial class History
{
    private static History? _instance;
    private static readonly object _lock = new();
    private static JSObject HistoryObject => JSHost.GlobalThis.GetPropertyAsJSObject("history")!;

    public static History Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new History();
                }
            }
            return _instance;
        }
    }

    private History() { }

    public int Length => HistoryObject.GetPropertyAsInt32("length");

    public void Back() => HistoryCore.Back();

    public void Forward() => HistoryCore.Forward();

    public void Go(int? delta = null) => HistoryCore.Go(delta);
}
