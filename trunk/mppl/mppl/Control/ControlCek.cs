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
using Microsoft.Office.Interop.Word;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace mppl.Control
{
    public class ControlCek
    {
        List<int> finger;
        String teks;
        HttpServerUtility server;
        
        public ControlCek()
        {
            finger = new List<int>();
        }

        public ControlCek(HttpServerUtility server)
        {
            finger = new List<int>();
            this.server = server;
        }

        public bool upload(FileUpload input, string judul, string pengarang, string url_dokumen)
        {
            if (cek(input) != null)
            {
                ModelDokumen dokumens = new ModelDokumen();
                //generate filepath
                MD5 md5 = MD5.Create();
                byte[] dataNamaFile = md5.ComputeHash(Encoding.UTF8.GetBytes(judul));
                StringBuilder sbNamaFile = new StringBuilder();
                for (int i = 0; i < dataNamaFile.Length; i++)
                {
                    sbNamaFile.Append(dataNamaFile[i].ToString("x2"));
                }
                string namafile = sbNamaFile.ToString();

                string fullpath = server.MapPath("~/fingerprint_dokumen/" + namafile);
                
                //proses menulis ke file mulai dari sini (buat San)
                //
                //*fullpath nya pake direktoriProject+direktoriUpload+namafile

                //ControlCek tulisCek = new ControlCek();
                //System.IO.File.WriteAllLines(/*@"direktoriProject"*/, tulisCek);
                //System.IO.File.WriteAllLines(/*@"fingerprint_dokumen"*/, tulisCek);

                if (!System.IO.File.Exists(@fullpath))
                {
                    System.IO.FileStream fs = System.IO.File.Create(@fullpath);
                    fs.Close();
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@fullpath, true))
                    {
                        for (int i = 0; i < finger.Count; i++)
                        {
                            sw.WriteLine(finger[i]);
                        }
                    }
                }
                //edited by rian

                //
                //berakhir di sini

                //insert dokumen ke database
                dokumens.insert(judul, pengarang, namafile, url_dokumen);
                return true;
            }
            return false;
        }

        public SortedDictionary<dokumen,double> cek(FileUpload input)
        {
            try
            {
                if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf")
                {
                    if (input.PostedFile.ContentLength < 4096000)
                    {
                        SortedDictionary<dokumen, double> hasil;//berisi dokumen dokumen yang mirip
                        hasil = new SortedDictionary<dokumen, double>();
                        // String filename = Path.GetFileName(input.FileName);
                        Stream coba = input.FileContent;
                        if (input.PostedFile.ContentType == "application/pdf")
                            ekstrakPdf(coba);
                        finger = Winnowing.getFingerprint(teks);
                        finger.Sort();
                        //queri fingerprint dari db
                        ModelDokumen dokumens = new ModelDokumen();
                        List<dokumen> db = dokumens.get().ToList<dokumen>();
                        //panggil fungsi cekKemiripan dengan parameter list fingerprint dari file yang diupload sama yang didb
                        foreach (var i in db)
                        {
                            string[] read = File.ReadAllLines(server.MapPath("~/fingerprint_dokumen/" + i.alamat_fingerprint));
                            List<int> fingerprintdb = Array.ConvertAll<string, int>(read, new Converter<string, int>(Convert.ToInt32)).ToList<int>();
                            var result = cekKemiripan(finger, fingerprintdb);
                            if (result > 0.5)
                            {
                                //hasil fungsi masukan ke list
                                hasil[i] = result;
                            }
                        }

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
                Console.WriteLine("file gagal diupload karena : " + ex);
                return null;
            }
        }
        
        void ekstrakPdf(Stream path)
        {
            PdfReader reader = new PdfReader(path);
            for (int i = 1; i <= reader.NumberOfPages; i++)
                teks += PdfTextExtractor.GetTextFromPage(reader, i);
        }
        void ekstrakDoc(string filepath)
        {
            try
            {
                object fileName = filepath;

                Microsoft.Office.Interop.Word.Application appClass = new Microsoft.Office.Interop.Word.Application();
                object missing = System.Reflection.Missing.Value;
                object visible = true;
                object readOnly = false;

                Microsoft.Office.Interop.Word.Document wordDoc = appClass.Documents.Open(ref fileName, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    visible, ref missing, ref missing, ref missing, ref missing);

                teks = wordDoc.Content.Text;

                appClass.Application.Quit(ref missing, ref missing, ref missing);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ekstrak word gagal karena : " + ex);
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