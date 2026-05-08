using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Api;

namespace CSharpScript.Browser.Api;

[SupportedOSPlatform("browser")]
public partial class History
{
    private static History? _instance;
    private static readonly object _lock = new();

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

    public int Length => Window.EvalInt("history.length");

    public void Back() => HistoryCore.Back();

    public void Forward() => HistoryCore.Forward();

    public void Go(int? delta = null) => HistoryCore.Go(delta);
}