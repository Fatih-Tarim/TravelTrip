using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelTrip.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> Value1 {get; set;}
        public IEnumerable<Comments> Value2 { get; set; }
    }
}