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
using System.Text;
using Bytescout.Document;
using mppl.Entitas;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using mppl.mppl;

namespace mppl.Control
{
    public class ControlCek
    {
        List<int> finger;
        String teks;
        HttpServerUtility server;
        private int _count;
        public int count
        {
            get
            {
                return _count;
            }
        }

        public delegate void EachDokumenChecked(object sender);
        public event EachDokumenChecked passedOne;
        
        public ControlCek()
        {
            finger = new List<int>();
            teks = "";
        }

        public ControlCek(HttpServerUtility server)
        {
            finger = new List<int>();
            this.server = server;
        }

        public bool upload(FileUpload input, string judul, string pengarang, string url_dokumen)
        {
            try
            {
                if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf")
                {
                    if (input.PostedFile.ContentLength < 10240000)
                    {
                        Stream coba = input.FileContent;
                        if (input.PostedFile.ContentType == "application/pdf")
                            ekstrakPdf(coba);
                        else
                            ekstrakDoc(coba);
                        finger = Winnowing.getFingerprint(teks);
                        finger.Sort();

                        ModelDokumen dokumens = new ModelDokumen();
                        //generate filepath
                        string fullpath, namafile;
                        do
                        {
                            MD5 md5 = MD5.Create();
                            byte[] dataNamaFile = md5.ComputeHash(Encoding.UTF8.GetBytes(judul));
                            StringBuilder sbNamaFile = new StringBuilder();
                            for (int i = 0; i < dataNamaFile.Length; i++)
                            {
                                sbNamaFile.Append(dataNamaFile[i].ToString("x2"));
                            }
                            namafile = sbNamaFile.ToString();

                            fullpath = server.MapPath("~/fingerprint_dokumen/" + namafile);
                        } while (System.IO.File.Exists(@fullpath));

                        //proses menulis ke file mulai dari sini (buat San)
                        //
                        //*fullpath nya pake direktoriProject+direktoriUpload+namafile

                        //ControlCek tulisCek = new ControlCek();
                        //System.IO.File.WriteAllLines(/*@"direktoriProject"*/, tulisCek);
                        //System.IO.File.WriteAllLines(/*@"fingerprint_dokumen"*/, tulisCek);
                        System.IO.FileStream fs = System.IO.File.Create(@fullpath);
                        fs.Close();
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@fullpath, true))
                        {
                            for (int i = 0; i < finger.Count; i++)
                            {
                                sw.WriteLine(finger[i]);
                            }
                        }
                        //edited by rian

                        //
                        //berakhir di sini

                        //insert dokumen ke database
                        dokumens.insert(judul, pengarang, namafile, url_dokumen);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("file gagal diupload karena : " + ex);
                return false;
            }
            return false;
        }

        public SortedDictionary<dokumen,double> cek(FileUpload input,double threshold)
        {
            try
            {
                if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf")
                {
                    if (input.PostedFile.ContentLength < 10240000)
                    {
                        SortedDictionary<dokumen, double> hasil;//berisi dokumen dokumen yang mirip
                        hasil = new SortedDictionary<dokumen, double>();
                        // String filename = Path.GetFileName(input.FileName);
                        Stream coba = input.FileContent;
                        if (input.PostedFile.ContentType == "application/pdf")
                            ekstrakPdf(coba);
                        else
                            ekstrakDoc(coba);
                       
                        teks = teks.Trim();
                        finger = Winnowing.getFingerprint(teks);
                        finger.Sort();
                        ModelDokumen dokumens = new ModelDokumen();
                        List<dokumen> db = dokumens.get().ToList<dokumen>();
                        //panggil fungsi cekKemiripan dengan parameter list fingerprint dari file yang diupload sama yang didb
                        _count = 0;
                        foreach (var i in db)
                        {
                            string[] read = File.ReadAllLines(server.MapPath("~/fingerprint_dokumen/" + i.alamat_fingerprint));
                            List<int> fingerprintdb = Array.ConvertAll<string, int>(read, new Converter<string, int>(Convert.ToInt32)).ToList<int>();
                            var result = cekKemiripan(finger, fingerprintdb);
                            if (result > threshold)
                            {
                                //hasil fungsi masukan ke list
                                hasil[i] = result;
                            }
                            _count++;
                            //passedOne(this);
                        }
                         
                       // var result = cekKemiripan(finger, finger2);
                        //sorting list trus kembalikan List tersebut sebagai return value
                        
                        return hasil;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
               // Console.WriteLine("file gagal diupload karena : " + ex);
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
        
        void ekstrakPdf(Stream path)
        {
            PdfReader reader = new PdfReader(path);
            for (int i = 1; i <= reader.NumberOfPages; i++)
                teks += PdfTextExtractor.GetTextFromPage(reader, i);
        }
        void ekstrakDoc(Stream path)
        {
            using (Bytescout.Document.Document doc = new Bytescout.Document.Document())
            {
                doc.Open(path);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < doc.ParagraphCount; i++)
                {
                    Bytescout.Document.Paragraph p = doc.GetParagraph(i);
                    if (p != null)
                    {
                        sb.Append(p.ToString());
                        sb.AppendLine();
                    }
                }

                teks = sb.ToString();
            }
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