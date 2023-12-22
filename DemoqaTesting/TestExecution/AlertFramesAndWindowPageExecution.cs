using DemoqaTesting.WebElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting.TestExecution
{
    [TestClass]
    public class AlertFramesAndWindowPageExecution : BaseTestExecution
    {
        AlertFramesAndWindowPage alertFramesAndWindowPage = new AlertFramesAndWindowPage();

        [TestMethod, TestCategory("Alert,Frames & Windows")]
        public void BrowserWindow_TC01()
        {
            alertFramesAndWindowPage.BrowserWindow("https://demoqa.com/browser-windows", "This is a sample page", "Browser Windows");
        }

        [TestMethod, TestCategory("Alert,Frames & Windows"), TestCategory("Alerts")]
        public void SimpleAlert_TC02()
        {
            alertFramesAndWindowPage.SimpleAlertButton("https://demoqa.com/alerts");
        }

        [TestMethod, TestCategory("Alert,Frames & Windows"), TestCategory("Alerts")]
        public void TimerAlert_TC03()
        {
            alertFramesAndWindowPage.TimerAlertButton("https://demoqa.com/alerts", "timerAlertButton", "This alert appeared after 5 seconds");
        }

        [TestMethod, TestCategory("Alert,Frames & Windows"), TestCategory("Alerts")]
        [DataRow("confirmButton", "You selected Ok")]
        [DataRow("confirmButton", "You selected Cancel")]
        public void ConfirmAlert_TC04(string alertButton, string alertSelection)
        {
            alertFramesAndWindowPage.ConfirmAlertButton("https://demoqa.com/alerts", alertButton, alertSelection);
        }

        [TestMethod, TestCategory("Alert,Frames & Windows"), TestCategory("Alerts")]
        public void PromptBoxAlert_TC05()
        {
            alertFramesAndWindowPage.PromptBoxButton("https://demoqa.com/alerts", "Hello");
        }

        [TestMethod, TestCategory("Alert,Frames & Windows")]
        public void Frame_TC06()
        {
            alertFramesAndWindowPage.Frame("https://demoqa.com/frames", "This is a sample page");
        }

        [TestMethod, TestCategory("Alert,Frames & Windows")]
        public void NestedFrame_TC07()
        {
            alertFramesAndWindowPage.NestedFrame("https://demoqa.com/nestedframes", "Parent frame", "Child Iframe");
        }

        [TestMethod, TestCategory("Alert,Frames & Windows")]
        public void ModelDialog_TC08()
        {
            alertFramesAndWindowPage.ModelDialog("https://demoqa.com/modal-dialogs", "Small Modal", "Large Modal");
        }
    }
}
