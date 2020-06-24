using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheConference.Models.Class;
namespace TheConference.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        Context c = new Context();
        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            //var  blogs = c.Blogs.ToList();
            //return View(blogs);
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(3).ToList();
            return View(by);

        }

        public ActionResult BlogDetay(int id)
        {
            //  var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            //  return View(blogbul);
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlar.Where(x => x.Blog.ID== id).ToList();
            return View(by);
        }

        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        public PartialViewResult HomeContentContainer()
        {
            return PartialView();
        }

    }
}