using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test1_Q2.Models
{
    public class Movie
    {
        [Key]
        public int Movie_ID { get; set; }
        public string Movie_Name { get; set; }
        public DateTime Date_of_Release { get; set; }
        
    }
}