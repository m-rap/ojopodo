using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Windows.Forms;
using mppl.Control;
using mppl.Entitas;
using System.Threading;
namespace mppl.mppl
{
    public partial class formCekUI : System.Web.UI.Page
    {
        protected bool check;
        ControlCek controlC;
        Dictionary<dokumen, double> sd;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel1.Visible = true;
            controlC = new ControlCek(Server);
            sd = new Dictionary<dokumen, double>();
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
            //rdo_modeTeks.Checked = false;
            //Label1.Text = "upload";
            Panel2.Visible = true;
            Panel1.Visible = false;
            check = true;
        }
        protected void periksa(object sender, EventArgs e)
        {
            judulText.Text = txt_judulDokumen.Text;
            try
            {
                //melakukan pengecekan dokumen yang dimasukkan
                sd = controlC.cek(upl_file,double.Parse(temp.Text)/100.0);
                if (sd == null)
                {
                    Response.Write("<script>alert(\"Dokumen yang Anda masukkan salah atau terlalu besar(kami hanya menerima file .pdf dan .doc dan berukuran tidak lebih dari 4MB)\");</script>");
                }
                else if (sd.Count == 0)
                    labelNotFound.Visible = true;
                else
                {
                    thread();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(\"" + ex.Message + "\")</script>");
                labelNotFound.Visible = true;
            }
            //progres_ModalPopup.Hide();
            if(sd!=null) progres_ModalPopup.Show();
        }

        protected void next_Click(object sender, EventArgs e)
        {                                                                          
        }                                                                          
        void showpopup()                                                           
        {                                                                          
            progres_ModalPopup.Show();
        }
        public void thread()
        {
            //menampilkan hasil dalam grid view dan terurut secara descending
            BindingSource binding = new BindingSource();
            Dictionary<dokumen, double> temp = new Dictionary<dokumen, double>();
            temp = sd.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            
            foreach(var checking in temp){
                binding.Add(new Hasil(checking.Key.judul,checking.Key.url_dokumen,checking.Value*100));
            }
            grv_hasil.DataSource = binding;
            grv_hasil.DataBind();
        }

        public void controlC_passedOne(object sender) 
        {
            //StatusLabel.Text = controlC.count.ToString();
        }
    }
}