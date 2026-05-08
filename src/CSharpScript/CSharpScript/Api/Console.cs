using System.Runtime.CompilerServices;
using CSharpScript.Browser.Core.Api;

namespace CSharpScript.Browser.Api;

[SupportedOSPlatform("browser")]
public partial class Console
{
    private static Console? _instance;
    private static readonly object _lock = new();

    public static Console Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new Console();
                }
            }
            return _instance;
        }
    }

    private Console() { }

    public void Log(string message) => ConsoleCore.Log(message);

    public void Info(string message) => ConsoleCore.Info(message);

    public void Warn(string message) => ConsoleCore.Warn(message);

    public void Error(string message) => ConsoleCore.Error(message);

    public void Debug(string message) => ConsoleCore.Debug(message);

    public void Clear() => ConsoleCore.Clear();

    public void Trace(string message) => ConsoleCore.Trace(message);

    public void Assert(bool condition, string message) => ConsoleCore.Assert(condition, message);

    public void Count(string? label = null) => ConsoleCore.Count(label);

    public void CountReset(string? label = null) => ConsoleCore.CountReset(label);

    public void Group(string? label = null) => ConsoleCore.Group(label);

    public void GroupEnd() => ConsoleCore.GroupEnd();

    public void GroupCollapsed(string? label = null) => ConsoleCore.GroupCollapsed(label);

    public void Time(string? label = null) => ConsoleCore.Time(label);

    public void TimeEnd(string? label = null) => ConsoleCore.TimeEnd(label);

    public void TimeLog(string? label = null) => ConsoleCore.TimeLog(label);
}