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
using mppl.Entitas;

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
                            Dictionary<dokumen,double> hasil;//berisi dokumen dokumen yang mirip
                            hasil = new Dictionary<dokumen, double>();
                           // String filename = Path.GetFileName(input.FileName);
                            Stream coba = input.FileContent;
                            if(input.PostedFile.ContentType=="application/pdf")
                                ekstrakPdf(coba);
                            finger = Winnowing.getFingerprint(teks);
                            finger.Sort();
                            //queri fingerprint dari db
                            ModelDokumen dokumens = new ModelDokumen();
                            List<dokumen> db = dokumens.get().ToList<dokumen>();
                            //panggil fungsi cekKemiripan dengan parameter list fingerprint dari file yang diupload sama yang didb
                            foreach (var i in db)
                            {
                                string[] read = File.ReadAllLines(i.alamat_fingerprint);
                                List<int> fingerprintdb = Array.ConvertAll<string,int>(read,new Converter<string,int>(Convert.ToInt32)).ToList<int>();
                                var result = cekKemiripan(finger, fingerprintdb);
                                if ( result > 0.5)
                                {
                                    //hasil fungsi masukan ke list
                                    hasil[i] = result;
                                }
                            }
                            //sorting list trus kembalikan List tersebut sebagai return value
                            
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
        //cek kemiriman antar 2 dokumen
        double cekKemiripan(List<int> input, List<int> db)
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
                    if (j > i)
                        break;
                }
            }
            return counterIntersect / input.Count;
        }
    }
}