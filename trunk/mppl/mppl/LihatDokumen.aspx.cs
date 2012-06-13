using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mppl.Entitas;
using System.Data;

namespace mppl
{
    public partial class FormDokumen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["sandi"] != "admin")
            {
                Response.Redirect("~/LoginAdmin.aspx");
            }
            

            ModelDokumen modelDokumen = new ModelDokumen();
            DataTable tabeldokumen = new DataTable();
            IEnumerable<dokumen> dok = modelDokumen.get();

            tabeldokumen.Columns.Add(new DataColumn("ID Dokumen"));
            tabeldokumen.Columns.Add(new DataColumn("Judul Dokumen"));
            tabeldokumen.Columns.Add(new DataColumn("Pengarang"));
            tabeldokumen.Columns.Add(new DataColumn("URL Asal Dokumen"));
            tabeldokumen.Columns.Add(new DataColumn("Alamat File Fingerprint"));

            foreach (dokumen d in dok)
            {
                DataRow r = tabeldokumen.NewRow();
                r["ID Dokumen"] = d.id_dokumen;
                r["Judul Dokumen"] = d.judul;
                r["Pengarang"] = d.pengarang;
                r["URL Asal Dokumen"] = d.url_dokumen;
                r["Alamat File Fingerprint"] = d.alamat_fingerprint;
                tabeldokumen.Rows.Add(r);
            }
            GridView_Dokumen.DataSource = tabeldokumen;
            GridView_Dokumen.DataBind();
        }

        protected void GridView_Dokumen_RowDataBound(Object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HyperLink editlink = (HyperLink)e.Row.FindControl("link_edit");
                HyperLink deletelink = (HyperLink)e.Row.FindControl("link_hapus");
                DataRowView row = (DataRowView)e.Row.DataItem;
                editlink.NavigateUrl = "FormEditDokumen.aspx?id=" + row["ID Dokumen"];
                deletelink.NavigateUrl = "#";//"HapusDokumen.aspx?id=" + row["ID Dokumen"];
            }
        }

        protected void GridView_Dokumen_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_Dokumen.PageIndex = e.NewPageIndex;
            GridView_Dokumen.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["sandi"] = "";
            Response.Redirect("Default.aspx");
        }
    }
}