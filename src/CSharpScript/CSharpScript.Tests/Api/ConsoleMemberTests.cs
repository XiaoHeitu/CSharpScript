using System.Runtime.Versioning;
using CSharpScript.Tests.TestInfrastructure;

namespace CSharpScript.Tests.Api;

[SupportedOSPlatform("browser")]
public sealed class ConsoleMemberTests : BrowserTestBase
{
    [Fact]
    public void Log_invokes_console_log()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Log("log");
        Assert.Single(BrowserTestContext.GetCalls("console.log"));
    }

    [Fact]
    public void Info_invokes_console_info()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Info("info");
        Assert.Single(BrowserTestContext.GetCalls("console.info"));
    }

    [Fact]
    public void Warn_invokes_console_warn()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Warn("warn");
        Assert.Single(BrowserTestContext.GetCalls("console.warn"));
    }

    [Fact]
    public void Error_invokes_console_error()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Error("error");
        Assert.Single(BrowserTestContext.GetCalls("console.error"));
    }

    [Fact]
    public void Debug_invokes_console_debug()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Debug("debug");
        Assert.Single(BrowserTestContext.GetCalls("console.debug"));
    }

    [Fact]
    public void Clear_invokes_console_clear()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Clear();
        Assert.Single(BrowserTestContext.GetCalls("console.clear"));
    }

    [Fact]
    public void Trace_invokes_console_trace()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Trace("trace");
        Assert.Single(BrowserTestContext.GetCalls("console.trace"));
    }

    [Fact]
    public void Assert_invokes_console_assert()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Assert(true, "assert");
        Assert.Single(BrowserTestContext.GetCalls("console.assert"));
    }

    [Fact]
    public void Count_invokes_console_count()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Count("counter");
        Assert.Single(BrowserTestContext.GetCalls("console.count"));
    }

    [Fact]
    public void CountReset_invokes_console_countReset()
    {
        TestJs.InstallConsoleStub();
        Window.Console.CountReset("counter");
        Assert.Single(BrowserTestContext.GetCalls("console.countReset"));
    }

    [Fact]
    public void Group_invokes_console_group()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Group("group");
        Assert.Single(BrowserTestContext.GetCalls("console.group"));
    }

    [Fact]
    public void GroupEnd_invokes_console_groupEnd()
    {
        TestJs.InstallConsoleStub();
        Window.Console.GroupEnd();
        Assert.Single(BrowserTestContext.GetCalls("console.groupEnd"));
    }

    [Fact]
    public void GroupCollapsed_invokes_console_groupCollapsed()
    {
        TestJs.InstallConsoleStub();
        Window.Console.GroupCollapsed("collapsed");
        Assert.Single(BrowserTestContext.GetCalls("console.groupCollapsed"));
    }

    [Fact]
    public void Time_invokes_console_time()
    {
        TestJs.InstallConsoleStub();
        Window.Console.Time("timer");
        Assert.Single(BrowserTestContext.GetCalls("console.time"));
    }

    [Fact]
    public void TimeEnd_invokes_console_timeEnd()
    {
        TestJs.InstallConsoleStub();
        Window.Console.TimeEnd("timer");
        Assert.Single(BrowserTestContext.GetCalls("console.timeEnd"));
    }

    [Fact]
    public void TimeLog_invokes_console_timeLog()
    {
        TestJs.InstallConsoleStub();
        Window.Console.TimeLog("timer");
        Assert.Single(BrowserTestContext.GetCalls("console.timeLog"));
    }
}
