using HomeWork4.DataAccess;
using HomeWork4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork4.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPost(string imgPath, string title, string text)
        {
            using(var db = new PostsContext())
            {
                db.Posts.Add(new Post { ImgPath = imgPath, Title = title, Text = text });
                db.SaveChanges();
            }


            return RedirectToAction("index");
        }
    }
}