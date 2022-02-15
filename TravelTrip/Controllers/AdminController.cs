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
        [Authorize]
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
        public ActionResult DeleteBlog(int id)
        {
            var BLogId = con.Blogs.Find(id);
            con.Blogs.Remove(BLogId);
            con.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var Blog = con.Blogs.Find(id);
            return View("GetBlog", Blog);
        }
        public ActionResult UpdateBlog(Blog blog)
        {
            var blg = con.Blogs.Find(blog.Id);
            blg.Title = blog.Title;
            blg.Description = blog.Description;
            blg.Date = blog.Date;
            blg.BlogImage = blog.BlogImage;
            con.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comments = con.Comments.ToList();
            return View(comments);
        }
        public ActionResult DeleteComment(int id)
        {
            var CommentId = con.Comments.Find(id);
            con.Comments.Remove(CommentId);
            con.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult GetComments(int id)
        {
            var comment = con.Comments.Find(id);
            return View("GetComments", comment);
        }
        public ActionResult UpdateComment(Comments comments)
        {
            var comment = con.Comments.Find(comments.Id);
            comment.Id = comments.Id;
            comment.Mail = comments.Mail;
            comment.UserName = comments.UserName;
            comment.Comment = comment.Comment;
            con.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}