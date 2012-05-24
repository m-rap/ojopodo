using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mppl.Entitas;

namespace mppl
{
    public partial class FormDokumen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ModelDokumen modelDokumen = new ModelDokumen();
            GridView_Dokumen.DataSource = modelDokumen.get();
            GridView_Dokumen.DataBind();
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            ModelDokumen modelDokumen = new ModelDokumen();
            modelDokumen.insert(TextBox_Judul.Text, TextBox_Pengarang.Text, TextBox_AlamatFingerprint.Text);
            Response.Redirect(Request.RawUrl); 
        }
    }
}