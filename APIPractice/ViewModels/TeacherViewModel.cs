using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPractice.Models;

namespace APIPractice.ViewModels
{
    public class TeacherViewModel
    {
        public Teacher Teacher { get; set; }

        public List<Teacher> TeacherList { get; set; }
    }
}
