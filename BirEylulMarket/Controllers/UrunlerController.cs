using BirEylulMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirEylulMarket.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly UygulamaDbContext db;

        public UrunlerController(UygulamaDbContext context)
        {
            db = context;
        }

        //[Route("k/{id:int?}")]
        public IActionResult Index(int? id)
        {
            return View(db.Urunler
                    .Include(u => u.Kategori)
                    .Where(u => !id.HasValue || u.KategoriId == id)
                    .ToList()
                );
        }
    }
}
