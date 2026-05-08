using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Api;

namespace CSharpScript.Browser.Api;

[SupportedOSPlatform("browser")]
public partial class Location
{
    private static Location? _instance;
    private static readonly object _lock = new();

    public static Location Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Location();
                }
            }
            return _instance;
        }
    }

    private Location() { }

    public string Href
    {
        get => Window.EvalString("location.href");
        set => Window.EvalString($"location.href='{value}'");
    }

    public string Protocol => Window.EvalString("location.protocol");

    public string Host => Window.EvalString("location.host");

    public string Hostname => Window.EvalString("location.hostname");

    public string Port => Window.EvalString("location.port");

    public string Pathname => Window.EvalString("location.pathname");

    public string Search => Window.EvalString("location.search");

    public string Hash => Window.EvalString("location.hash");

    public string Origin => Window.EvalString("location.origin");

    public void Assign(string url) => LocationCore.Assign(url);

    public void Replace(string url) => LocationCore.Replace(url);

    public void Reload() => LocationCore.Reload();
}