using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class YeniUrun : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { 
            var ktgr = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
            DrpKategori.DataTextField = "KATEGORIAD";
            DrpKategori.DataValueField = "KATEGORIID";
            DrpKategori.DataSource = ktgr;
            DrpKategori.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLURUNLER t = new TBLURUNLER();
            t.URUNAD = TxtUrunAd.Text;
            t.URUNMARKA = TxtMarka.Text;
            t.URUNFIYAT = Convert.ToDecimal(TxtFiyat.Text);
            t.URUNSTOK = short.Parse(TxtStok.Text);
            t.URUNKATEGORI = byte.Parse(DrpKategori.SelectedValue);
            
            db.TBLURUNLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}