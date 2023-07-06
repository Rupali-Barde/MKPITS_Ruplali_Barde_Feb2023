using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstModel.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {
            
        }

        public DbSet<StudentContext> Students { get; set; }

        public System.Data.Entity.DbSet<CodeFirstModel.Models.ClassStudent> ClassStudents { get; set; }
    }
    
    
}