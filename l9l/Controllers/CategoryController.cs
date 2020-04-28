using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using l9l.Models;
using l9l.Data.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace l9l.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        IHostingEnvironment _env;
        public CategoryController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Add()
        {
            return View(new Category());
        }

        [HttpPost]
        public ViewResult Add(Category cat, IFormFile ImgUpload)
        {
            string Folder = Values.CFolder, path = null;
            if (ModelState.IsValid)
            {
                if (UploadHelper.IsImage(ImgUpload.FileName))
                    path = UploadHelper.UploadCat(ImgUpload,
                              UploadHelper.GetFolder(Folder, _env), _env);
                

                Category tbl = new Category
                {
                    Name = cat.Name,
                    Description = cat.Description,
                    ImageUrl = Folder + path
                };
                _db.Categories.Add(tbl);
                _db.SaveChanges();
            }
            return View();
        }

        private void RemoveAllCategories()
        {
            _db.Categories.RemoveRange(_db.Categories);
            _db.SaveChanges();
        }
    }
}