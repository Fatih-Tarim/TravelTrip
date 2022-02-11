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
        BlogComment bc = new BlogComment();
        public ActionResult BlogDetail(int id)
        {
            //var FindBlog = con.Blogs.Where(x => x.Id == id).ToList();
            bc.Value1 = con.Blogs.Where(x => x.Id == id).ToList();
            bc.Value2 = con.Comments.Where(x => x.BlogId == id).ToList();
            return View(bc);
        }
    }
}