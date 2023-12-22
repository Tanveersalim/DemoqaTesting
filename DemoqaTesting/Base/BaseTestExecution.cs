using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoqaTesting
{

    [TestClass]
    public class BaseTestExecution
    {
        DemoQABase demoQABase = new DemoQABase();

        #region Initializations and Cleanups

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            demoQABase.InitializeChromeDriver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            demoQABase.CloseChromeDriver();
        }

        #endregion
    }
}
