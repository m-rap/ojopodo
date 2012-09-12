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
//using Bytescout.Document;
using mppl.Entitas;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.Xml;

namespace mppl.Control
{
    public class ControlCek
    {
        List<int> finger;
        String teks;
        HttpServerUtility server;
        private const string ContentTypeNamespace =
        @"http://schemas.openxmlformats.org/package/2006/content-types";

        private const string WordprocessingMlNamespace =
            @"http://schemas.openxmlformats.org/wordprocessingml/2006/main";

        private const string DocumentXmlXPath =
            "/t:Types/t:Override[@ContentType=\"" +
            "application/vnd.openxmlformats-officedocument." +
            "wordprocessingml.document.main+xml\"]";

        private const string BodyXPath = "/w:document/w:body";

        private Stream docxFile;
        private string docxFileLocation = "";
        
        public ControlCek()
        {
            finger = new List<int>();
        }

        public ControlCek(HttpServerUtility server)
        {
            finger = new List<int>();
            this.server = server;
        }

        public void upload(FileUpload input, string judul, string pengarang, string url_dokumen)
        {
            try
            {
                if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf" || input.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
                {
                    if (input.PostedFile.ContentLength < 10240000)
                    {
                        Stream coba = input.FileContent;
                        if (input.PostedFile.ContentType == "application/pdf")
                            ekstrakPdf(coba);
                        else if (input.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
                            ekstrakDocx(coba);
                        else
                            ekstrakDoc(coba);
                        finger = Winnowing.getFingerprint(teks);
                        finger.Sort();

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
                    }
                    else
                    {
                        throw new ArgumentException("File terlalu besar.");
                    }
                }
                else
                {
                    throw new ArgumentException("Format file tidak didukung.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<dokumen,double> cek(FileUpload input,double treshold)
        {
            try
            {
                if (input.PostedFile.ContentType == "application/msword" || input.PostedFile.ContentType == "application/pdf" || input.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" )
                {
                    if (input.PostedFile.ContentLength < 4096000)
                    {
                        Dictionary<dokumen, double> hasil;//berisi dokumen dokumen yang mirip
                        hasil = new Dictionary<dokumen, double>();
                        // String filename = Path.GetFileName(input.FileName);
                        Stream coba = input.FileContent;
                        if (input.PostedFile.ContentType == "application/pdf")
                            ekstrakPdf(coba);
                        else if (input.PostedFile.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document")
                            ekstrakDocx(coba);
                        else
                            ekstrakDoc(coba);
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
                            double result;
                            if (finger.Count > fingerprintdb.Count)
                                result = cekKemiripan(fingerprintdb, finger);
                            else
                                result = cekKemiripan(finger, fingerprintdb);
                            if (result > treshold)
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
                        throw new ArgumentException("File terlalu besar.");
                    }
                }
                else
                {
                    throw new ArgumentException("Format file tidak didukung.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        void ekstrakPdf(Stream path)
        {
            PdfReader reader = new PdfReader(path);
            for (int i = 1; i <= reader.NumberOfPages; i++)
                teks += PdfTextExtractor.GetTextFromPage(reader, i);
        }
        void ekstrakDocx(Stream path)
        {
            docxFile = path;
            //if (string.IsNullOrEmpty(docxFile))
            //    throw new Exception("Input file not specified.");

            // Usually it is "/word/document.xml"

            docxFileLocation = FindDocumentXmlLocation();

            if (string.IsNullOrEmpty(docxFileLocation))
                throw new Exception("It is not a valid Docx file.");

            teks = ReadDocumentXml();
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
        #region FindDocumentXmlLocation()
        /// 
        /// Gets location of the "document.xml" zip entry.
        /// 
        /// Location of the "document.xml".
        private string FindDocumentXmlLocation()
        {
            ZipFile zip = new  ZipFile(docxFile);
            foreach (ZipEntry entry in zip)
            {
                // Find "[Content_Types].xml" zip entry

                if (string.Compare(entry.Name, "[Content_Types].xml", true) == 0)
                {
                    Stream contentTypes = zip.GetInputStream(entry);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.PreserveWhitespace = true;
                    xmlDoc.Load(contentTypes);
                    contentTypes.Close();

                    //Create an XmlNamespaceManager for resolving namespaces

                    XmlNamespaceManager nsmgr =
                        new XmlNamespaceManager(xmlDoc.NameTable);
                    nsmgr.AddNamespace("t", ContentTypeNamespace);

                    // Find location of "document.xml"

                    XmlNode node = xmlDoc.DocumentElement.SelectSingleNode(
                        DocumentXmlXPath, nsmgr);

                    if (node != null)
                    {
                        string location =
                            ((XmlElement)node).GetAttribute("PartName");
                        return location.TrimStart(new char[] { '/' });
                    }
                    break;
                }
            }
            zip.Close();
            return null;
        }
        #endregion

        #region ReadDocumentXml()
        /// 
        /// Reads "document.xml" zip entry.
        /// 
        /// Text containing in the document.
        private string ReadDocumentXml()
        {
            StringBuilder sb = new StringBuilder();

            ZipFile zip = new ZipFile(docxFile);
            foreach (ZipEntry entry in zip)
            {
                if (string.Compare(entry.Name, docxFileLocation, true) == 0)
                {
                    Stream documentXml = zip.GetInputStream(entry);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.PreserveWhitespace = true;
                    xmlDoc.Load(documentXml);
                    documentXml.Close();

                    XmlNamespaceManager nsmgr =
                        new XmlNamespaceManager(xmlDoc.NameTable);
                    nsmgr.AddNamespace("w", WordprocessingMlNamespace);

                    XmlNode node =
                        xmlDoc.DocumentElement.SelectSingleNode(BodyXPath, nsmgr);

                    if (node == null)
                        return string.Empty;

                    sb.Append(ReadNode(node));

                    break;
                }
            }
            zip.Close();
            return sb.ToString();
        }
        #endregion

        #region ReadNode()
        /// 
        /// Reads content of the node and its nested childs.
        /// 
        /// XmlNode.
        /// Text containing in the node.
        private string ReadNode(XmlNode node)
        {
            if (node == null || node.NodeType != XmlNodeType.Element)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.NodeType != XmlNodeType.Element) continue;

                switch (child.LocalName)
                {
                    case "t":                           // Text
                        sb.Append(child.InnerText.TrimEnd());

                        string space =
                            ((XmlElement)child).GetAttribute("xml:space");
                        if (!string.IsNullOrEmpty(space) &&
                            space == "preserve")
                            sb.Append(' ');

                        break;

                    case "cr":                          // Carriage return
                    case "br":                          // Page break
                        sb.Append(Environment.NewLine);
                        break;

                    case "tab":                         // Tab
                        sb.Append("\t");
                        break;

                    case "p":                           // Paragraph
                        sb.Append(ReadNode(child));
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        break;

                    default:
                        sb.Append(ReadNode(child));
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion
    }
}