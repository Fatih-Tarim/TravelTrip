using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context con = new Context();
        public ActionResult Index()
        {
            var values = con.Abouts.ToList();
            return View(values);
        }
    }
}