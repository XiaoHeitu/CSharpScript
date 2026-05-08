using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Api;

namespace CSharpScript.Browser.Api;

[SupportedOSPlatform("browser")]
public static partial class Reflect
{
    public static IntPtr GetObject(IntPtr target, string propertyKey) =>
        ReflectCore.GetObject(target, propertyKey);

    public static IntPtr GetObject(IntPtr target, string propertyKey, IntPtr receiver) =>
        ReflectCore.GetObject(target, propertyKey, receiver);

    public static string GetString(IntPtr target, string propertyKey) =>
        ReflectCore.GetString(target, propertyKey);

    public static string GetString(IntPtr target, string propertyKey, IntPtr receiver) =>
        ReflectCore.GetString(target, propertyKey, receiver);

    public static bool GetBool(IntPtr target, string propertyKey) =>
        ReflectCore.GetBool(target, propertyKey);

    public static bool GetBool(IntPtr target, string propertyKey, IntPtr receiver) =>
        ReflectCore.GetBool(target, propertyKey, receiver);

    public static int GetInt(IntPtr target, string propertyKey) =>
        ReflectCore.GetInt(target, propertyKey);

    public static int GetInt(IntPtr target, string propertyKey, IntPtr receiver) =>
        ReflectCore.GetInt(target, propertyKey, receiver);

    public static double GetDouble(IntPtr target, string propertyKey) =>
        ReflectCore.GetDouble(target, propertyKey);

    public static double GetDouble(IntPtr target, string propertyKey, IntPtr receiver) =>
        ReflectCore.GetDouble(target, propertyKey, receiver);

    public static bool SetObject(IntPtr target, string propertyKey, IntPtr value) =>
        ReflectCore.SetObject(target, propertyKey, value);

    public static bool SetObject(IntPtr target, string propertyKey, IntPtr value, IntPtr receiver) =>
        ReflectCore.SetObject(target, propertyKey, value, receiver);

    public static bool SetString(IntPtr target, string propertyKey, string value) =>
        ReflectCore.SetString(target, propertyKey, value);

    public static bool SetString(IntPtr target, string propertyKey, string value, IntPtr receiver) =>
        ReflectCore.SetString(target, propertyKey, value, receiver);

    public static bool SetBool(IntPtr target, string propertyKey, bool value) =>
        ReflectCore.SetBool(target, propertyKey, value);

    public static bool SetBool(IntPtr target, string propertyKey, bool value, IntPtr receiver) =>
        ReflectCore.SetBool(target, propertyKey, value, receiver);

    public static bool SetInt(IntPtr target, string propertyKey, int value) =>
        ReflectCore.SetInt(target, propertyKey, value);

    public static bool SetInt(IntPtr target, string propertyKey, int value, IntPtr receiver) =>
        ReflectCore.SetInt(target, propertyKey, value, receiver);

    public static bool SetDouble(IntPtr target, string propertyKey, double value) =>
        ReflectCore.SetDouble(target, propertyKey, value);

    public static bool SetDouble(IntPtr target, string propertyKey, double value, IntPtr receiver) =>
        ReflectCore.SetDouble(target, propertyKey, value, receiver);

    public static bool Has(IntPtr target, string propertyKey) =>
        ReflectCore.Has(target, propertyKey);

    public static bool Delete(IntPtr target, string propertyKey) =>
        ReflectCore.Delete(target, propertyKey);

    public static IntPtr OwnKeys(IntPtr target) =>
        ReflectCore.OwnKeys(target);

    public static IntPtr GetOwnPropertyDescriptor(IntPtr target, string propertyKey) =>
        ReflectCore.GetOwnPropertyDescriptor(target, propertyKey);

    public static IntPtr GetPrototypeOf(IntPtr target) =>
        ReflectCore.GetPrototypeOf(target);

    public static bool SetPrototypeOf(IntPtr target, IntPtr proto) =>
        ReflectCore.SetPrototypeOf(target, proto);

    public static bool IsExtensible(IntPtr target) =>
        ReflectCore.IsExtensible(target);

    public static bool PreventExtensions(IntPtr target) =>
        ReflectCore.PreventExtensions(target);

    public static bool DefineProperty(IntPtr target, string propertyKey, IntPtr attributes) =>
        ReflectCore.DefineProperty(target, propertyKey, attributes);

    public static IntPtr Apply(IntPtr target, IntPtr thisArgument, IntPtr argumentsList) =>
        ReflectCore.Apply(target, thisArgument, argumentsList);

    public static string EvalString(string code) =>
        ReflectCore.EvalString(code);

    public static int EvalInt(string code) =>
        ReflectCore.EvalInt(code);

    public static bool EvalBool(string code) =>
        ReflectCore.EvalBool(code);

    public static double EvalDouble(string code) =>
        ReflectCore.EvalDouble(code);
}