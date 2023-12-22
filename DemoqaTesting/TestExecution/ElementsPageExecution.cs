using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting
{
    [TestClass]
    public class ElementsPageExecution : BaseTestExecution
    {
        ElementPage elementPage = new ElementPage();

        private const string dataSourceProviderInvariantName = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        private const string dataSoruceConnectionString = "Elements.xml";

        [TestMethod, TestCategory("Elements")]
        [DataSource(dataSourceProviderInvariantName, dataSoruceConnectionString, "TextboxData", DataAccessMethod.Sequential)]
        public void TextBox_TC01()
        {
            string url = instance.DataRow["url"].ToString();
            string username = instance.DataRow["username"].ToString();
            string emailAddress = instance.DataRow["emailAddress"].ToString();
            string address = instance.DataRow["address"].ToString();
            string permanentAddress = instance.DataRow["permanentAddress"].ToString();

            elementPage.TextBox(url, username, emailAddress, address, permanentAddress);
        }

        [TestMethod, TestCategory("Elements")]
        public void CheckBox_TC02()
        {
            elementPage.CheckBox("https://demoqa.com/checkbox");
        }

        [TestMethod, TestCategory("Elements")]
        [DataSource(dataSourceProviderInvariantName, dataSoruceConnectionString, "RadiobuttonData", DataAccessMethod.Sequential)]
        public void RadioButton_TC03()
        {
            string url = instance.DataRow["url"].ToString();
            string expectedYesMessage = instance.DataRow["expectedYesMessage"].ToString();
            string expectedImpressiveMessage = instance.DataRow["expectedImpressiveMessage"].ToString();

            elementPage.RadioButton(url, expectedYesMessage, expectedImpressiveMessage);
        }

        [TestMethod, TestCategory("Elements")]
        public void WebTable_TC04()
        {
            elementPage.WebTable("https://demoqa.com/webtables");
        }

        [TestMethod, TestCategory("Elements")]
        public void Button_TC05()
        {
            elementPage.Button("https://demoqa.com/buttons", "You have done a double click", "You have done a right click");
        }

        [TestMethod, TestCategory("Elements")]
        [DataSource(dataSourceProviderInvariantName, dataSoruceConnectionString, "LinkData", DataAccessMethod.Sequential)]
        public void Link_TC06()
        {
            string link = instance.DataRow["linkName"].ToString();
            string linkResponse = instance.DataRow["linkResponseText"].ToString();

            elementPage.Link("https://demoqa.com/links", link, linkResponse);
        }

        [TestMethod, TestCategory("Elements")]
        public void BrokenLinkAndImage_TC07()
        {
            elementPage.BrokenLinkAndImage("https://demoqa.com/broken");
        }

        [TestMethod, TestCategory("Elements")]
        public void UploadAndDownload_TC08()
        {
            elementPage.UploadAndDownload("https://demoqa.com/upload-download");
        }

        [TestMethod, TestCategory("Elements")]
        public void DynamicProperties_TC08()
        {
            elementPage.DynamicProperties("https://demoqa.com/dynamic-properties");
        }

    }
}
