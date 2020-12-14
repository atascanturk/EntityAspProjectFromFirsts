using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["URUNID"].ToString());
                
                var p = db.TBLURUNLER.Find(id);
                TxtUrunAd.Text = p.URUNAD;
                TxtMarka.Text = p.URUNMARKA;
                TxtStok.Text = (p.URUNSTOK).ToString();
                TxtFiyat.Text = (p.URUNFIYAT).ToString();
                var ktgr = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DrpKategori.DataTextField = "KATEGORIAD";
                DrpKategori.DataValueField = "KATEGORIID";
                DrpKategori.DataSource = ktgr;
                DrpKategori.DataBind();
                DrpKategori.SelectedValue = p.URUNKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"].ToString());
            var p = db.TBLURUNLER.Find(id);
            p.URUNAD = TxtUrunAd.Text;
            p.URUNFIYAT = Convert.ToDecimal(TxtFiyat.Text);
            p.URUNMARKA = TxtMarka.Text;
            p.URUNKATEGORI = byte.Parse(DrpKategori.SelectedValue);
            p.URUNSTOK = short.Parse(TxtStok.Text);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");

        }
    }
}