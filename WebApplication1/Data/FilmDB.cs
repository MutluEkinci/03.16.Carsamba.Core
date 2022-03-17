using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class FilmDB : DbContext
    {
        public FilmDB(DbContextOptions<FilmDB> options) : base(options)
        {

        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            InitDB.InitializeDB(modelBuilder);
        }
    }
}
