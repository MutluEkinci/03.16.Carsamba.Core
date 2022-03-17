using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public int Sure { get; set; }
        public int KategoriID { get; set; }
        public string Ozet { get; set; }
        public bool Altyazili { get; set; }
        public string Afis { get; set; }
        public int YonetmenID { get; set; }



        public Yonetmen Yonetmen { get; set; }
        public Kategori Kategori { get; set; }

    }
}
