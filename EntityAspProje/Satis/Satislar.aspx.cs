using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satis
{ 
    public partial class Satislar : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var satislar = (from x in db.TBLSATIS select new { x.SATISID, x.TBLURUNLER.URUNAD, x.TBLPERSONEL.PERSONELADSOYAD, MUSTERI = (x.TBLMUSTERI.MUSTERIAD +" "+ x.TBLMUSTERI.MUSTERISOYAD), x.FIYAT }).ToList();
            //var satislar = db.TBLSATIS.ToList();
            Repeater1.DataSource = satislar;
            Repeater1.DataBind();
        }
    }
}