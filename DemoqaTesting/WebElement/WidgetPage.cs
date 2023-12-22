using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace DemoqaTesting.WebElement
{
    public class WidgetPage : DemoQABase
    {

        public void Accordian(string url)
        {
            driver.Url = url;

            driver.FindElement(By.Id("section1Heading")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("section2Heading")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("section3Heading")).Click();
        }

        public void AutoComplete(string url)
        {
            driver.Url = url;
        }

        public void DatePicker(string url)
        {
            driver.Url = url;
        }

        public void Slider(string url)
        {
            driver.Url = url;

            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath("//*[@class='range-slider range-slider--primary']"));
            action.ClickAndHold(element);
            action.MoveByOffset(70, 0);
            action.Release().Perform();
        }

        public void ProgressBar(string url)
        {
            driver.Url = url;
            driver.FindElement(By.Id("startStopButton")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("startStopButton")).Click();
            Thread.Sleep(1000);
        }

        public void Tabs(string url)
        {
            driver.Url = url;

            driver.FindElement(By.Id("demo-tab-what")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("demo-tab-origin")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("demo-tab-use")).Click();
        }

        public void ToolTips(string url)
        {
            driver.Url = url;

            driver.FindElement(By.Id("toolTipButton")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("toolTipTextField")).Click();
            Thread.Sleep(1000);
            List<IWebElement> element3 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement ele in element3)
            {
                if (ele.Text == "Contrary")
                {
                    ele.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> element4 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement ele in element4)
            {
                if (ele.Text == "1.10.32")
                {
                    ele.Click();

                }

            }
        }

        public void Menu(string url)
        {
            driver.Url = url;

            List<IWebElement> item1 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in item1)
            {
                if (item.Text == "Main Item 1")
                {
                    item.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> item2 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in item2)
            {
                if (item.Text == "Main Item 2")
                {
                    item.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> item2sub = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in item2sub)
            {
                if (item.Text == "Sub Item")
                {
                    item.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> subsubitem = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in subsubitem)
            {
                if (item.Text == "SUB SUB LIST »")
                {
                    item.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> subsubitem1 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in subsubitem1)
            {
                if (item.Text == "Sub Sub Item 1")
                {
                    item.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> subsubitem2 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in subsubitem2)
            {
                if (item.Text == "Sub Sub Item 2")
                {
                    item.Click();

                }

            }
            Thread.Sleep(1000);
            List<IWebElement> item3 = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            foreach (IWebElement item in item3)
            {
                if (item.Text == "Main Item 3")
                {
                    item.Click();

                }

            }
        }

        public void SelectMenu(string url)
        {
            driver.Url = url;

            var selectmenu = driver.FindElement(By.Id("oldSelectMenu"));
            var selectdropdown = new SelectElement(selectmenu);
            selectdropdown.SelectByText("Yellow");
            Thread.Sleep(1000);
            selectdropdown.SelectByText("Red");
            Thread.Sleep(1000);
            selectdropdown.SelectByText("Green");
            Thread.Sleep(1000);
            selectdropdown.SelectByText("White");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@value='volvo']")).Click();
        }
    }
}
