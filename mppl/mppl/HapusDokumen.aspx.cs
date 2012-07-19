using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mppl.Entitas;

namespace mppl
{
    public partial class HapusDokumen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sandi"] != "admin")
            {
                Response.Redirect("~/LoginAdmin.aspx");
            }

            long id = long.Parse(Request.QueryString["id"]);
            ModelDokumen modeldokumen = new ModelDokumen();
            dokumen dok = modeldokumen.getById(id);
            Label_id.Text = id.ToString();
            Label_judul.Text = dok.judul;
            Label_pengarang.Text = dok.pengarang;
            Label_urlDokumen.Text = dok.url_dokumen;
            Label_alamat_fingerprint.Text = dok.alamat_fingerprint;
            Btn_ya.Attributes.Add("onclick", "return window.confirm('Anda yakin dengan pilihan Anda?');");
        }

        protected void Btn_ya_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/fingerprint_dokumen/" + Label_alamat_fingerprint.Text);
            if (System.IO.File.Exists(@path))
            {
                System.IO.File.Delete(@path);
            }
            ModelDokumen modeldokumen = new ModelDokumen();
            modeldokumen.delete(long.Parse(Label_id.Text));
            Response.Redirect("~/LihatDokumen.aspx");
        }

        protected void Btn_tidak_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LihatDokumen.aspx");
        }
    }
}