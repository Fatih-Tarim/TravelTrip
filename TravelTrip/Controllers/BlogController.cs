using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;


namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context con = new Context();
        public ActionResult Index()
        {
            var blogs = con.Blogs.ToList();
            return View(blogs);
        }
        public ActionResult BlogDetail(int id)
        {
            return View();
        }
    }
}