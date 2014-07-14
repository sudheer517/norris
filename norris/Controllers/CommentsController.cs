using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using norris.Models;
using Microsoft.AspNet.Identity;
namespace norris.Controllers
{
    public class CommentsController : Controller
    {
        private FactContext db = new FactContext();
        private ApplicationDbContext db1 = new ApplicationDbContext();
        
        // GET: Comments
        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }
        public ActionResult getallbyfactid()
        {
            int factid = Convert.ToInt32(Request["factid"]);
            var comments = db.Comments.Where(r => r.FACT_ID == factid).ToList();
            return Json(comments, JsonRequestBehavior.AllowGet);
        }
        public ActionResult addnew()
        {
            string commentText = Convert.ToString(Request["commentText"]);
            int factId = Convert.ToInt32(Request["factId"]);
            var temptemp = User.Identity.GetUserId();
            string email;
            if (temptemp == null)
            {
                email = "Anonymous";
            }
            else
            {
                email = Convert.ToString(db1.Users.Find(User.Identity.GetUserId()).Email);
            }
                DateTime now = DateTime.Now;
                Comment c = new Comment
                {
                    FACT_ID = factId,
                    USER_EMAIL = email,
                    Text = commentText,
                    Date = now
                };
                db.Comments.Add(c);
                db.SaveChanges();
                return Json(c, JsonRequestBehavior.AllowGet);
        }
    }
}