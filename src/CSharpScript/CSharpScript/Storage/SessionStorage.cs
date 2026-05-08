using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Storage;

namespace CSharpScript.Browser.Storage;

[SupportedOSPlatform("browser")]
public partial class SessionStorage
{
    private static SessionStorage? _instance;
    private static readonly object _lock = new();

    public static SessionStorage Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new SessionStorage();
                }
            }
            return _instance;
        }
    }

    private SessionStorage() { }

    public int GetLength() => SessionStorageCore.GetLength();

    public string? Key(int index) => SessionStorageCore.Key(index);

    public string? GetItem(string key) => SessionStorageCore.GetItem(key);

    public void SetItem(string key, string value) => SessionStorageCore.SetItem(key, value);

    public void RemoveItem(string key) => SessionStorageCore.RemoveItem(key);

    public void Clear() => SessionStorageCore.Clear();
}