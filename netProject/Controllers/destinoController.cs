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
    public class destinoController : Controller
    {
        private destinoContext db = new destinoContext();

        // GET: destino
        public ActionResult Index()
        {
            return View(db.destinoes.ToList());
        }

        // GET: destino/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            destino destino = db.destinoes.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        // GET: destino/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: destino/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nombre,costo")] destino destino)
        {
            if (ModelState.IsValid)
            {
                db.destinoes.Add(destino);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(destino);
        }

        // GET: destino/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            destino destino = db.destinoes.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        // POST: destino/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nombre,costo")] destino destino)
        {
            if (ModelState.IsValid)
            {
                db.Entry(destino).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(destino);
        }

        // GET: destino/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            destino destino = db.destinoes.Find(id);
            if (destino == null)
            {
                return HttpNotFound();
            }
            return View(destino);
        }

        // POST: destino/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            destino destino = db.destinoes.Find(id);
            db.destinoes.Remove(destino);
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
