using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentModel1.Models
{
    public class StudentModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string City{ get; set; }

        public decimal Percentage { get; set; }
    }
}