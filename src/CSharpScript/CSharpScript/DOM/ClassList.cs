using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using CSharpScript.Core.DOM;

namespace CSharpScript.DOM;

[SupportedOSPlatform("browser")]
public partial class ClassList
{
    private readonly JSObject _jsHandle;

    public ClassList(JSObject handle)
    {
        _jsHandle = handle;
    }

    public int Length => ClassListCore.GetLength(_jsHandle);

    public string? Item(int index) => ClassListCore.Item(_jsHandle, index);

    public bool Contains(string token) => ClassListCore.Contains(_jsHandle, token);

    public void Add(string token) => ClassListCore.Add(_jsHandle, token);

    public void Remove(string token) => ClassListCore.Remove(_jsHandle, token);

    public bool Toggle(string token) => ClassListCore.Toggle(_jsHandle, token);

    public bool Replace(string oldToken, string newToken) => ClassListCore.Replace(_jsHandle, oldToken, newToken);

    public bool Supports(string token) => ClassListCore.Supports(_jsHandle, token);

    public string Value
    {
        get => ClassListCore.GetValue(_jsHandle);
        set => ClassListCore.SetValue(_jsHandle, value);
    }
}
