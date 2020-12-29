using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using emlak_sistemi.Models.DataContext;
using emlak_sistemi.Models.Model;

namespace emlak_sistemi.Controllers
{
    public class evbilgiController : Controller
    {
        private emlakDBContext db = new emlakDBContext();

        // GET: evbilgi
        public ActionResult Index()
        {
            return View(db.evbilgi.ToList());
        }

        // GET: evbilgi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            evbilgi evbilgi = db.evbilgi.Find(id);
            if (evbilgi == null)
            {
                return HttpNotFound();
            }
            return View(evbilgi);
        }

        // GET: evbilgi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: evbilgi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "EvId,Tur,MetreKare,OdaSayisi,Foto1,Foto2,Foto3,Kat,IsiTuru,Aciklama,Ad,Soyad,Telefon")] evbilgi evbilgi)
        {
            if (ModelState.IsValid)
            {
                db.evbilgi.Add(evbilgi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evbilgi);
        }

        // GET: evbilgi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            evbilgi evbilgi = db.evbilgi.Find(id);
            if (evbilgi == null)
            {
                return HttpNotFound();
            }
            return View(evbilgi);
        }

        // POST: evbilgi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "EvId,Tur,MetreKare,OdaSayisi,Foto1,Foto2,Foto3,Kat,IsiTuru,Aciklama,Ad,Soyad,Telefon")] evbilgi evbilgi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evbilgi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evbilgi);
        }

        // GET: evbilgi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            evbilgi evbilgi = db.evbilgi.Find(id);
            if (evbilgi == null)
            {
                return HttpNotFound();
            }
            return View(evbilgi);
        }

        // POST: evbilgi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            evbilgi evbilgi = db.evbilgi.Find(id);
            db.evbilgi.Remove(evbilgi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
