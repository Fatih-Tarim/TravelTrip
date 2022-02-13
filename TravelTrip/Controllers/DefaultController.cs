using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class DefaultController : Controller
    {
        Context con = new Context();
        // GET: Default
        public ActionResult Index()
        {
            var values = con.Blogs.OrderByDescending(x => x.Id).Take(4).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Cards()
        {
            var values = con.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult RightCard()
        {
            var value = con.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(value);
        }
        public PartialViewResult IndexTop10()
        {
            var value = con.Blogs.OrderByDescending(x=>x.Id).Take(10).ToList();
            return PartialView(value);
        }
        public PartialViewResult BestPLaces()
        {
            var value = con.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult BestPlacesRight()
        {
            var value = con.Blogs.Take(3).ToList();
            return PartialView(value);
        }
    }
}