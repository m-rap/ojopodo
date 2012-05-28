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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadClick(object sender, EventArgs e)
        {
            ControlCek myControlCek = new ControlCek();
            if (FileUploadControl.HasFile)
            {

                if (myControlCek.upload(FileUploadControl))
                {
                    StatusLabel.Text = "Upload Sukses";
                }
                else
                    StatusLabel.Text = "Upload gagal";
                StatusLabel.Visible = true;
            }
        }
    }
}