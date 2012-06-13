using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mppl.Entitas;

namespace mppl
{
    public partial class FormEditDokumen : System.Web.UI.Page
    {
        long id;
        dokumen dok;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sandi"] != "admin")
            {
                Response.Redirect("~/LoginAdmin.aspx");
            }

            id = long.Parse(Request.QueryString["id"]);
            ModelDokumen model = new ModelDokumen();
            dok = model.getById(id);
            if (!Page.IsPostBack)
            {
                TextBox_Judul.Text = dok.judul;
                TextBox_Pengarang.Text = dok.pengarang;
                TextBox_UrlDokumen.Text = dok.url_dokumen;
            }

            UpdateBtn.Attributes.Add("onclick", "return window.confirm('Anda yakin akan merubah data?');");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            ModelDokumen model = new ModelDokumen();
            model.update(id, TextBox_Judul.Text, TextBox_Pengarang.Text, TextBox_UrlDokumen.Text);
            Response.Redirect("~/LihatDokumen.aspx");
        }


    }
}