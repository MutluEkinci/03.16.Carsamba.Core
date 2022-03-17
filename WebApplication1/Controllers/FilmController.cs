using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FilmController : Controller
    {
        FilmDB _db;
        public FilmController(FilmDB db)
        {
            _db = db;
            //_db.Database.EnsureCreated();//Database yoksa oluşturuyor varsa dokunmuyor.
        }
        public IActionResult Index()
        {
            var film = _db.Filmler.Include(f => f.Kategori).Include(f => f.Yonetmen);
            return View(film);
        }
    }
}
