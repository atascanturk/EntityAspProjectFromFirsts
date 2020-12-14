using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.TBLURUNLER.Where(x => x.DURUM == true).ToList();
            var urunler1 = (from x in db.TBLURUNLER select new { x.URUNID, x.URUNAD, x.URUNMARKA, x.TBLKATEGORI.KATEGORIAD, x.URUNFIYAT, x.URUNSTOK,x.DURUM }).Where(t => t.DURUM == true).ToList();
            Repeater1.DataSource = urunler1;
            Repeater1.DataBind();
        }
    }
}