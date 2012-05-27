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
using mppl.Control;

namespace mppl
{
    public partial class FormTambah : System.Web.UI.Page
    {
        private PdfReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                try
                {
                    //tipe file yang dapat diupload adalah pdf,doc, dan docx
                    if (FileUploadControl.PostedFile.ContentType == "application/pdf" ||
                    FileUploadControl.PostedFile.ContentType == "application/msword" ||
                    FileUploadControl.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
                    {
                        //ukuran file maksimal adalah 4MB
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
            string pdfTextContent = "";
            //mengambil teks dalam pdf
            for (int i = 1; i <= reader.NumberOfPages; i++)
                pdfTextContent += PdfTextExtractor.GetTextFromPage(reader, i);
            //mengambil fingerprint dari file
            List<int> fingerPrint = Winnowing.getFingerprint(pdfTextContent);
            StatusLabel.Visible = true;
        }
    }
}