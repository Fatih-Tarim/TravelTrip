using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTrip.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AddressBlog> AddressBlog { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Home> Home { get; set; }       
    }
}