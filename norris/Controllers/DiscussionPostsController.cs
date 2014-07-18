using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using norris.Models;
using System.Web.Helpers;

namespace norris.Controllers
{

    public class DiscussionPostsController : Controller
    {

        private FactContext db = new FactContext();

        // GET: DiscussionPosts
        public ActionResult Index()
        {
            return View(db.DiscussionPosts.ToList());
        }

        // GET: DiscussionPosts/Details/5
        public ActionResult GetPosts(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return Json(db.DiscussionPosts.Where(x=> x.DiscussionID==id), JsonRequestBehavior.AllowGet);
            //return View(db.DiscussionPosts.Where(ID=id));
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiscussionPost discussionPost = db.DiscussionPosts.Find(id);
            if (discussionPost == null)
            {
                return HttpNotFound();
            }
            return View(discussionPost);
        }

        // GET: DiscussionPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiscussionPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Create([Bind(Include = "DiscussionID,Text,Author,Votes,Date")] DiscussionPost discussionPost)
        {
            if (ModelState.IsValid)
            {
                db.DiscussionPosts.Add(discussionPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(discussionPost);
        }

        // GET: DiscussionPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiscussionPost discussionPost = db.DiscussionPosts.Find(id);
            if (discussionPost == null)
            {
                return HttpNotFound();
            }
            return View(discussionPost);
        }

        // POST: DiscussionPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Text,Author,Votes,Date")] DiscussionPost discussionPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(discussionPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(discussionPost);
        }

        // GET: DiscussionPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiscussionPost discussionPost = db.DiscussionPosts.Find(id);
            if (discussionPost == null)
            {
                return HttpNotFound();
            }
            return View(discussionPost);
        }

        // POST: DiscussionPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiscussionPost discussionPost = db.DiscussionPosts.Find(id);
            db.DiscussionPosts.Remove(discussionPost);
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
