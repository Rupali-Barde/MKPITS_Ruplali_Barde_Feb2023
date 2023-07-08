using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewEx1.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Teacher>GetTeachers() 
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher { TeacherId = 1, Code = "RB", Name = "Rupali Barde" });
            teachers.Add(new Teacher { TeacherId = 2, Code = "MP", Name = "Mayuri Pal" });
            teachers.Add(new Teacher { TeacherId = 3, Code = "MB", Name = "Mahima Barde" });
            return teachers;
        }


    }
}