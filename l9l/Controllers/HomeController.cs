using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using l9l.Data.Helpers;
using l9l.Models;

namespace l9l.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Session = HttpContext.Session.GetInt32(Values.Key);
            List<Product> Products = _db.Products.ToList();
            return View(Products);
        }
    }
}
