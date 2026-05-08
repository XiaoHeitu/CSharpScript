using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace CSharpScript.Tests.TestInfrastructure;

[SupportedOSPlatform("browser")]
internal static partial class TestJs
{
    [JSImport("globalThis.testHost.resetState")]
    public static partial void ResetState();

    [JSImport("globalThis.testHost.installWindowStubs")]
    public static partial void InstallWindowStubs();

    [JSImport("globalThis.testHost.installConsoleStub")]
    public static partial void InstallConsoleStub();

    [JSImport("globalThis.testHost.getCallLogJson")]
    public static partial string GetCallLogJson(string name);

    [JSImport("globalThis.testHost.getFixtureElement")]
    public static partial JSObject? GetFixtureElement(string selector);

    [JSImport("globalThis.testHost.getFixtureAttributes")]
    public static partial JSObject? GetFixtureAttributes(string selector);

    [JSImport("globalThis.testHost.getFixtureRoot")]
    public static partial JSObject GetFixtureRoot();

    [JSImport("globalThis.testHost.getTouchObject")]
    public static partial JSObject GetTouchObject(string selector);

    [JSImport("globalThis.testHost.getTouchListObject")]
    public static partial JSObject GetTouchListObject(string selector);

    [JSImport("globalThis.testHost.getSelectionObject")]
    public static partial JSObject GetSelectionObject();

    [JSImport("globalThis.testHost.setTextSelection")]
    public static partial void SetTextSelection();

    [JSImport("globalThis.testHost.getStyleSheetListHandle")]
    public static partial IntPtr GetStyleSheetListHandle();

    [JSImport("globalThis.testHost.getStyleSheetHandle")]
    public static partial IntPtr GetStyleSheetHandle(int index);

    [JSImport("globalThis.testHost.getCssRuleHandle")]
    public static partial IntPtr GetCssRuleHandle(int sheetIndex, int ruleIndex);

    [JSImport("globalThis.testHost.getCssRuleListHandle")]
    public static partial IntPtr GetCssRuleListHandle(int sheetIndex);

    [JSImport("globalThis.testHost.getFixtureStyleSheetHandle")]
    public static partial IntPtr GetFixtureStyleSheetHandle();

    [JSImport("globalThis.testHost.getFixtureCssRuleHandle")]
    public static partial IntPtr GetFixtureCssRuleHandle(int index);

    [JSImport("globalThis.testHost.getFixtureCssRuleListHandle")]
    public static partial IntPtr GetFixtureCssRuleListHandle();

    [JSImport("globalThis.testHost.createEventObject")]
    public static partial JSObject CreateEventObject(string type);

    [JSImport("globalThis.testHost.createReflectTarget")]
    public static partial IntPtr CreateReflectTarget();

    [JSImport("globalThis.testHost.createReflectReceiver")]
    public static partial IntPtr CreateReflectReceiver();

    [JSImport("globalThis.testHost.createReflectValueObject")]
    public static partial IntPtr CreateReflectValueObject();

    [JSImport("globalThis.testHost.createReflectDescriptor")]
    public static partial IntPtr CreateReflectDescriptor();

    [JSImport("globalThis.testHost.createReflectPrototype")]
    public static partial IntPtr CreateReflectPrototype();

    [JSImport("globalThis.testHost.createReflectApplyFunction")]
    public static partial IntPtr CreateReflectApplyFunction();

    [JSImport("globalThis.testHost.createReflectThisArgument")]
    public static partial IntPtr CreateReflectThisArgument();

    [JSImport("globalThis.testHost.createReflectArguments")]
    public static partial IntPtr CreateReflectArguments();

    [JSImport("globalThis.testHost.getArrayLength")]
    public static partial int GetArrayLength(IntPtr handle);

    [JSImport("globalThis.testHost.getArrayItemAsString")]
    public static partial string GetArrayItemAsString(IntPtr handle, int index);

    [JSImport("globalThis.testHost.getObjectPropertyAsString")]
    public static partial string GetObjectPropertyAsString(IntPtr handle, string propertyName);

    [JSImport("globalThis.testHost.publishSummary")]
    public static partial void PublishSummary(int total, int failed);

    [JSImport("globalThis.testHost.publishResultsJson")]
    public static partial void PublishResultsJson(string resultsJson);

    [JSImport("globalThis.testHost.getSummaryJson")]
    public static partial string GetSummaryJson();
}
