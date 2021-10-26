using BirEylulMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components
namespace BirEylulMarket.ViewComponents
{
    public class KategorilerMenusuViewComponent : ViewComponent
    {
        private readonly UygulamaDbContext db;

        public KategorilerMenusuViewComponent(UygulamaDbContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(db.Kategoriler.ToList());
        }
    }
}
