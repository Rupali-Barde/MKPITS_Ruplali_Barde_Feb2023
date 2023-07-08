using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewEx1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EnrollmentNo { get; set; }

        public List<Student>GetStudents() 
        {
            List<Student> Students = new List<Student>();
            Students.Add(new Student { StudentId = 1, Code = "1001", Name = "Amit Gupta", EnrollmentNo = "19180003" });
            Students.Add(new Student { StudentId = 2, Code = "1002", Name = "Raj Varma", EnrollmentNo = "191800004" });
            Students.Add(new Student { StudentId = 3, Code = "1003", Name = "Radha tiwari", EnrollmentNo = "191800005" });
            return Students;
        }
    }
}