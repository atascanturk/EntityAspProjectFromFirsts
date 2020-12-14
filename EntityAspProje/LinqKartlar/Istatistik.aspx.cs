using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.LinqKartlar
{
    public partial class Istatistik : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLURUNLER.Count().ToString();
            Label2.Text = db.TBLMUSTERI.Count().ToString();
            Label3.Text = db.TBLSATIS.Sum(x=>x.FIYAT).ToString();
            Label4.Text = db.TBLKATEGORI.Count().ToString();
            Label5.Text = db.TBLURUNLER.Count(x=> x.DURUM ==true).ToString();
            Label6.Text = db.TBLURUNLER.Count(x=> x.DURUM ==false).ToString();
            Label7.Text = (from x in db.TBLURUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();
           
            var enfkat = (from d1 in db.TBLURUNLER
                          join d2 in db.TBLKATEGORI
                          on d1.URUNID equals d2.KATEGORIID
                          group d1 by d2 into g
                          orderby g.Count() descending
                          select g.Key.KATEGORIAD).FirstOrDefault();
            Label8.Text = enfkat.ToString();

        }
    }
}