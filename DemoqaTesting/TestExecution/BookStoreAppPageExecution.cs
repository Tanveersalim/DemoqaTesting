using DemoqaTesting.WebElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting.TestExecution
{
    [TestClass]
    public class BookStoreAppPageExecution : BaseTestExecution
    {
        BookStoreAppPage bookStoreApp = new BookStoreAppPage();

        [TestMethod, TestCategory("BookStoreApplication")]
        public void Login_TC01()
        {
            bookStoreApp.Login("https://demoqa.com/login");
        }

        [TestMethod, TestCategory("BookStore")]
        public void BookStore_TC02()
        {
            bookStoreApp.BookStore("https://demoqa.com/books");
        }

        [TestMethod, TestCategory("BookStore")]
        public void Profile_TC03()
        {
            bookStoreApp.Profile("https://demoqa.com/profile");
        }

        [TestMethod, TestCategory("BookStore")]
        public void BookStoreAPI_TC04()
        {
            bookStoreApp.BookStoreAPI("https://demoqa.com/swagger/");
        }
    }
}
