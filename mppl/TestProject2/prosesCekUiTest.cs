using mppl.Control;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestProject2
{
    
    
    /// <summary>
    ///This is a test class for prosesCekUiTest and is intended
    ///to contain all prosesCekUiTest Unit Tests
    ///</summary>
    [TestClass()]
    public class prosesCekUiTest
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
        ///A test for prosesCekUi Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void prosesCekUiConstructorTest()
        {
            prosesCekUi target = new prosesCekUi();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for setujuBatalCek
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void setujuBatalCekTest()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.setujuBatalCek();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanKemajuan
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanKemajuanTest()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tampilkanKemajuan();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanKonfirmasiBatal
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanKonfirmasiBatalTest()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tampilkanKonfirmasiBatal();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanKonfirmasiBatalCek
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanKonfirmasiBatalCekTest()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tampilkanKonfirmasiBatalCek();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tekanBatal
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tekanBatalTest()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tekanBatal();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for prosesCekUi Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void prosesCekUiConstructorTest1()
        {
            prosesCekUi target = new prosesCekUi();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for setujuBatalCek
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void setujuBatalCekTest1()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.setujuBatalCek();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanKemajuan
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanKemajuanTest1()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tampilkanKemajuan();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanKonfirmasiBatal
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanKonfirmasiBatalTest1()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tampilkanKonfirmasiBatal();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tampilkanKonfirmasiBatalCek
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tampilkanKonfirmasiBatalCekTest1()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tampilkanKonfirmasiBatalCek();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for tekanBatal
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\TIAN\\KULIAH\\SEMESTER 6\\MPPL\\FP\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void tekanBatalTest1()
        {
            prosesCekUi target = new prosesCekUi(); // TODO: Initialize to an appropriate value
            target.tekanBatal();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
