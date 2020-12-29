using emlak_sistemi.Models.DataContext;
using emlak_sistemi.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace emlak_sistemi.Controllers
{
    public class isyeriController : Controller
    {
        emlakDBContext db = new emlakDBContext();
        // GET: isyeri
        public ActionResult Index()
        {
            var i = db.isyeri.ToList();
            return View(i);
        }
        public ActionResult Create()
        {
            return View();
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(isyeri i)
        {
           if (ModelState.IsValid)
			{
               db.isyeri.Add(i);
               db.SaveChanges();
               return RedirectToAction("Index");
            }

                return View(i);
        }
        public ActionResult Edit(int id)
		{
            var i = db.isyeri.Where(x =>x.IsyeriId == id).FirstOrDefault();
            return View(i);
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,isyeri i)
		{
            if(ModelState.IsValid)
			{
                var isyeri = db.isyeri.Where(x => x.IsyeriId == id).FirstOrDefault();

                isyeri.IsletmeAdi = i.IsletmeAdi;
                isyeri.Yetkili = i.Yetkili;
                isyeri.Adres = i.Adres;
                isyeri.Telefon = i.Telefon;
                isyeri.Fax = i.Fax;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(i);
		}
        public ActionResult Delete(int? id)
        {
            var i = db.isyeri.Where(x => x.IsyeriId == id).FirstOrDefault();

            return View(i);
        }

        // POST: Iletisim/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            isyeri i = db.isyeri.Find(id);
            db.isyeri.Remove(i);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}