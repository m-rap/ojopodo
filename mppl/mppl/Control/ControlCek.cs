using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.IO;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace mppl.Control
{
    public class ControlCek
    {
        List<int> finger;
        String teks;
        public bool upload(FileUpload input,string path)
        {
                try
                {
                    if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf")
                    {
                        if (input.PostedFile.ContentLength < 4096000)
                        {
                            String filename = Path.GetFileName(input.FileName);
                            input.SaveAs(path);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("file gagal diupload karena : " + ex);
                    return false;
                }
        }
        void ekstrakPdf(string path)
        {
            PdfReader reader = new PdfReader(path);
            for (int i = 1; i <= reader.NumberOfPages; i++)
                teks += PdfTextExtractor.GetTextFromPage(reader, i);
        }
        void createFingerPrint(string input)
        {
            finger = Winnowing.getFingerprint(input);
        }
    }
}