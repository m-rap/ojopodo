using Microsoft.Office.Interop.Word;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace OjopodoTestProject
{
    
    
    /// <summary>
    ///This is a test class for _ApplicationTest and is intended
    ///to contain all _ApplicationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class _ApplicationTest
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


        internal virtual _Application Create_Application()
        {
            // TODO: Instantiate an appropriate concrete class.
            _Application target = null;
            return target;
        }

        /// <summary>
        ///A test for Documents
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void DocumentsTest()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Documents actual;
            actual = target.Documents;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Application
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void ApplicationTest()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Application actual;
            actual = target.Application;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Quit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void QuitTest()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            object SaveChanges = null; // TODO: Initialize to an appropriate value
            object SaveChangesExpected = null; // TODO: Initialize to an appropriate value
            object OriginalFormat = null; // TODO: Initialize to an appropriate value
            object OriginalFormatExpected = null; // TODO: Initialize to an appropriate value
            object RouteDocument = null; // TODO: Initialize to an appropriate value
            object RouteDocumentExpected = null; // TODO: Initialize to an appropriate value
            target.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
            Assert.AreEqual(SaveChangesExpected, SaveChanges);
            Assert.AreEqual(OriginalFormatExpected, OriginalFormat);
            Assert.AreEqual(RouteDocumentExpected, RouteDocument);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Quit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void QuitTest1()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            object SaveChanges = null; // TODO: Initialize to an appropriate value
            object SaveChangesExpected = null; // TODO: Initialize to an appropriate value
            object OriginalFormat = null; // TODO: Initialize to an appropriate value
            object OriginalFormatExpected = null; // TODO: Initialize to an appropriate value
            object RouteDocument = null; // TODO: Initialize to an appropriate value
            object RouteDocumentExpected = null; // TODO: Initialize to an appropriate value
            target.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
            Assert.AreEqual(SaveChangesExpected, SaveChanges);
            Assert.AreEqual(OriginalFormatExpected, OriginalFormat);
            Assert.AreEqual(RouteDocumentExpected, RouteDocument);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Application
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void ApplicationTest1()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Application actual;
            actual = target.Application;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Documents
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void DocumentsTest1()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Documents actual;
            actual = target.Documents;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Quit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void QuitTest2()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            object SaveChanges = null; // TODO: Initialize to an appropriate value
            object SaveChangesExpected = null; // TODO: Initialize to an appropriate value
            object OriginalFormat = null; // TODO: Initialize to an appropriate value
            object OriginalFormatExpected = null; // TODO: Initialize to an appropriate value
            object RouteDocument = null; // TODO: Initialize to an appropriate value
            object RouteDocumentExpected = null; // TODO: Initialize to an appropriate value
            target.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
            Assert.AreEqual(SaveChangesExpected, SaveChanges);
            Assert.AreEqual(OriginalFormatExpected, OriginalFormat);
            Assert.AreEqual(RouteDocumentExpected, RouteDocument);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Application
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void ApplicationTest2()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Application actual;
            actual = target.Application;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Documents
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void DocumentsTest2()
        {
            _Application target = Create_Application(); // TODO: Initialize to an appropriate value
            Documents actual;
            actual = target.Documents;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
