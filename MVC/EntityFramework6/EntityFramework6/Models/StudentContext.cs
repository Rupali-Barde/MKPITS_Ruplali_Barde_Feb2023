using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace EntityFramework6.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("StudentDatabase")
        {

        }
        public DbSet<Student> Students { get; set; }
     
    }
}