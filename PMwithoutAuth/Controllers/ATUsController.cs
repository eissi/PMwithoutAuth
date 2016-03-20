using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PMwithoutAuth
{
    public class ATUsController : Controller
    {
        private PerfMgtDBEntities db = new PerfMgtDBEntities();

        // GET: ATUs
        public ActionResult Index()
        {
            return View(db.ATU.ToList());
        }

        // GET: ATUs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATU aTU = db.ATU.Find(id);
            if (aTU == null)
            {
                return HttpNotFound();
            }
            return View(aTU);
        }

        // GET: ATUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ATUs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ATUname")] ATU aTU)
        {
            if (ModelState.IsValid)
            {
                db.ATU.Add(aTU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aTU);
        }

        // GET: ATUs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATU aTU = db.ATU.Find(id);
            if (aTU == null)
            {
                return HttpNotFound();
            }
            return View(aTU);
        }

        // POST: ATUs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ATUname")] ATU aTU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aTU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aTU);
        }

        // GET: ATUs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ATU aTU = db.ATU.Find(id);
            if (aTU == null)
            {
                return HttpNotFound();
            }
            return View(aTU);
        }

        // POST: ATUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ATU aTU = db.ATU.Find(id);
            db.ATU.Remove(aTU);
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
