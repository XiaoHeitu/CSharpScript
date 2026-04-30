using CSharpScript.Browser;

namespace CSharpScript
{
    [SupportedOSPlatform("browser")]
    public class CSharpScriptTest
    {
        public static WindowTest Window
        {
            get => new WindowTest();
        }
    }

    public class WindowTest
    {
        private System.Runtime.InteropServices.JavaScript.JSObject _windowObj;
        public WindowTest()
        {
            this._windowObj = JSHost.GlobalThis;
        }

        public DocumentTest Document
        {
            get => new DocumentTest(this._windowObj);

        }
    }

    public class DocumentTest
    {

        private System.Runtime.InteropServices.JavaScript.JSObject _documentObj;
        public DocumentTest(System.Runtime.InteropServices.JavaScript.JSObject windowObj)
        {
            _documentObj = windowObj.GetPropertyAsJSObject("document");
        }

        public string Title
        {
            get => this._documentObj.GetPropertyAsString("title");

            set => this._documentObj.SetProperty("title", value);
        }
    }
}