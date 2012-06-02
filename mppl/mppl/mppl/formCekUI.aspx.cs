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
           
        }
    }
}