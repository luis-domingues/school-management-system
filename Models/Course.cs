using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo_teste.Models
{
    public class Course : ICourse
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public int Duration { get; set; }
    }
}