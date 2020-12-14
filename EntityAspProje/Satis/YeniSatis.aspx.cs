using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{
    
    public partial class YeniSatis : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var urunler = (from x in db.TBLURUNLER select new { x.URUNAD, x.URUNID, x.DURUM }).Where(p => p.DURUM == true).ToList();
                var ktgr = (from y in db.TBLKATEGORI select new { y.KATEGORIAD, y.KATEGORIID }).ToList();
                var musteri = (from z in db.TBLMUSTERI select new { Musteri = (z.MUSTERIAD + " " + z.MUSTERISOYAD), z.MUSTERIID }).ToList();
                var personel = (from x in db.TBLPERSONEL select new { x.PERSONELADSOYAD, x.PERSONELID }).ToList(); ;
                DrpUrun.DataTextField = "URUNAD";
                DrpUrun.DataValueField = "URUNID";
                DrpUrun.DataSource = urunler;
                DrpUrun.DataBind();

                DrpMusteri.DataTextField = "Musteri";
                DrpMusteri.DataValueField = "MUSTERIID";
                DrpMusteri.DataSource = musteri;
                DrpMusteri.DataBind();

                DrpPersonel.DataTextField = "PERSONELADSOYAD";
                DrpPersonel.DataValueField = "PERSONELID";
                DrpPersonel.DataSource = personel;
                DrpPersonel.DataBind();
            }
           
        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            TBLSATIS t = new TBLSATIS();
            t.MUSTERI = int.Parse(DrpMusteri.SelectedValue);
            t.PERSONEL = int.Parse(DrpPersonel.SelectedValue);
            t.URUN = int.Parse(DrpUrun.SelectedValue);
            t.FIYAT = Convert.ToDecimal(TxtFiyat.Text);

            db.TBLSATIS.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.aspx");
        }
    }
}