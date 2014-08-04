using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using norris.Models;

namespace norris.Controllers
{
    public class SuggestFactController : Controller
    {
        private FactContext db = new FactContext();

        // GET: /SuggestFact/
        public ActionResult Index()
        {
            return View(db.Facts.ToList());
        }

        // GET: /SuggestFact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fact fact = db.Facts.Find(id);
            if (fact == null)
            {
                return HttpNotFound();
            }
            return View(fact);
        }

        // GET: /SuggestFact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /SuggestFact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Text,Author,Date,Views")] Fact fact)
        {
            if (ModelState.IsValid)
            {
                db.Facts.Add(fact);
                db.SaveChanges();
                return RedirectToAction("Index", "Home", new { id = fact.ID });
            }

            return View(fact);
        }

        public ActionResult addSuggestion()
        {
            string text = Convert.ToString(Request["Text"]);
            string author = Convert.ToString(Request["author"]);
            DateTime date = Convert.ToDateTime(Request["date"]);
            int views = 0;
            Fact fact = new Fact
            {
                Text = text,
                Author = author,
                Date = date,
                Views = views


            };
            db.Facts.Add(fact);
            db.SaveChanges();
            return Json(fact, JsonRequestBehavior.AllowGet);
        }

        // GET: /SuggestFact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fact fact = db.Facts.Find(id);
            if (fact == null)
            {
                return HttpNotFound();
            }
            return View(fact);
        }

        // POST: /SuggestFact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Text,Author,Date,Views")] Fact fact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fact);
        }

        // GET: /SuggestFact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fact fact = db.Facts.Find(id);
            if (fact == null)
            {
                return HttpNotFound();
            }
            return View(fact);
        }

        // POST: /SuggestFact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fact fact = db.Facts.Find(id);
            db.Facts.Remove(fact);
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
