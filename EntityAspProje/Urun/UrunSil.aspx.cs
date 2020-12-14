using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"].ToString());
            var p = db.TBLURUNLER.Find(id);
            p.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}