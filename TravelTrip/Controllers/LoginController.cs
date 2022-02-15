using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip.Models.Classes;

namespace TravelTrip.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context con = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var values = con.Admins.FirstOrDefault(x => x.User == admin.User && x.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.User,false);
                Session["User"] = values.User.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }
    }
}