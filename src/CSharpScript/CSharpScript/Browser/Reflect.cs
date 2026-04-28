namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Reflect
{
    [JSImport("globalThis.Reflect.get")]
    public static partial IntPtr GetObject(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.get")]
    public static partial IntPtr GetObject(IntPtr target, string propertyKey, IntPtr receiver);

    [JSImport("globalThis.Reflect.get")]
    public static partial string GetString(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.get")]
    public static partial string GetString(IntPtr target, string propertyKey, IntPtr receiver);

    [JSImport("globalThis.Reflect.get")]
    public static partial bool GetBool(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.get")]
    public static partial bool GetBool(IntPtr target, string propertyKey, IntPtr receiver);

    [JSImport("globalThis.Reflect.get")]
    public static partial int GetInt(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.get")]
    public static partial int GetInt(IntPtr target, string propertyKey, IntPtr receiver);

    [JSImport("globalThis.Reflect.get")]
    public static partial double GetDouble(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.get")]
    public static partial double GetDouble(IntPtr target, string propertyKey, IntPtr receiver);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetObject(IntPtr target, string propertyKey, IntPtr value);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetObject(IntPtr target, string propertyKey, IntPtr value, IntPtr receiver);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetString(IntPtr target, string propertyKey, [JSMarshalAs<JSType.String>] string value);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetString(IntPtr target, string propertyKey, [JSMarshalAs<JSType.String>] string value, IntPtr receiver);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetBool(IntPtr target, string propertyKey, [JSMarshalAs<JSType.Boolean>] bool value);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetBool(IntPtr target, string propertyKey, [JSMarshalAs<JSType.Boolean>] bool value, IntPtr receiver);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetInt(IntPtr target, string propertyKey, [JSMarshalAs<JSType.Number>] int value);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetInt(IntPtr target, string propertyKey, [JSMarshalAs<JSType.Number>] int value, IntPtr receiver);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetDouble(IntPtr target, string propertyKey, [JSMarshalAs<JSType.Number>] double value);

    [JSImport("globalThis.Reflect.set")]
    public static partial bool SetDouble(IntPtr target, string propertyKey, [JSMarshalAs<JSType.Number>] double value, IntPtr receiver);

    [JSImport("globalThis.Reflect.has")]
    public static partial bool Has(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.deleteProperty")]
    public static partial bool Delete(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.ownKeys")]
    public static partial IntPtr OwnKeys(IntPtr target);

    [JSImport("globalThis.Reflect.getOwnPropertyDescriptor")]
    public static partial IntPtr GetOwnPropertyDescriptor(IntPtr target, string propertyKey);

    [JSImport("globalThis.Reflect.getPrototypeOf")]
    public static partial IntPtr GetPrototypeOf(IntPtr target);

    [JSImport("globalThis.Reflect.setPrototypeOf")]
    public static partial bool SetPrototypeOf(IntPtr target, IntPtr proto);

    [JSImport("globalThis.Reflect.isExtensible")]
    public static partial bool IsExtensible(IntPtr target);

    [JSImport("globalThis.Reflect.preventExtensions")]
    public static partial bool PreventExtensions(IntPtr target);

    [JSImport("globalThis.Reflect.defineProperty")]
    public static partial bool DefineProperty(IntPtr target, string propertyKey, IntPtr attributes);

    [JSImport("globalThis.Reflect.apply")]
    public static partial IntPtr Apply(IntPtr target, IntPtr thisArgument, IntPtr argumentsList);

    [JSImport("globalThis.eval")]
    public static partial string EvalString([JSMarshalAs<JSType.String>] string code);

    [JSImport("globalThis.eval")]
    public static partial int EvalInt([JSMarshalAs<JSType.String>] string code);

    [JSImport("globalThis.eval")]
    public static partial bool EvalBool([JSMarshalAs<JSType.String>] string code);

    [JSImport("globalThis.eval")]
    public static partial double EvalDouble([JSMarshalAs<JSType.String>] string code);
}