namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public partial class JSObject
{
    private readonly IntPtr _handle;

    public JSObject(IntPtr handle)
    {
        _handle = handle;
    }

    public IntPtr GetObject(string propertyName) => Reflect.GetObject(_handle, propertyName);

    public IntPtr GetObject(string propertyName, IntPtr receiver) => Reflect.GetObject(_handle, propertyName, receiver);

    public string GetString(string propertyName) => Reflect.GetString(_handle, propertyName);

    public string GetString(string propertyName, IntPtr receiver) => Reflect.GetString(_handle, propertyName, receiver);

    public bool GetBool(string propertyName) => Reflect.GetBool(_handle, propertyName);

    public bool GetBool(string propertyName, IntPtr receiver) => Reflect.GetBool(_handle, propertyName, receiver);

    public int GetInt(string propertyName) => Reflect.GetInt(_handle, propertyName);

    public int GetInt(string propertyName, IntPtr receiver) => Reflect.GetInt(_handle, propertyName, receiver);

    public double GetDouble(string propertyName) => Reflect.GetDouble(_handle, propertyName);

    public double GetDouble(string propertyName, IntPtr receiver) => Reflect.GetDouble(_handle, propertyName, receiver);

    public bool SetObject(string propertyName, IntPtr value) => Reflect.SetObject(_handle, propertyName, value);

    public bool SetObject(string propertyName, IntPtr value, IntPtr receiver) => Reflect.SetObject(_handle, propertyName, value, receiver);

    public bool SetString(string propertyName, string value) => Reflect.SetString(_handle, propertyName, value);

    public bool SetString(string propertyName, string value, IntPtr receiver) => Reflect.SetString(_handle, propertyName, value, receiver);

    public bool SetBool(string propertyName, bool value) => Reflect.SetBool(_handle, propertyName, value);

    public bool SetBool(string propertyName, bool value, IntPtr receiver) => Reflect.SetBool(_handle, propertyName, value, receiver);

    public bool SetInt(string propertyName, int value) => Reflect.SetInt(_handle, propertyName, value);

    public bool SetInt(string propertyName, int value, IntPtr receiver) => Reflect.SetInt(_handle, propertyName, value, receiver);

    public bool SetDouble(string propertyName, double value) => Reflect.SetDouble(_handle, propertyName, value);

    public bool SetDouble(string propertyName, double value, IntPtr receiver) => Reflect.SetDouble(_handle, propertyName, value, receiver);

    public bool Has(string propertyName) => Reflect.Has(_handle, propertyName);

    public bool Delete(string propertyName) => Reflect.Delete(_handle, propertyName);

    public IntPtr OwnKeys() => Reflect.OwnKeys(_handle);

    public IntPtr GetOwnPropertyDescriptor(string propertyName) => Reflect.GetOwnPropertyDescriptor(_handle, propertyName);

    public IntPtr GetPrototypeOf() => Reflect.GetPrototypeOf(_handle);

    public bool SetPrototypeOf(IntPtr prototype) => Reflect.SetPrototypeOf(_handle, prototype);

    public bool IsExtensible() => Reflect.IsExtensible(_handle);

    public bool PreventExtensions() => Reflect.PreventExtensions(_handle);

    public bool DefineProperty(string propertyName, IntPtr attributes) => Reflect.DefineProperty(_handle, propertyName, attributes);

    public IntPtr Handle => _handle;
}