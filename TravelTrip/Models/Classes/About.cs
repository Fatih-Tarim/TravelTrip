using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Classes
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string picUrl { get; set; }
        public string aboutDescription { get; set; }
        
    }
}