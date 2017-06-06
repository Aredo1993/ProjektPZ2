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
    public class PrzetargModelsController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: PrzetargModels
        public ActionResult Index()
        {
            var przetargi = db.Przetargi.Include(p => p.ProfileModels);
            return View(przetargi.ToList());
        }

        // GET: PrzetargModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzetargModels przetargModels = db.Przetargi.Find(id);
            if (przetargModels == null)
            {
                return HttpNotFound();
            }
            return View(przetargModels);
        }

        // GET: PrzetargModels/Create
        public ActionResult Create()
        {
            ViewBag.ProfileID = new SelectList(db.Profile, "ID", "Login");
            return View();
        }

        // POST: PrzetargModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProfileID,DateOfCreate,DateOfEnd")] PrzetargModels przetargModels)
        {
            if (ModelState.IsValid)
            {
                db.Przetargi.Add(przetargModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProfileID = new SelectList(db.Profile, "ID", "Login", przetargModels.ProfileID);
            return View(przetargModels);
        }

        // GET: PrzetargModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzetargModels przetargModels = db.Przetargi.Find(id);
            if (przetargModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProfileID = new SelectList(db.Profile, "ID", "Login", przetargModels.ProfileID);
            return View(przetargModels);
        }

        // POST: PrzetargModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProfileID,DateOfCreate,DateOfEnd")] PrzetargModels przetargModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(przetargModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProfileID = new SelectList(db.Profile, "ID", "Login", przetargModels.ProfileID);
            return View(przetargModels);
        }

        // GET: PrzetargModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrzetargModels przetargModels = db.Przetargi.Find(id);
            if (przetargModels == null)
            {
                return HttpNotFound();
            }
            return View(przetargModels);
        }

        // POST: PrzetargModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrzetargModels przetargModels = db.Przetargi.Find(id);
            db.Przetargi.Remove(przetargModels);
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
