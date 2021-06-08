using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPractice.Models;


namespace APIPractice.ViewModels
{
    public class APIViewModel
    {
        public int RandomNumber { get; set; }
        public ChuckNorris ChucKNorris { get; set; }
        public List<Seleucid> seleucids { get; set; }
        public Teacher Teacher { get; set; }
       
    }
}
