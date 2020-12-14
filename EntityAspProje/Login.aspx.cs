using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Log : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = (from x in db.TBL_ADMIN where (x.KULLANICI == TxtUser.Text && x.SİFRE == TxtSifre.Text) select x);
            if (sorgu.Any())
            {
                Response.Redirect("Kategoriler.aspx");
            }
            else
            {
                Response.Write("Hatalı Bilgi Girişi");
            }
        }
    }
}