using mppl.Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestProject2
{
    
    
    /// <summary>
    ///This is a test class for PenjelajahDirektoriUiTest and is intended
    ///to contain all PenjelajahDirektoriUiTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PenjelajahDirektoriUiTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for PenjelajahDirektoriUi Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void PenjelajahDirektoriUiConstructorTest()
        {
            PenjelajahDirektoriUi target = new PenjelajahDirektoriUi();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for pilihDokumen
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void pilihDokumenTest()
        {
            PenjelajahDirektoriUi target = new PenjelajahDirektoriUi(); // TODO: Initialize to an appropriate value
            target.pilihDokumen();
          //  Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanDirektori
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanDirektoriTest()
        {
            PenjelajahDirektoriUi target = new PenjelajahDirektoriUi(); // TODO: Initialize to an appropriate value
            target.tampilkanDirektori();
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
