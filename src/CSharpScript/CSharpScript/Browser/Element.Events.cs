namespace CSharpScript.Browser;

[SupportedOSPlatform("browser")]
public partial class Element
{
    [JSImport("globalThis.Element.prototype.addEventListener")]
    public static partial void AddEventListener(IntPtr handle, string type, IntPtr listener);

    [JSImport("globalThis.Element.prototype.removeEventListener")]
    public static partial void RemoveEventListener(IntPtr handle, string type, IntPtr listener);

    [JSImport("globalThis.Element.prototype.dispatchEvent")]
    public static partial bool DispatchEvent(IntPtr handle, IntPtr event_);

    [JSImport("globalThis.Element.prototype.classList")]
    public static partial IntPtr GetClassList(IntPtr handle);

    public ClassList ClassList => new(GetClassList(_jsHandle));

    public void AddEventListener(string type, Action listener) =>
        AddEventListener(_jsHandle, type, IntPtr.Zero);

    public void RemoveEventListener(string type, Action listener) =>
        RemoveEventListener(_jsHandle, type, IntPtr.Zero);

    public void AddEventListener<T>(string type, Action<T> listener) =>
        AddEventListener(_jsHandle, type, IntPtr.Zero);

    public void RemoveEventListener<T>(string type, Action<T> listener) =>
        RemoveEventListener(_jsHandle, type, IntPtr.Zero);

    public bool DispatchEvent(BrowserEvent e) => DispatchEvent(_jsHandle, e.Handle);
}

[SupportedOSPlatform("browser")]
public partial class ClassList
{
    [JSImport("globalThis.DOMTokenList.prototype.add")]
    public static partial void ClassListAdd(IntPtr handle, string className);

    [JSImport("globalThis.DOMTokenList.prototype.remove")]
    public static partial void ClassListRemove(IntPtr handle, string className);

    [JSImport("globalThis.DOMTokenList.prototype.toggle")]
    public static partial bool ClassListToggle(IntPtr handle, string className);

    [JSImport("globalThis.DOMTokenList.prototype.contains")]
    public static partial bool ClassListContains(IntPtr handle, string className);

    [JSImport("globalThis.DOMTokenList.prototype.replace")]
    public static partial bool ClassListReplace(IntPtr handle, string oldClass, string newClass);

    [JSImport("globalThis.DOMTokenList.prototype.length")]
    public static partial int GetClassListLength(IntPtr handle);

    [JSImport("globalThis.DOMTokenList.prototype.item")]
    public static partial string? ClassListItem(IntPtr handle, int index);

    internal readonly IntPtr _jsHandle;

    public ClassList(IntPtr handle)
    {
        _jsHandle = handle;
    }

    public void Add(string className) => ClassListAdd(_jsHandle, className);
    public void Remove(string className) => ClassListRemove(_jsHandle, className);
    public bool Toggle(string className) => ClassListToggle(_jsHandle, className);
    public bool Contains(string className) => ClassListContains(_jsHandle, className);
    public bool Replace(string oldClass, string newClass) => ClassListReplace(_jsHandle, oldClass, newClass);
    public int Length => GetClassListLength(_jsHandle);
    public string? Item(int index) => ClassListItem(_jsHandle, index);
}
