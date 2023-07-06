using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Entity3.Models
{
    public class StudentContext : DbContext
    {
        //Creating Constructor 
        public StudentContext() : base("studentDatabase")
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}