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
        public ControlCek()
        {
            finger = new List<int>();
        }
        public bool upload(FileUpload input)
        {
                try
                {
                    if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf")
                    {
                        if (input.PostedFile.ContentLength < 4096000)
                        {
                           // String filename = Path.GetFileName(input.FileName);
                            Stream coba = input.FileContent;
                            if(input.PostedFile.ContentType=="application/pdf")
                                ekstrakPdf(coba);
                            finger = Winnowing.getFingerprint(teks);
                            finger.Sort();
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
        void ekstrakPdf(Stream path)
        {
            PdfReader reader = new PdfReader(path);
            for (int i = 1; i <= reader.NumberOfPages; i++)
                teks += PdfTextExtractor.GetTextFromPage(reader, i);
        }
        void createFingerPrint(string input)
        {
            finger = Winnowing.getFingerprint(input);
        }
        //menghitung koefisien jaccard (similaritas antar fingerprint)
        double cekJaccard(List<int> input, List<int> db)
        {
            double counterIntersect = 0; 
            //int counterUnion = 0;
            foreach (var i in input)
            {
                foreach (var j in db)
                {
                    if (i == j)
                    {
                        counterIntersect++;
                        break;
                    }
                    else if (i > j)
                    {
                        break;
                    }
                }
            }
            return counterIntersect/(double)input.Count;
        }
    }
}