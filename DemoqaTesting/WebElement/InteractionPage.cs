using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DemoqaTesting.WebElement
{
    public class InteractionPage : DemoQABase
    {
        public void Sortable(string url, string button, int itemIndex, int offsetX, int offsetY, string expectedText, string locator)
        {
            driver.Url = url;
            driver.FindElement(By.Id(button)).Click();
            Actions action = new Actions(driver);
            var listSortable = driver.FindElements(By.XPath(locator));
            var item = listSortable[itemIndex];
            action.DragAndDropToOffset(item, offsetX, offsetY).Perform();
            string text = item.Text;
            Assert.AreNotEqual(expectedText, text);
        }

        public void Selectable(string url, string button, int itemIndex1, int itemIndex2, string expectedText1, string expectedText2, string locator)
        {
            driver.Url = url;
            driver.FindElement(By.Id(button)).Click();
            var selection = driver.FindElements(By.XPath(locator));
            selection[itemIndex1].Click();
            selection[itemIndex2].Click();
            string text1 = selection[itemIndex1].Text;
            string text2 = selection[itemIndex2].Text;
            Assert.AreEqual(expectedText1, text1);
            Assert.AreEqual(expectedText2, text2);
        }

        public void Resizeable(string url)
        {
            driver.Url = url;
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath("//*[@class='react-resizable-handle react-resizable-handle-se']"));
            action.ClickAndHold(element);
            action.MoveByOffset(250, 50);
            action.Release().Perform();
        }

        public void Droppable(string url, string button, string source, string target, string expectedDroppedMessage)
        {
            driver.Url = url;
            driver.FindElement(By.Id(button)).Click();
            Actions actions = new Actions(driver);
            IWebElement sourceElement = driver.FindElement(By.Id(source));
            IWebElement targetElement = driver.FindElement(By.Id(target));
            actions.DragAndDrop(sourceElement, targetElement).Perform();

            string actualDroppedMessage = targetElement.Text;

            Assert.AreEqual(expectedDroppedMessage, actualDroppedMessage);
        }

        public void RevertDraggable(string url)
        {
            driver.Url = url;
        }

        public void SimpleDragabble(string url)
        {
            driver.Url = url;
            Actions actions = new Actions(driver);
            IWebElement source = driver.FindElement(By.Id("dragBox"));

            actions.DragAndDropToOffset(source, 400, 100).Perform();
        }

        public void AxisRestrictedDragabble(string url)
        {
            driver.Url = url;
            driver.FindElement(By.Id("draggableExample-tab-axisRestriction")).Click();
            Actions actions = new Actions(driver);

            IWebElement dragX = driver.FindElement(By.Id("restrictedX"));
            IWebElement dragY = driver.FindElement(By.Id("restrictedY"));

            actions.DragAndDropToOffset(dragX, 100, 0).Perform();
            actions.DragAndDropToOffset(dragY, 0, 200).Perform();
        }

        public void ContainerRestrictedDragabble(string url)
        {
            driver.Url = url;
            driver.FindElement(By.Id("draggableExample-tab-containerRestriction")).Click();
            Actions actions = new Actions(driver);

            IWebElement containedWithinTheBox = driver.FindElement(By.CssSelector("div[class='draggable ui-widget-content ui-draggable ui-draggable-handle']"));
            IWebElement containedWithinMyParent = driver.FindElement(By.CssSelector("span[class='ui-widget-header ui-draggable ui-draggable-handle']"));

            actions.DragAndDropToOffset(containedWithinTheBox, 150, 50).Perform();
            actions.DragAndDropToOffset(containedWithinMyParent, 30, 50).Perform();
        }

        public void CursorStyleDragabble(string url)
        {
            driver.Url = url;
            driver.FindElement(By.Id("draggableExample-tab-cursorStyle")).Click();
            Actions actions = new Actions(driver);

            IWebElement cursorCenter = driver.FindElement(By.Id("cursorCenter"));
            IWebElement cursorTopLeft = driver.FindElement(By.Id("cursorTopLeft"));
            IWebElement cursorBottom = driver.FindElement(By.Id("cursorBottom"));

            actions.DragAndDropToOffset(cursorCenter, 50, 50).Perform();
            actions.DragAndDropToOffset(cursorTopLeft, 50, 50).Perform();
            actions.DragAndDropToOffset(cursorBottom, 50, 50).Perform();

        }
    }
}
