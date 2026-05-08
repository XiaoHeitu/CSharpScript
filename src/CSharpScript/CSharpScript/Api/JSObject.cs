using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Api;

namespace CSharpScript.Api;

[SupportedOSPlatform("browser")]
public partial class JSObject
{
    private readonly IntPtr _jsHandle;

    public JSObject(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public IntPtr Handle => _jsHandle;

    public IntPtr Get(string propertyKey) => ReflectCore.GetObject(_jsHandle, propertyKey);

    public IntPtr Get(string propertyKey, IntPtr receiver) => ReflectCore.GetObject(_jsHandle, propertyKey, receiver);

    public string GetString(string propertyKey) => ReflectCore.GetString(_jsHandle, propertyKey);

    public string GetString(string propertyKey, IntPtr receiver) => ReflectCore.GetString(_jsHandle, propertyKey, receiver);

    public bool GetBool(string propertyKey) => ReflectCore.GetBool(_jsHandle, propertyKey);

    public bool GetBool(string propertyKey, IntPtr receiver) => ReflectCore.GetBool(_jsHandle, propertyKey, receiver);

    public int GetInt(string propertyKey) => ReflectCore.GetInt(_jsHandle, propertyKey);

    public int GetInt(string propertyKey, IntPtr receiver) => ReflectCore.GetInt(_jsHandle, propertyKey, receiver);

    public double GetDouble(string propertyKey) => ReflectCore.GetDouble(_jsHandle, propertyKey);

    public double GetDouble(string propertyKey, IntPtr receiver) => ReflectCore.GetDouble(_jsHandle, propertyKey, receiver);

    public bool Set(string propertyKey, IntPtr value) => ReflectCore.SetObject(_jsHandle, propertyKey, value);

    public bool Set(string propertyKey, IntPtr value, IntPtr receiver) => ReflectCore.SetObject(_jsHandle, propertyKey, value, receiver);

    public bool Set(string propertyKey, string value) => ReflectCore.SetString(_jsHandle, propertyKey, value);

    public bool Set(string propertyKey, string value, IntPtr receiver) => ReflectCore.SetString(_jsHandle, propertyKey, value, receiver);

    public bool Set(string propertyKey, bool value) => ReflectCore.SetBool(_jsHandle, propertyKey, value);

    public bool Set(string propertyKey, bool value, IntPtr receiver) => ReflectCore.SetBool(_jsHandle, propertyKey, value, receiver);

    public bool Set(string propertyKey, int value) => ReflectCore.SetInt(_jsHandle, propertyKey, value);

    public bool Set(string propertyKey, int value, IntPtr receiver) => ReflectCore.SetInt(_jsHandle, propertyKey, value, receiver);

    public bool Set(string propertyKey, double value) => ReflectCore.SetDouble(_jsHandle, propertyKey, value);

    public bool Set(string propertyKey, double value, IntPtr receiver) => ReflectCore.SetDouble(_jsHandle, propertyKey, value, receiver);

    public bool Has(string propertyKey) => ReflectCore.Has(_jsHandle, propertyKey);

    public bool Delete(string propertyKey) => ReflectCore.Delete(_jsHandle, propertyKey);

    public IntPtr OwnKeys() => ReflectCore.OwnKeys(_jsHandle);

    public IntPtr GetOwnPropertyDescriptor(string propertyKey) => ReflectCore.GetOwnPropertyDescriptor(_jsHandle, propertyKey);

    public IntPtr GetPrototypeOf() => ReflectCore.GetPrototypeOf(_jsHandle);

    public bool SetPrototypeOf(IntPtr proto) => ReflectCore.SetPrototypeOf(_jsHandle, proto);

    public bool IsExtensible() => ReflectCore.IsExtensible(_jsHandle);

    public bool PreventExtensions() => ReflectCore.PreventExtensions(_jsHandle);

    public bool DefineProperty(string propertyKey, IntPtr attributes) => ReflectCore.DefineProperty(_jsHandle, propertyKey, attributes);

    public IntPtr Apply(IntPtr thisArgument, IntPtr argumentsList) => ReflectCore.Apply(_jsHandle, thisArgument, argumentsList);

    public static implicit operator IntPtr(JSObject obj) => obj._jsHandle;
}
