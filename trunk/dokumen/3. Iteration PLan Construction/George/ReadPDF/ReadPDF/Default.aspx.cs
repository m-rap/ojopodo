using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ReadPDF
{
    public partial class _Default : System.Web.UI.Page
    {
        PdfReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PdfReader reader = new PdfReader("D:/KuliaH/semester 6/Mobil/Nokia 700.pdf");
            for(int i=1;i<=reader.NumberOfPages;i++)
              TextBox1.Text += PdfTextExtractor.GetTextFromPage(reader,i);
        }

    }
}
