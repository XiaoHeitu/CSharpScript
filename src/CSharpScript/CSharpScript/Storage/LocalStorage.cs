using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Storage;

namespace CSharpScript.Browser.Storage;

[SupportedOSPlatform("browser")]
public partial class LocalStorage
{
    private static LocalStorage? _instance;
    private static readonly object _lock = new();

    public static LocalStorage Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new LocalStorage();
                }
            }
            return _instance;
        }
    }

    private LocalStorage() { }

    public int GetLength() => LocalStorageCore.GetLength();

    public string? Key(int index) => LocalStorageCore.Key(index);

    public string? GetItem(string key) => LocalStorageCore.GetItem(key);

    public void SetItem(string key, string value) => LocalStorageCore.SetItem(key, value);

    public void RemoveItem(string key) => LocalStorageCore.RemoveItem(key);

    public void Clear() => LocalStorageCore.Clear();
}