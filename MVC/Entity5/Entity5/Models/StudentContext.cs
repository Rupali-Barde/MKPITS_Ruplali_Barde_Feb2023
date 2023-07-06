using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Entity5.Models
{
    public class StudentContext : DbContext
    {
      public StudentContext():base ("StudentDatabase") 
        {
        
        }
        public DbSet<ClassStudent> Students { get; set; }
    }
}