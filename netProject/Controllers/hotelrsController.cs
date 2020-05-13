using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using netProject.Models;

namespace netProject.Controllers
{
    public class hotelrsController : Controller
    {
        private EjemploContext db = new EjemploContext();

        // GET: hotelrs
        public ActionResult Index()
        {
            return View(db.hotelrs.ToList());
        }

        // GET: hotelrs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hotelr hotelr = db.hotelrs.Find(id);
            if (hotelr == null)
            {
                return HttpNotFound();
            }
            return View(hotelr);
        }

        // GET: hotelrs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hotelrs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nombre,precio,categoria")] hotelr hotelr)
        {
            if (ModelState.IsValid)
            {
                db.hotelrs.Add(hotelr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hotelr);
        }

        // GET: hotelrs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hotelr hotelr = db.hotelrs.Find(id);
            if (hotelr == null)
            {
                return HttpNotFound();
            }
            return View(hotelr);
        }

        // POST: hotelrs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nombre,precio,categoria")] hotelr hotelr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hotelr).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hotelr);
        }

        // GET: hotelrs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hotelr hotelr = db.hotelrs.Find(id);
            if (hotelr == null)
            {
                return HttpNotFound();
            }
            return View(hotelr);
        }

        // POST: hotelrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hotelr hotelr = db.hotelrs.Find(id);
            db.hotelrs.Remove(hotelr);
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
