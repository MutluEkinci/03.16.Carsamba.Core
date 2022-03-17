using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public static class InitDB
    {
        public static void InitializeDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { KategoriID = 1, KategoriAdi = "Macera" },
                new Kategori { KategoriID = 2, KategoriAdi = "Savaş" },
                new Kategori { KategoriID = 3, KategoriAdi = "Komedi" }
                );

            modelBuilder.Entity<Film>().HasData(
                new Film { FilmID = 1, FilmAdi = "Indiana Jones", KategoriID = 1, Sure = 95, Altyazili = false, Afis = "ij_1.jpg", YonetmenID = 1 },
                new Film { FilmID = 2, FilmAdi = "Ace Ventura", KategoriID = 3, Sure = 98, Altyazili = true, Afis = "av.jpg", YonetmenID = 2 },
                new Film { FilmID = 3, FilmAdi = "Fury", KategoriID = 2, Sure = 106, Altyazili = false, Afis = "fury.jpg", YonetmenID = 1 },
                new Film { FilmID = 4, FilmAdi = "Bebek Firarda", KategoriID = 3, Sure = 103, Altyazili = true, Afis = "bf.jpg", YonetmenID = 2 }

                );

            modelBuilder.Entity<Yonetmen>().HasData(

                new Yonetmen { YonetmenID = 1, YonetmenAdi = "Tarantino" },
                new Yonetmen { YonetmenID = 2, YonetmenAdi = "Mel Gibson" }
                );
        }
    }
}
