using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo_teste.Models
{
    public class ICourse
    {
        string Name { get; set; }
        Teacher Teacher { get; set; }
        int Duration { get; set; }
    }
}