using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private PdfReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                try
                {
                    if (FileUploadControl.PostedFile.ContentType == "application/pdf" ||
                    FileUploadControl.PostedFile.ContentType == "application/msword" ||
                    FileUploadControl.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
                    {
                        if (FileUploadControl.PostedFile.ContentLength < 4096000)
                        {
                            string filename = Path.GetFileName(FileUploadControl.FileName);
                            FileUploadControl.SaveAs(Server.MapPath("~/") + filename);
                            reader = new PdfReader(Server.MapPath("~/") + filename);
                            StatusLabel.Text = "Upload status: File uploaded!";
                        }
                        else
                            StatusLabel.Text = "Upload status: The file has to be less than 4000 kb!";
                    }
                    else
                        StatusLabel.Text = "Upload status: Only PDF files are accepted!";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
            string pdfcontent="";
            for (int i = 1; i <= reader.NumberOfPages; i++)
                pdfcontent += PdfTextExtractor.GetTextFromPage(reader, i);
            List<int> finger = Winnowing.getFingerprint(pdfcontent);
        }
    }
}