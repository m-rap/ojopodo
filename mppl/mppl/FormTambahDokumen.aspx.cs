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
            if (Session["sandi"] != "admin")
            {
                Response.Redirect("~/LoginAdmin.aspx");
            }
        }

        protected void UploadClick(object sender, EventArgs e)
        {
            ControlCek myControlCek = new ControlCek(Server);
            if (FileUploadControl.HasFile)
            {
                try
                {
                    myControlCek.upload(FileUploadControl, TextBox_Judul.Text, TextBox_Pengarang.Text, TextBox_UrlDokumen.Text);
                    StatusLabel.Text = "Upload Sukses";
                    if (!Page.IsPostBack)
                    {
                        TextBox_Judul.Text = "";
                        TextBox_Pengarang.Text = "";
                        TextBox_UrlDokumen.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = ex.Message;
                }
                StatusLabel.Visible = true;
            }
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            
        }
    }
}