using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { 
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"].ToString());
            TxtID.Text = id.ToString();
            var p = db.TBLKATEGORI.Find(id);
            TxtAD.Text = p.KATEGORIAD;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"].ToString());
            var p = db.TBLKATEGORI.Find(id);
            p.KATEGORIAD = TxtAD.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}