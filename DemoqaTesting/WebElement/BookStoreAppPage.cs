using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace DemoqaTesting.WebElement
{
    public class BookStoreAppPage : DemoQABase
    {
        public void Login(string url)
        {
            driver.Url = url;
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");

            //driver.Url = "https://demoqa.com/login";
            driver.FindElement(By.Id("newUser")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("rohan");
            driver.FindElement(By.Id("lastname")).SendKeys("ali");
            driver.FindElement(By.Id("userName")).SendKeys("rohanali");
            driver.FindElement(By.Id("password")).SendKeys("Rohan@1234");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("register")).Click();
            driver.Url = "https://demoqa.com/login";
            driver.FindElement(By.Id("userName")).SendKeys("rohanali");
            driver.FindElement(By.Id("password")).SendKeys("Rohan@1234");
            driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("submit")).Click();

            string text = driver.FindElement(By.Id("name")).Text;
            Assert.AreEqual("Invalid username or password!", text);
        }

        public void BookStore(string url)
        {
            driver.Url = url;
        }

        public void Profile(string url)
        {
            driver.Url = url;
        }

        public void BookStoreAPI(string url)
        {
            driver.Url = url;
        }
    }
}
