﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsingViewModel.Models
{
    public class ViewModel
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}