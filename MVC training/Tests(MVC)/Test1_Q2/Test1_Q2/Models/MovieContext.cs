using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Test1_Q2.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("connection")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}