using HomeWork4.DataAccess;
using HomeWork4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork4.Controllers
{
    public class HomeController : Controller
    {
        private PostsContext db = new PostsContext();

        // GET: Home
        public ActionResult Index()
        {
            var posts = db.Posts.ToList();
            ViewData["Posts"] = posts;

            return View();
        }
        

        public ActionResult Update()
        {
            return Json(db.Posts.ToList(), JsonRequestBehavior.AllowGet);
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