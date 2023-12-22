using DemoqaTesting.WebElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting.TestExecution
{
    [TestClass]
    public class WidgetPageExecution : BaseTestExecution
    {
        WidgetPage widgetPage = new WidgetPage();

        [TestMethod, TestCategory("Widgets")]
        public void Accordian_TC01()
        {
            widgetPage.Accordian("https://demoqa.com/accordian");
        }

        [TestMethod, TestCategory("Widgets")]
        public void AutoComplete_TC02()
        {
            widgetPage.AutoComplete("https://demoqa.com/auto-complete");
        }

        [TestMethod, TestCategory("Widgets")]
        public void DatePicker_TC03()
        {
            widgetPage.DatePicker("https://demoqa.com/date-picker");
        }

        [TestMethod, TestCategory("Widgets")]
        public void Slider_TC04()
        {
            widgetPage.Slider("https://demoqa.com/slider");
        }

        [TestMethod, TestCategory("Widgets")]
        public void ProgressBar_TC05()
        {
            widgetPage.ProgressBar("https://demoqa.com/progress-bar");
        }

        [TestMethod, TestCategory("Widgets")]
        public void Tabs_TC06()
        {
            widgetPage.Tabs("https://demoqa.com/tabs");
        }

        [TestMethod, TestCategory("Widgets")]
        public void ToolTips_TC07()
        {
            widgetPage.ToolTips("https://demoqa.com/tool-tips");
        }

        [TestMethod, TestCategory("Widgets")]
        public void Menu_TC08()
        {
            widgetPage.Menu("https://demoqa.com/menu");
        }

        [TestMethod, TestCategory("Widgets")]
        public void SelectMenu_TC09()
        {
            widgetPage.SelectMenu("https://demoqa.com/select-menu");
        }
    }
}
