using DemoqaTesting.WebElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting.TestExecution
{
    [TestClass]
    public class FormPageExecution : BaseTestExecution
    {
        FormPage formPage = new FormPage();

        [TestMethod, TestCategory("Forms")]
        public void PracticeForm_TC01()
        {
            formPage.PracticeForm("https://demoqa.com/automation-practice-form");
        }
    }
}
