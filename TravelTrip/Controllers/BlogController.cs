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
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = con.Blogs.ToList();
            bc.Value1 = con.Blogs.ToList();
            bc.LastBlogs = con.Blogs.OrderByDescending(x => x.Id).Take(4).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {
            //var FindBlog = con.Blogs.Where(x => x.Id == id).ToList();
            bc.Value1 = con.Blogs.Where(x => x.Id == id).ToList();
            bc.Value2 = con.Comments.Where(x => x.BlogId == id).ToList();
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddComment(Comments c)
        {
            con.Comments.Add(c);
            con.SaveChanges();
            return PartialView("Index");
        }
    }
}