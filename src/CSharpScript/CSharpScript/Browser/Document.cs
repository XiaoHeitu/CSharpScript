namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public static partial class Document
{
    [JSImport("globalThis.document.getElementById")]
    public static partial IntPtr GetElementById(string id);

    [JSImport("globalThis.document.getElementsByClassName")]
    public static partial IntPtr GetElementsByClassName(string className);

    [JSImport("globalThis.document.getElementsByTagName")]
    public static partial IntPtr GetElementsByTagName(string tagName);

    [JSImport("globalThis.document.getElementsByName")]
    public static partial IntPtr GetElementsByName(string name);

    [JSImport("globalThis.document.querySelector")]
    public static partial IntPtr QuerySelector(string selectors);

    [JSImport("globalThis.document.querySelectorAll")]
    public static partial IntPtr QuerySelectorAll(string selectors);

    [JSImport("globalThis.document.createElement")]
    public static partial IntPtr CreateElement(string tagName);

    [JSImport("globalThis.document.createTextNode")]
    public static partial IntPtr CreateTextNode(string text);

    [JSImport("globalThis.document.title")]
    public static partial string GetTitle();

    [JSImport("globalThis.document.title")]
    public static partial void SetTitle(string title);

    [JSImport("globalThis.document.body")]
    public static partial IntPtr GetBody();

    [JSImport("globalThis.document.head")]
    public static partial IntPtr GetHead();

    [JSImport("globalThis.document.documentElement")]
    public static partial IntPtr GetDocumentElement();

    [JSImport("globalThis.document.cookie")]
    public static partial string GetCookie();

    [JSImport("globalThis.document.cookie")]
    public static partial void SetCookie(string value);

    [JSImport("globalThis.document.domain")]
    public static partial string GetDomain();

    [JSImport("globalThis.document.referrer")]
    public static partial string GetReferrer();

    [JSImport("globalThis.document.URL")]
    public static partial string GetURL();

    [JSImport("globalThis.document.readyState")]
    public static partial string GetReadyState();

    [JSImport("globalThis.document.hidden")]
    public static partial bool GetHidden();

    [JSImport("globalThis.document.visibilityState")]
    public static partial string GetVisibilityState();

    [JSImport("globalThis.document.characterSet")]
    public static partial string GetCharacterSet();

    [JSImport("globalThis.document.lastModified")]
    public static partial string GetLastModified();

    [JSImport("globalThis.document.compatMode")]
    public static partial string GetCompatMode();

    [JSImport("globalThis.document.write")]
    public static partial void Write(string? text);

    [JSImport("globalThis.document.writeln")]
    public static partial void Writeln(string? text);

    [JSImport("globalThis.document.hasFocus")]
    public static partial bool HasFocus();
}