using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UF.Models;

namespace UF.Controllers
{
    public class GatorsController : Controller
    {
        private UFDbContext db = new UFDbContext();

        // GET: /Gators/
        public ActionResult Index()
        {
            return View(db.Gators.ToList());
        }

        // GET: /Gators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gator gator = db.Gators.Find(id);
            if (gator == null)
            {
                return HttpNotFound();
            }
            return View(gator);
        }

        // GET: /Gators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Gators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Gator gator)
        {
            if (ModelState.IsValid)
            {
                db.Gators.Add(gator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gator);
        }

        // GET: /Gators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gator gator = db.Gators.Find(id);
            if (gator == null)
            {
                return HttpNotFound();
            }
            return View(gator);
        }

        // POST: /Gators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,StudentName,EnrollDate,Adress,GPA")] Gator gator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gator).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gator);
        }

        // GET: /Gators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gator gator = db.Gators.Find(id);
            if (gator == null)
            {
                return HttpNotFound();
            }
            return View(gator);
        }

        // POST: /Gators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Gator gator = db.Gators.Find(id);
            db.Gators.Remove(gator);
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
