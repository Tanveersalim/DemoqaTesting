using DemoqaTesting.WebElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting.TestExecution
{
    [TestClass]
    public class InteractionPageExecution : BaseTestExecution
    {
        InteractionPage interactionPage = new InteractionPage();

        [TestMethod, TestCategory("Interactions"), TestCategory("List And Grid")]
        [DataRow("demo-tab-list", 1, 0, 100, "Two", "//*[@class='list-group-item list-group-item-action']")]
        [DataRow("demo-tab-grid", 7, 100, 100, "One", "//*[@class='list-group-item list-group-item-action']")]
        public void Sortable_TC01(string button, int itemIndex, int offsetX, int offsetY, string expectedText, string locator)
        {
            interactionPage.Sortable("https://demoqa.com/sortable", button, itemIndex, offsetX, offsetY, expectedText, locator);
        }

        [TestMethod, TestCategory("Interactions"), TestCategory("List And Grid")]
        [DataRow("demo-tab-list", 0, 2, "Cras justo odio", "Morbi leo risus", "//*[@class='mt-2 list-group-item list-group-item-action']")]
        [DataRow("demo-tab-grid", 1, 3, "Two", "Four", "//*[@class='list-group-item list-group-item-action']")]
        public void Selectable_TC02(string button, int itemIndex1, int itemIndex2, string text1, string text2, string locator)
        {
            interactionPage.Selectable("https://demoqa.com/selectable", button, itemIndex1, itemIndex2, text1, text2, locator);
        }

        [TestMethod, TestCategory("Interactions")]
        public void Resizeable_TC03()
        {
            interactionPage.Resizeable("https://demoqa.com/resizable");
        }

        [TestMethod, TestCategory("Interactions")]
        [DataRow("droppableExample-tab-simple", "draggable", "droppable", "Dropped!")]
        //[DataRow("droppableExample-tab-accept", "acceptable", "droppable", "Dropped!")]
        [DataRow("droppableExample-tab-preventPropogation", "dragBox", "notGreedyInnerDropBox", "Dropped!")]
        //[DataRow("droppableExample-tab-revertable", "revertable", "droppable", "Dropped!")]
        public void Droppable_TC04(string button, string source, string target, string droppedMessage)
        {
            interactionPage.Droppable("https://demoqa.com/droppable", button, source, target, droppedMessage);
        }

        [TestMethod, TestCategory("Interactions"), TestCategory("Dragabble")]
        public void SimpleDragabble_TC08()
        {
            interactionPage.SimpleDragabble("https://demoqa.com/dragabble");
        }

        [TestMethod, TestCategory("Interactions"), TestCategory("Dragabble")]
        public void AxisRestrictedDragabble_TC09()
        {
            interactionPage.AxisRestrictedDragabble("https://demoqa.com/dragabble");
        }

        [TestMethod, TestCategory("Interactions"), TestCategory("Dragabble")]
        public void ContainerRestrictedDragabble_TC010()
        {
            interactionPage.ContainerRestrictedDragabble("https://demoqa.com/dragabble");
        }

        [TestMethod, TestCategory("Interactions"), TestCategory("Dragabble")]
        public void CursorStyleDragabble_TC11()
        {
            interactionPage.CursorStyleDragabble("https://demoqa.com/dragabble");
        }
    }
}
