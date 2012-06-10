using Microsoft.Office.Interop.Word;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace OjopodoTestProject
{
    
    
    /// <summary>
    ///This is a test class for RangeTest and is intended
    ///to contain all RangeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RangeTest
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


        internal virtual Range CreateRange()
        {
            // TODO: Instantiate an appropriate concrete class.
            Range target = null;
            return target;
        }

        /// <summary>
        ///A test for Text
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void TextTest()
{
Range target = CreateRange(); // TODO: Initialize to an appropriate value
string expected = string.Empty; // TODO: Initialize to an appropriate value
    string actual;
    target[] = expected;
    actual = target.Text;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

        /// <summary>
        ///A test for Text
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void TextTest1()
{
Range target = CreateRange(); // TODO: Initialize to an appropriate value
string expected = string.Empty; // TODO: Initialize to an appropriate value
    string actual;
    target[] = expected;
    actual = target.Text;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}

        /// <summary>
        ///A test for Text
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void TextTest2()
{
Range target = CreateRange(); // TODO: Initialize to an appropriate value
string expected = string.Empty; // TODO: Initialize to an appropriate value
    string actual;
    target[] = expected;
    actual = target.Text;
    Assert.AreEqual(expected, actual);
    Assert.Inconclusive("Verify the correctness of this test method.");
}
    }
}
