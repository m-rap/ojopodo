using Microsoft.Office.Interop.Word;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace OjopodoTestProject
{
    
    
    /// <summary>
    ///This is a test class for DocumentsTest and is intended
    ///to contain all DocumentsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DocumentsTest
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


        internal virtual Documents CreateDocuments()
        {
            // TODO: Instantiate an appropriate concrete class.
            Documents target = null;
            return target;
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void OpenTest()
        {
            Documents target = CreateDocuments(); // TODO: Initialize to an appropriate value
            object FileName = null; // TODO: Initialize to an appropriate value
            object FileNameExpected = null; // TODO: Initialize to an appropriate value
            object ConfirmConversions = null; // TODO: Initialize to an appropriate value
            object ConfirmConversionsExpected = null; // TODO: Initialize to an appropriate value
            object ReadOnly = null; // TODO: Initialize to an appropriate value
            object ReadOnlyExpected = null; // TODO: Initialize to an appropriate value
            object AddToRecentFiles = null; // TODO: Initialize to an appropriate value
            object AddToRecentFilesExpected = null; // TODO: Initialize to an appropriate value
            object PasswordDocument = null; // TODO: Initialize to an appropriate value
            object PasswordDocumentExpected = null; // TODO: Initialize to an appropriate value
            object PasswordTemplate = null; // TODO: Initialize to an appropriate value
            object PasswordTemplateExpected = null; // TODO: Initialize to an appropriate value
            object Revert = null; // TODO: Initialize to an appropriate value
            object RevertExpected = null; // TODO: Initialize to an appropriate value
            object WritePasswordDocument = null; // TODO: Initialize to an appropriate value
            object WritePasswordDocumentExpected = null; // TODO: Initialize to an appropriate value
            object WritePasswordTemplate = null; // TODO: Initialize to an appropriate value
            object WritePasswordTemplateExpected = null; // TODO: Initialize to an appropriate value
            object Format = null; // TODO: Initialize to an appropriate value
            object FormatExpected = null; // TODO: Initialize to an appropriate value
            object Encoding = null; // TODO: Initialize to an appropriate value
            object EncodingExpected = null; // TODO: Initialize to an appropriate value
            object Visible = null; // TODO: Initialize to an appropriate value
            object VisibleExpected = null; // TODO: Initialize to an appropriate value
            object OpenAndRepair = null; // TODO: Initialize to an appropriate value
            object OpenAndRepairExpected = null; // TODO: Initialize to an appropriate value
            object DocumentDirection = null; // TODO: Initialize to an appropriate value
            object DocumentDirectionExpected = null; // TODO: Initialize to an appropriate value
            object NoEncodingDialog = null; // TODO: Initialize to an appropriate value
            object NoEncodingDialogExpected = null; // TODO: Initialize to an appropriate value
            object XMLTransform = null; // TODO: Initialize to an appropriate value
            object XMLTransformExpected = null; // TODO: Initialize to an appropriate value
            Document expected = null; // TODO: Initialize to an appropriate value
            Document actual;
            actual = target.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            Assert.AreEqual(FileNameExpected, FileName);
            Assert.AreEqual(ConfirmConversionsExpected, ConfirmConversions);
            Assert.AreEqual(ReadOnlyExpected, ReadOnly);
            Assert.AreEqual(AddToRecentFilesExpected, AddToRecentFiles);
            Assert.AreEqual(PasswordDocumentExpected, PasswordDocument);
            Assert.AreEqual(PasswordTemplateExpected, PasswordTemplate);
            Assert.AreEqual(RevertExpected, Revert);
            Assert.AreEqual(WritePasswordDocumentExpected, WritePasswordDocument);
            Assert.AreEqual(WritePasswordTemplateExpected, WritePasswordTemplate);
            Assert.AreEqual(FormatExpected, Format);
            Assert.AreEqual(EncodingExpected, Encoding);
            Assert.AreEqual(VisibleExpected, Visible);
            Assert.AreEqual(OpenAndRepairExpected, OpenAndRepair);
            Assert.AreEqual(DocumentDirectionExpected, DocumentDirection);
            Assert.AreEqual(NoEncodingDialogExpected, NoEncodingDialog);
            Assert.AreEqual(XMLTransformExpected, XMLTransform);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void OpenTest1()
        {
            Documents target = CreateDocuments(); // TODO: Initialize to an appropriate value
            object FileName = null; // TODO: Initialize to an appropriate value
            object FileNameExpected = null; // TODO: Initialize to an appropriate value
            object ConfirmConversions = null; // TODO: Initialize to an appropriate value
            object ConfirmConversionsExpected = null; // TODO: Initialize to an appropriate value
            object ReadOnly = null; // TODO: Initialize to an appropriate value
            object ReadOnlyExpected = null; // TODO: Initialize to an appropriate value
            object AddToRecentFiles = null; // TODO: Initialize to an appropriate value
            object AddToRecentFilesExpected = null; // TODO: Initialize to an appropriate value
            object PasswordDocument = null; // TODO: Initialize to an appropriate value
            object PasswordDocumentExpected = null; // TODO: Initialize to an appropriate value
            object PasswordTemplate = null; // TODO: Initialize to an appropriate value
            object PasswordTemplateExpected = null; // TODO: Initialize to an appropriate value
            object Revert = null; // TODO: Initialize to an appropriate value
            object RevertExpected = null; // TODO: Initialize to an appropriate value
            object WritePasswordDocument = null; // TODO: Initialize to an appropriate value
            object WritePasswordDocumentExpected = null; // TODO: Initialize to an appropriate value
            object WritePasswordTemplate = null; // TODO: Initialize to an appropriate value
            object WritePasswordTemplateExpected = null; // TODO: Initialize to an appropriate value
            object Format = null; // TODO: Initialize to an appropriate value
            object FormatExpected = null; // TODO: Initialize to an appropriate value
            object Encoding = null; // TODO: Initialize to an appropriate value
            object EncodingExpected = null; // TODO: Initialize to an appropriate value
            object Visible = null; // TODO: Initialize to an appropriate value
            object VisibleExpected = null; // TODO: Initialize to an appropriate value
            object OpenAndRepair = null; // TODO: Initialize to an appropriate value
            object OpenAndRepairExpected = null; // TODO: Initialize to an appropriate value
            object DocumentDirection = null; // TODO: Initialize to an appropriate value
            object DocumentDirectionExpected = null; // TODO: Initialize to an appropriate value
            object NoEncodingDialog = null; // TODO: Initialize to an appropriate value
            object NoEncodingDialogExpected = null; // TODO: Initialize to an appropriate value
            object XMLTransform = null; // TODO: Initialize to an appropriate value
            object XMLTransformExpected = null; // TODO: Initialize to an appropriate value
            Document expected = null; // TODO: Initialize to an appropriate value
            Document actual;
            actual = target.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            Assert.AreEqual(FileNameExpected, FileName);
            Assert.AreEqual(ConfirmConversionsExpected, ConfirmConversions);
            Assert.AreEqual(ReadOnlyExpected, ReadOnly);
            Assert.AreEqual(AddToRecentFilesExpected, AddToRecentFiles);
            Assert.AreEqual(PasswordDocumentExpected, PasswordDocument);
            Assert.AreEqual(PasswordTemplateExpected, PasswordTemplate);
            Assert.AreEqual(RevertExpected, Revert);
            Assert.AreEqual(WritePasswordDocumentExpected, WritePasswordDocument);
            Assert.AreEqual(WritePasswordTemplateExpected, WritePasswordTemplate);
            Assert.AreEqual(FormatExpected, Format);
            Assert.AreEqual(EncodingExpected, Encoding);
            Assert.AreEqual(VisibleExpected, Visible);
            Assert.AreEqual(OpenAndRepairExpected, OpenAndRepair);
            Assert.AreEqual(DocumentDirectionExpected, DocumentDirection);
            Assert.AreEqual(NoEncodingDialogExpected, NoEncodingDialog);
            Assert.AreEqual(XMLTransformExpected, XMLTransform);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Open
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\OjoPodo\\mppl\\mppl", "/")]
        [UrlToTest("http://localhost:1904/")]
        public void OpenTest2()
        {
            Documents target = CreateDocuments(); // TODO: Initialize to an appropriate value
            object FileName = null; // TODO: Initialize to an appropriate value
            object FileNameExpected = null; // TODO: Initialize to an appropriate value
            object ConfirmConversions = null; // TODO: Initialize to an appropriate value
            object ConfirmConversionsExpected = null; // TODO: Initialize to an appropriate value
            object ReadOnly = null; // TODO: Initialize to an appropriate value
            object ReadOnlyExpected = null; // TODO: Initialize to an appropriate value
            object AddToRecentFiles = null; // TODO: Initialize to an appropriate value
            object AddToRecentFilesExpected = null; // TODO: Initialize to an appropriate value
            object PasswordDocument = null; // TODO: Initialize to an appropriate value
            object PasswordDocumentExpected = null; // TODO: Initialize to an appropriate value
            object PasswordTemplate = null; // TODO: Initialize to an appropriate value
            object PasswordTemplateExpected = null; // TODO: Initialize to an appropriate value
            object Revert = null; // TODO: Initialize to an appropriate value
            object RevertExpected = null; // TODO: Initialize to an appropriate value
            object WritePasswordDocument = null; // TODO: Initialize to an appropriate value
            object WritePasswordDocumentExpected = null; // TODO: Initialize to an appropriate value
            object WritePasswordTemplate = null; // TODO: Initialize to an appropriate value
            object WritePasswordTemplateExpected = null; // TODO: Initialize to an appropriate value
            object Format = null; // TODO: Initialize to an appropriate value
            object FormatExpected = null; // TODO: Initialize to an appropriate value
            object Encoding = null; // TODO: Initialize to an appropriate value
            object EncodingExpected = null; // TODO: Initialize to an appropriate value
            object Visible = null; // TODO: Initialize to an appropriate value
            object VisibleExpected = null; // TODO: Initialize to an appropriate value
            object OpenAndRepair = null; // TODO: Initialize to an appropriate value
            object OpenAndRepairExpected = null; // TODO: Initialize to an appropriate value
            object DocumentDirection = null; // TODO: Initialize to an appropriate value
            object DocumentDirectionExpected = null; // TODO: Initialize to an appropriate value
            object NoEncodingDialog = null; // TODO: Initialize to an appropriate value
            object NoEncodingDialogExpected = null; // TODO: Initialize to an appropriate value
            object XMLTransform = null; // TODO: Initialize to an appropriate value
            object XMLTransformExpected = null; // TODO: Initialize to an appropriate value
            Document expected = null; // TODO: Initialize to an appropriate value
            Document actual;
            actual = target.Open(ref FileName, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
            Assert.AreEqual(FileNameExpected, FileName);
            Assert.AreEqual(ConfirmConversionsExpected, ConfirmConversions);
            Assert.AreEqual(ReadOnlyExpected, ReadOnly);
            Assert.AreEqual(AddToRecentFilesExpected, AddToRecentFiles);
            Assert.AreEqual(PasswordDocumentExpected, PasswordDocument);
            Assert.AreEqual(PasswordTemplateExpected, PasswordTemplate);
            Assert.AreEqual(RevertExpected, Revert);
            Assert.AreEqual(WritePasswordDocumentExpected, WritePasswordDocument);
            Assert.AreEqual(WritePasswordTemplateExpected, WritePasswordTemplate);
            Assert.AreEqual(FormatExpected, Format);
            Assert.AreEqual(EncodingExpected, Encoding);
            Assert.AreEqual(VisibleExpected, Visible);
            Assert.AreEqual(OpenAndRepairExpected, OpenAndRepair);
            Assert.AreEqual(DocumentDirectionExpected, DocumentDirection);
            Assert.AreEqual(NoEncodingDialogExpected, NoEncodingDialog);
            Assert.AreEqual(XMLTransformExpected, XMLTransform);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
