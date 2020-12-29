using emlak_sistemi.Models.DataContext;
using emlak_sistemi.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emlak_sistemi.Controllers
{
    public class musteriController : Controller
    {
        emlakDBContext db = new emlakDBContext();
        // GET: musteri
        public ActionResult Index()
        {
           var m = db.musteri.ToList();
            return View(m);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(musteri m)
        {
            if (ModelState.IsValid)
            {
                db.musteri.Add(m);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(m);
        }
        public ActionResult Edit(int id)
        {
            var m = db.musteri.Where(x => x.MusteriId == id).FirstOrDefault();
            return View(m);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, musteri m)
        {
            if (ModelState.IsValid)
            {
                var musteri = db.musteri.Where(x => x.MusteriId == id).FirstOrDefault();
                
                musteri.Ad = m.Ad;
                musteri.Soyad = m.Soyad;
                musteri.EvTelefonu = m.EvTelefonu;
                musteri.CepNo = m.CepNo;
                musteri.Mail = m.Mail;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(m);
        }


        public ActionResult Delete(int? id)
        {
            var m = db.musteri.Where(x => x.MusteriId == id).FirstOrDefault();

            return View(m);
        }

        // POST: Iletisim/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            musteri m = db.musteri.Find(id);
			db.musteri.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}