using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Windows.Forms;
using mppl.Control;
namespace mppl.mppl
{
    public partial class formCekUI : System.Web.UI.Page
    {
        protected bool check;
        ControlCek controlC;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
            controlC = new ControlCek();
        }

        /*protected void rdo_modeUpload_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text = sender.ToString();
            if ( sender.Equals(rdo_modeTeks))
                Label1.Text = "radio uploaddipencet";
            else
                Label1.Text = "radio uploaddipencedast";
        }*/
        protected void upload(object sender, EventArgs e)
        {
            rdo_modeTeks.Checked = false;
            Label1.Text = "upload";
            Panel2.Visible = true;
            Panel1.Visible = false;
            check = true;
        }
        protected void teks(object sender, EventArgs e)
        {
            rdo_modeUpload.Checked = false;
            Label1.Text = "tekse";
            Panel1.Visible = true;
            Panel2.Visible = false;
            check = false;
        }
        protected void ganti(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedItem.Text == "File")
            {
                Panel2.Visible = true;
                Panel1.Visible = false;
                check = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
                check = false;
            }
        }
        protected void periksa(object sender, EventArgs e)
        {
            controlC.cek(upl_file);
            /*
                if (upl_file.HasFile)
                {
                    try
                    {
                        if (upl_file.PostedFile.ContentType == "application/msword" || upl_file.PostedFile.ContentType == "application/pdf")
                        {
                            if (upl_file.PostedFile.ContentLength < 4096000)
                            {
                                String filename = Path.GetFileName(upl_file.FileName);
                                upl_file.SaveAs(Server.MapPath("~/") + filename);
                                MessageBox.Show("upload file berhasil");
                            }
                            else
                            {
                                MessageBox.Show("File tidak boleh melebihi 4000 kb!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("File yang diperbolehkan hanya .doc dan .pdf");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("file gagal diupload karena : " + ex);
                    }
                }
            */
        }
    }
}