using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using l9l.Models;
using Microsoft.AspNetCore.Hosting;
using l9l.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using l9l.Data.Helpers;

namespace l9l.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;

        public ProductController(AppDbContext context, IHostingEnvironment env)
        {
            _db = context;
            _env = env;
        }

        public ViewResult Index()
        {
            ViewBag.Session = HttpContext.Session.GetInt32(Values.Key);
            List<Product> Products = _db.Products.ToList();
            return View(Products);
        }

        public ViewResult Add()
        {
            ProductViewModel pvm = new ProductViewModel
            {
                Categories = _db.Categories.ToList()
            };
            return View(pvm);
        }

        [HttpPost]
        public ActionResult Add(ProductViewModel model, IFormFile UploadedImage)
        {
            if (ModelState.IsValid)
            {
               string Folder = Values.PFolder, path = null;
                if (ModelState.IsValid)
                {
                    if (UploadHelper.IsImage(UploadedImage.FileName))
                    {
                        path =
                            UploadHelper.Upload(UploadedImage,
                                UploadHelper.GetFolder(Folder, _env), _env);
                    }
                    Product tbl = new Product
                    {
                        Name = model.Product.Name,
                        ImageUrl = Folder + path,
                        ShortDiscription = model.Product.ShortDiscription,
                        LongDescription = model.Product.LongDescription,
                        CategoryId = model.Product.CategoryId,
                        Price = model.Product.Price,
                        InStock = model.Product.InStock
                    };
                    _db.Products.Add(tbl);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction(Values.Index);
        }


        public ViewResult Details()
        {
            return View();
        }

        private void DeleteAllProducts()
        {
            _db.Products.RemoveRange(_db.Products);
            _db.SaveChanges();
        }
    }
}
