using mppl.Entitas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Collections.Generic;

namespace OjopodoTestProject
{
    
    
    /// <summary>
    ///This is a test class for ModelDokumenTest and is intended
    ///to contain all ModelDokumenTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ModelDokumenTest
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
        ///A test for ModelDokumen Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void ModelDokumenConstructorTest()
        {
            ModelDokumen target = new ModelDokumen();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for get
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void getTest()
        {
            ModelDokumen target = new ModelDokumen(); // TODO: Initialize to an appropriate value
            IEnumerable<dokumen> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<dokumen> actual;
            actual = target.get();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getById
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void getByIdTest()
        {
            ModelDokumen target = new ModelDokumen(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            dokumen expected = null; // TODO: Initialize to an appropriate value
            dokumen actual;
            actual = target.getById(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for insert
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void insertTest()
        {
            ModelDokumen target = new ModelDokumen(); // TODO: Initialize to an appropriate value
            string judul = string.Empty; // TODO: Initialize to an appropriate value
            string pengarang = string.Empty; // TODO: Initialize to an appropriate value
            string alamat_fingerprint = string.Empty; // TODO: Initialize to an appropriate value
            string url_dokumen = string.Empty; // TODO: Initialize to an appropriate value
            target.insert(judul, pengarang, alamat_fingerprint, url_dokumen);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for update
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void updateTest()
        {
            ModelDokumen target = new ModelDokumen(); // TODO: Initialize to an appropriate value
            long id = 0; // TODO: Initialize to an appropriate value
            string judul = string.Empty; // TODO: Initialize to an appropriate value
            string pengarang = string.Empty; // TODO: Initialize to an appropriate value
            string alamat_fingerprint = string.Empty; // TODO: Initialize to an appropriate value
            target.update(id, judul, pengarang, alamat_fingerprint);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
