using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PharmaEvaluation.Models;

namespace PharmaEvaluation.Controllers
{
    public class ContactusController : Controller
    {
        private ContactUsContext db = new ContactUsContext();

        //
        // GET: /Contactus/

        public ActionResult Index()
        {
            return View(db.cuSub.ToList());
        }

        //
        // GET: /Contactus/Details/5

        public ActionResult Details(int id = 0)
        {
            ContactUsSubmissionModel contactussubmissionmodel = db.cuSub.Find(id);
            if (contactussubmissionmodel == null)
            {
                return HttpNotFound();
            }
            return View(contactussubmissionmodel);
        }

        //
        // GET: /Contactus/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Contactus/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContactUsSubmissionModel contactussubmissionmodel)
        {
            if (ModelState.IsValid)
            {
                db.cuSub.Add(contactussubmissionmodel);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(contactussubmissionmodel);
        }

        //
        // GET: /Contactus/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ContactUsSubmissionModel contactussubmissionmodel = db.cuSub.Find(id);
            if (contactussubmissionmodel == null)
            {
                return HttpNotFound();
            }
            return View(contactussubmissionmodel);
        }

        //
        // POST: /Contactus/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContactUsSubmissionModel contactussubmissionmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactussubmissionmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactussubmissionmodel);
        }

        //
        // GET: /Contactus/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ContactUsSubmissionModel contactussubmissionmodel = db.cuSub.Find(id);
            if (contactussubmissionmodel == null)
            {
                return HttpNotFound();
            }
            return View(contactussubmissionmodel);
        }

        //
        // POST: /Contactus/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactUsSubmissionModel contactussubmissionmodel = db.cuSub.Find(id);
            db.cuSub.Remove(contactussubmissionmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}