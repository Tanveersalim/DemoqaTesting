using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Threading;

namespace DemoqaTesting
{
    public class ElementPage : DemoQABase
    {
        public void TextBox(string url, string name, string email, string currentAddress, string permanentAddress)
        {
            driver.Url = url;

            driver.FindElement(By.Id("userName")).SendKeys(name);
            driver.FindElement(By.Id("userEmail")).SendKeys(email);
            driver.FindElement(By.Id("currentAddress")).SendKeys(currentAddress);
            driver.FindElement(By.Id("permanentAddress")).SendKeys(permanentAddress);
            driver.FindElement(By.Id("submit")).Click();

            string nameTxt = driver.FindElement(By.Id("name")).Text;
            string emailTxt = driver.FindElement(By.Id("email")).Text;
            var address = driver.FindElements(By.Id("currentAddress"));
            var permAddress = driver.FindElements(By.Id("permanentAddress"));

            Assert.AreEqual("Name:" + name, nameTxt);
            Assert.AreEqual("Email:" + email, emailTxt);
            Assert.AreEqual("Current Address :" + currentAddress, address[1].Text);
            Assert.AreEqual("Permananet Address :" + permanentAddress, permAddress[1].Text);
        }

        public void CheckBox(string url)
        {
            driver.Url = url;

            driver.FindElement(By.CssSelector("button[class='rct-collapse rct-collapse-btn']")).Click();
            Thread.Sleep(1000);

            var list = driver.FindElements(By.CssSelector("button[class='rct-collapse rct-collapse-btn']"));
            list[1].Click();
            Thread.Sleep(1000);
            list[2].Click();
            Thread.Sleep(1000);
            list[3].Click();
            Thread.Sleep(1000);

            driver.FindElement(By.CssSelector("button[class='rct-option rct-option-expand-all']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("button[class='rct-option rct-option-collapse-all']")).Click();

        }

        public void RadioButton(string url, string expectedYesMessage, string expectedImpressiveMessage)
        {
            driver.Url = url;

            driver.FindElement(By.CssSelector("label[for='yesRadio']")).Click();
            var actualYesMessageTxt = driver.FindElement(By.CssSelector("p[class='mt-3']")).Text;
            Assert.AreEqual(expectedYesMessage, actualYesMessageTxt);

            driver.FindElement(By.CssSelector("label[for='impressiveRadio']")).Click();
            var actualImpressiveMessageTxt = driver.FindElement(By.CssSelector("p[class='mt-3']")).Text;
            Assert.AreEqual(expectedImpressiveMessage, actualImpressiveMessageTxt);
        }

        public void WebTable(string url)
        {
            driver.Url = url;
        }

        public void Button(string url, string expectedDoubleClickMessage, string expectedRightClickMessage)
        {
            driver.Url = url;
            Actions actions = new Actions(driver);
            IWebElement doubleClickMeBTN = driver.FindElement(By.Id("doubleClickBtn"));
            IWebElement rightClickMeBTN = driver.FindElement(By.Id("rightClickBtn"));

            actions.DoubleClick(doubleClickMeBTN).Perform();
            Thread.Sleep(1000);
            actions.ContextClick(rightClickMeBTN).Perform();

            var actualDoubleClickMessage = driver.FindElement(By.Id("doubleClickMessage")).Text;
            var actualRightClickMessage = driver.FindElement(By.Id("rightClickMessage")).Text;

            Assert.AreEqual(expectedDoubleClickMessage, actualDoubleClickMessage);
            Assert.AreEqual(expectedRightClickMessage, actualRightClickMessage);
        }

        public void Link(string url, string linkName, string expectedLinkResponseText)
        {
            driver.Url = url;

            driver.FindElement(By.Id("simpleLink")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("unauthorized")).Click();

            string actualLinkResponseText = driver.FindElement(By.Id("linkResponse")).Text;
            Assert.AreEqual(expectedLinkResponseText, actualLinkResponseText);

        }

        public void BrokenLinkAndImage(string url)
        {
            driver.Url = url;

            List<IWebElement> link = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement lin in link)
            {
                if (lin.Text == "Click Here for Valid Link")
                {
                    lin.Click();
                    Thread.Sleep(2000);
                    driver.Navigate().GoToUrl("https://demoqa.com/broken");
                    driver.Navigate().Back();

                }
                else if (lin.Text == "Click Here for Broken Link")
                {
                    lin.Click();
                    Thread.Sleep(2000);
                    driver.Navigate().GoToUrl("https://demoqa.com/broken");
                    driver.Navigate().Back();
                }

            }
            string code = driver.FindElement(By.TagName("h3")).Text;
            Assert.AreEqual("Status Codes", code);
        }

        public void UploadAndDownload(string url)
        {
            driver.Url = url;

            driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("uploadFile")).SendKeys("E:\\download.jpg");
        }

        public void DynamicProperties(string url)
        {
            driver.Url = url;
            driver.FindElement(By.Id("colorChange")).Click();
            Thread.Sleep(6000);
        }
    }
}
