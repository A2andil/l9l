using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using l9l.Models;
using Microsoft.AspNetCore.Hosting;
using l9l.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using l9l.Data.Helpers;
using Microsoft.EntityFrameworkCore;
using l9l.Data.Api;

namespace l9l.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        private SortedSet<int> set;
        private Dictionary<int, Account> map;

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
            ViewBag.Session = HttpContext.Session.GetInt32(Values.Key);
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


        public ViewResult Details(int id)
        {
            ViewBag.Session = HttpContext.Session.GetInt32(Values.Key);
            set = new SortedSet<int>();
            map = new Dictionary<int, Account>();

            Product _product = _db.Products
                .Where(c => c.Id == id).SingleOrDefault();

            List<Comment> lst = _db.Comments
                .Where(c => c.ProductId == id).ToList();

            for (int i = 0; i < lst.Count; i++)
                set.Add(lst[i].UserId);

            List<Account> acc = _db.Accounts
                .Where(c => set.Contains(c.Id)).ToList();

            for (int i = 0; i < acc.Count; i++)
                map.Add(acc[i].Id, acc[i]);

            List<ApiComment> cmnts = new List<ApiComment>();

            for (int i = 0; i < lst.Count; i++)
            {
                cmnts.Add(new ApiComment
                {
                    Name = map[lst[i].UserId].FullName,
                    Body = lst[i].CommentBody,
                    UrlImage = map[lst[i].UserId].ImageUrl
                });
            }

            Random rand = new Random();
            DetailsViewModel model = new DetailsViewModel
            {
                product = _product,
                RateValue = (rand.Next() % 3) + 3,
                Comments = cmnts
            };
            return View(model);
        }

        private int userId()
        {
            int ans = -1;
            if (HttpContext.Session.GetInt32(Values.Key) != null)
                ans = (int)HttpContext.Session.GetInt32(Values.Key);
            return ans;
        }

        private void DeleteAllProducts()
        {
            _db.Products.RemoveRange(_db.Products);
            _db.SaveChanges();
        }

        public JsonResult cmt(int id, string com)
        {
            if (userId() == -1)
                return Json(null);
            Comment cmt = new Comment()
            {
                CommentBody = com,
                UserId = userId(),
                ProductId = id,
                date = DateTime.Now
            };
            _db.Comments.Add(cmt);
            _db.SaveChanges();

            Account ac = _db.Accounts
                .Where(c => c.Id == cmt.UserId).SingleOrDefault();

            ApiComment res = new ApiComment
            {
                Body = cmt.CommentBody,
                Name = ac.FullName,
                UrlImage = ac.ImageUrl
            };

            return Json(res);
        }
    }
}
