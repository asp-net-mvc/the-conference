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
        public ActionResult Index()
        {
            var  blogs = c.Blogs.ToList();
            return View(blogs);
        }
    }
}