using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Yonetmen
    {
        public int YonetmenID { get; set; }
        public string YonetmenAdi { get; set; }

        public List<Film> Filmler { get; set; }
    }
}
