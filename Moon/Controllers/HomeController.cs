using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moon.DAL;
using Moon.Models;
using Moon.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConnectToDb _db;
        public HomeController(ConnectToDb db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
               
                Services=_db.Services.ToList(),
                Counters = _db.Counters.ToList(),
                Features = _db.Features.ToList(),
                Brands = _db.Brands.ToList(),
                Blogs = _db.Blogs.ToList(),
                Categories = _db.Categories.ToList(),
                Products = _db.Products.ToList(),
                Pricings = _db.Pricings.ToList(),
                Clients = _db.Clients.ToList(),
                Navbars = _db.Navbars.ToList()

            };

            return View(hvm);
        }

       
    }
}
