using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace DemoqaTesting
{
    public class DemoQABase
    {
        public static IWebDriver driver;
        public void InitializeChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("incognito");
            var myDriver = new ChromeDriver(chromeOptions);
            myDriver.Manage().Window.Maximize();
            driver = myDriver;
        }

        public void CloseChromeDriver()
        {
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
