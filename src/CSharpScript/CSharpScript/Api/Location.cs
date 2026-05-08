using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.Api;

namespace CSharpScript.Api;

[SupportedOSPlatform("browser")]
public partial class Location
{
    private static Location? _instance;
    private static readonly object _lock = new();
    private static JSObject LocationObject => JSHost.GlobalThis.GetPropertyAsJSObject("location")!;

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
        get => LocationObject.GetPropertyAsString("href")!;
        set => LocationObject.SetProperty("href", value);
    }

    public string Protocol => LocationObject.GetPropertyAsString("protocol")!;

    public string Host => LocationObject.GetPropertyAsString("host")!;

    public string Hostname => LocationObject.GetPropertyAsString("hostname")!;

    public string Port => LocationObject.GetPropertyAsString("port")!;

    public string Pathname => LocationObject.GetPropertyAsString("pathname")!;

    public string Search => LocationObject.GetPropertyAsString("search")!;

    public string Hash => LocationObject.GetPropertyAsString("hash")!;

    public string Origin => LocationObject.GetPropertyAsString("origin")!;

    public void Assign(string url) => LocationCore.Assign(url);

    public void Replace(string url) => LocationCore.Replace(url);

    public void Reload() => LocationCore.Reload();
}
