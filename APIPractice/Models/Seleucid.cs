using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPractice.Models
{
    public class Seleucid
    {
        public string Name { get; set; }

        public int StartReign { get; set; }

        public int EndReign { get; set; }

        public List<string> Consorts { get; set; }

    }

    public class SeleucidResponse
    {
        public List<Seleucid> Seleucids { get; set; }
    }
}
