using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        Context con = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var values = con.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(Blog p)
        {
            con.Blogs.Add(p);
            con.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}