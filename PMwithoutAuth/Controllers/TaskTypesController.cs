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
    public class TaskTypesController : Controller
    {
        private PerfMgtDBEntities db = new PerfMgtDBEntities();

        // GET: TaskTypes
        public ActionResult Index()
        {
            return View(db.TaskType.ToList());
        }

        // GET: TaskTypes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskType taskType = db.TaskType.Find(id);
            if (taskType == null)
            {
                return HttpNotFound();
            }
            return View(taskType);
        }

        // GET: TaskTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskTypeName")] TaskType taskType)
        {
            if (ModelState.IsValid)
            {
                db.TaskType.Add(taskType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskType);
        }

        // GET: TaskTypes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskType taskType = db.TaskType.Find(id);
            if (taskType == null)
            {
                return HttpNotFound();
            }
            return View(taskType);
        }

        // POST: TaskTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskTypeName")] TaskType taskType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskType);
        }

        // GET: TaskTypes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskType taskType = db.TaskType.Find(id);
            if (taskType == null)
            {
                return HttpNotFound();
            }
            return View(taskType);
        }

        // POST: TaskTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TaskType taskType = db.TaskType.Find(id);
            db.TaskType.Remove(taskType);
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
