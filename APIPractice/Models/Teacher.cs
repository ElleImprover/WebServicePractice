﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPractice.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public string HomeState { get; set; }

    }

    public class TeacherList
    {
        public List<Teacher> Teachers { get; set; }
    }
}
