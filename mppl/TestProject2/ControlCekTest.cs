using mppl.Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.UI.WebControls;
using System.IO;

namespace TestProject2
{
    
    
    /// <summary>
    ///This is a test class for ControlCekTest and is intended
    ///to contain all ControlCekTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ControlCekTest
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
        ///A test for upload
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void uploadTest()
        {
            ControlCek target = new ControlCek(); // TODO: Initialize to an appropriate value
            FileUpload input = null; // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.upload(input, path);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ekstrakPdf
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        [DeploymentItem("mppl.dll")]
        public void ekstrakPdfTest()
        {
            ControlCek_Accessor target = new ControlCek_Accessor(); // TODO: Initialize to an appropriate value
            FileStream stream1 = File.Open("C:\\Users\\chrisna\\Desktop\\E-TICKET RECEIPT.PDF", FileMode.Open);
            Stream path = stream1; // TODO: Initialize to an appropriate value
            target.ekstrakPdf(path);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for createFingerPrint
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        [DeploymentItem("mppl.dll")]
        public void createFingerPrintTest()
        {
            ControlCek_Accessor target = new ControlCek_Accessor(); // TODO: Initialize to an appropriate value
            string input = "sdas"; // TODO: Initialize to an appropriate value
            target.createFingerPrint(input);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ControlCek Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void ControlCekConstructorTest()
        {
            ControlCek target = new ControlCek();
           // Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
