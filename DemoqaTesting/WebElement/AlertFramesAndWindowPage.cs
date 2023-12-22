using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace DemoqaTesting.WebElement
{
    public class AlertFramesAndWindowPage : DemoQABase
    {
        public void BrowserWindow(string url, string expectedNewBrowserMessage, string expectedMainHeadingText)
        {
            driver.Url = url;

            driver.FindElement(By.Id("windowButton")).Click();

            var handler = driver.WindowHandles;

            driver.SwitchTo().Window(handler[1]);
            var actualChildWindowText = driver.FindElement(By.Id("sampleHeading")).Text;
            Thread.Sleep(1000);
            driver.SwitchTo().Window(handler[1]).Close();
            driver.SwitchTo().Window(handler[0]);
            string actualMainHeadingText = driver.FindElement(By.ClassName("main-header")).Text;
            Assert.AreEqual(expectedNewBrowserMessage, actualChildWindowText);
            Assert.AreEqual(expectedMainHeadingText, actualMainHeadingText);
        }

        public void SimpleAlertButton(string url)
        {
            driver.Url = url;

            driver.FindElement(By.Id("alertButton")).Click();
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();
        }

        public void TimerAlertButton(string url, string alertButtonElement, string expectedAlertBoxText)
        {
            driver.Url = url;

            driver.FindElement(By.Id(alertButtonElement)).Click();
            Thread.Sleep(5000);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            string actualAlertText = simpleAlert.Text;
            simpleAlert.Accept();
            Assert.AreEqual(expectedAlertBoxText, actualAlertText);
        }

        public void ConfirmAlertButton(string url, string alertButtonElement, string expectedAlertSelection)
        {
            driver.Url = url;

            driver.FindElement(By.Id(alertButtonElement)).Click();
            IAlert simpleAlert = driver.SwitchTo().Alert();
            if (expectedAlertSelection == "You selected Ok")
            {
                simpleAlert.Accept();
            }
            else
            {
                simpleAlert.Dismiss();
            }
            string actualSelectionText = driver.FindElement(By.Id("confirmResult")).Text;
            Assert.AreEqual(expectedAlertSelection, actualSelectionText);
        }

        public void PromptBoxButton(string url, string text)
        {
            driver.Url = url;

            driver.FindElement(By.Id("promtButton")).Click();
            IAlert promptAlert = driver.SwitchTo().Alert();
            promptAlert.SendKeys(text);
            promptAlert.Accept();
            string actualAlertText = driver.FindElement(By.Id("promptResult")).Text;
            Assert.AreEqual("You entered " + text, actualAlertText);

        }

        public void Frame(string url, string expectedTextInsideFrame)
        {
            driver.Url = url;

            driver.SwitchTo().Frame("frame1");
            string actualTextInsideFrame = driver.FindElement(By.Id("sampleHeading")).Text;
            driver.SwitchTo().DefaultContent();
            Assert.AreEqual(expectedTextInsideFrame, actualTextInsideFrame);
        }

        public void NestedFrame(string url, string expectedParentFrameText, string expectedChildFrameText)
        {
            driver.Url = url;

            driver.SwitchTo().Frame("frame1");
            string actualParentFrameText = driver.FindElement(By.TagName("body")).Text;
            driver.SwitchTo().Frame(0);
            string actualChildFrameText = driver.FindElement(By.TagName("body")).Text;
            Assert.AreEqual(expectedChildFrameText, actualChildFrameText);
            driver.SwitchTo().DefaultContent();
        }

        public void ModelDialog(string url, string expectedSmallModalText, string expectedLargeModalText)
        {
            driver.Url = url;

            driver.FindElement(By.Id("showSmallModal")).Click();
            string actualsmallModalText = driver.FindElement(By.CssSelector("div[class='modal-title h4']")).Text;
            Thread.Sleep(2000);
            driver.FindElement(By.Id("closeSmallModal")).Click();
            Assert.AreEqual(expectedSmallModalText, actualsmallModalText);

            driver.FindElement(By.Id("showLargeModal")).Click();
            string actualLargeModalText = driver.FindElement(By.CssSelector("div[class='modal-title h4']")).Text;
            Thread.Sleep(2000);
            driver.FindElement(By.Id("closeLargeModal")).Click();
            Assert.AreEqual(expectedSmallModalText, actualsmallModalText);
        }
    }
}
