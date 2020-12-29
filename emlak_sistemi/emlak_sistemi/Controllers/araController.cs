using emlak_sistemi.Models.DataContext;
using emlak_sistemi.Models.Model;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emlak_sistemi.Controllers
{
    public class araController : Controller
    {
        emlakDBContext db = new emlakDBContext();

        // GET: ara
        public ActionResult Index(string p ,string c,int? say,int? m, int? k)
        {
           
            var degerler = from d in db.evbilgi select d;
           
            if (!string.IsNullOrEmpty(c))
            {
                degerler = degerler.Where(x => x.Tur.Contains(c));
            }
            if (!string.IsNullOrEmpty(p))
			{
               


                degerler = degerler.Where(x => x.IsiTuru.Contains(p));
			}
           if (say!=null)
          {
                
             
                
               degerler = degerler.Where(x => x.OdaSayisi == say);
          }

			if (m != null)
            {
                degerler = degerler.Where(x => x.MetreKare == m); 
            }
            if (k != null)
            {
                degerler = degerler.Where(x => x.Kat == k);
            }

            //  var bil = db.evbilgi.ToList();
            return View(degerler);
        }
       
    }
}