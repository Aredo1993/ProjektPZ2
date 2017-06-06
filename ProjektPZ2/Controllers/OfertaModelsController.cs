using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjektPZ2.DAL;
using ProjektPZ2.Models;

namespace ProjektPZ2.Controllers
{
    public class OfertaModelsController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: OfertaModels
        public ActionResult Index()
        {
            var oferty = db.Oferty.Include(o => o.PrzetargModels);
            return View(oferty.ToList());
        }

        // GET: OfertaModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaModels ofertaModels = db.Oferty.Find(id);
            if (ofertaModels == null)
            {
                return HttpNotFound();
            }
            return View(ofertaModels);
        }

        // GET: OfertaModels/Create
        public ActionResult Create()
        {
            ViewBag.PrzetargModelsID = new SelectList(db.Przetargi, "ID", "ID");
            return View();
        }

        // POST: OfertaModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PrzetargModelsID,OfferPrice,ProfileModelsID,DateOfCreate")] OfertaModels ofertaModels)
        {
            if (ModelState.IsValid)
            {
                db.Oferty.Add(ofertaModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrzetargModelsID = new SelectList(db.Przetargi, "ID", "ID", ofertaModels.PrzetargModelsID);
            return View(ofertaModels);
        }

        // GET: OfertaModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaModels ofertaModels = db.Oferty.Find(id);
            if (ofertaModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrzetargModelsID = new SelectList(db.Przetargi, "ID", "ID", ofertaModels.PrzetargModelsID);
            return View(ofertaModels);
        }

        // POST: OfertaModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PrzetargModelsID,OfferPrice,ProfileModelsID,DateOfCreate")] OfertaModels ofertaModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ofertaModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrzetargModelsID = new SelectList(db.Przetargi, "ID", "ID", ofertaModels.PrzetargModelsID);
            return View(ofertaModels);
        }

        // GET: OfertaModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OfertaModels ofertaModels = db.Oferty.Find(id);
            if (ofertaModels == null)
            {
                return HttpNotFound();
            }
            return View(ofertaModels);
        }

        // POST: OfertaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OfertaModels ofertaModels = db.Oferty.Find(id);
            db.Oferty.Remove(ofertaModels);
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
