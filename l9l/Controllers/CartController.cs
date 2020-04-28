using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using l9l.Models;
using l9l.Data.Helpers;
using Microsoft.AspNetCore.Http;
using l9l.Data.ViewModels;

namespace l9l.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _db;
        private CartHelper _cartHelper;

        public CartController(AppDbContext db)
        {
            _cartHelper = new CartHelper();
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Session = HttpContext.Session.GetInt32(Values.Key);
            int id = 0;
            if (HttpContext.Session.GetInt32(Values.Key) == null)
                return View(_cartHelper.Cart);
            else id = (int)HttpContext.Session.GetInt32(Values.Key);

            List<CartItem> cartitems = _db.CartItems
                .Where(c => c.UserId == id).ToList();
            _cartHelper.StoreProductIds(cartitems);

            List<Product> SelectedProducts = new List<Product>();
            foreach (Product p in _db.Products.ToList())
                if (_cartHelper.Contains(p.Id))
                    SelectedProducts.Add(p);

            _cartHelper.Cart.UserId = id;
            _cartHelper.Cart.TotalPrice = 0;

            _cartHelper.StoreProduct(SelectedProducts);
            _cartHelper.StoreCount(cartitems);
            _cartHelper.FillCart();

            return View(_cartHelper.Cart);
        }

        private int getUserId()
        {
            int ans = 0;
            if (HttpContext.Session.GetInt32(Values.Key) != null)
                ans = (int)HttpContext.Session.GetInt32(Values.Key);
            return ans;
        }

        public ActionResult Add(int Id)
        {
            int userId = getUserId();
            if (userId == 0) return RedirectToAction(Values.Index);

            CartItem item = _db.CartItems.Where(c => c.ProductId == Id && c.UserId == userId).SingleOrDefault();

            if (item != null)
                item.Count++;
            else
            {
                item = new CartItem
                {
                    ProductId = Id,
                    Count = 1,
                    UserId = userId
                };
                _db.CartItems.Add(item);
            }
            _db.SaveChanges();
            return RedirectToAction(Values.Index);
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            _db.CartItems.Remove(_db.CartItems
                .Where(c => c.ProductId == id && c.UserId == getUserId())
                .SingleOrDefault());
            _db.SaveChanges();
            return RedirectToAction(Values.Index);
        }

        public ActionResult Edit(int Id)
        {
            CartItem cart = _db.CartItems
                .Where(c => c.UserId == getUserId() && c.ProductId == Id)
                .SingleOrDefault();

            Product pd = _db.Products
                .Where(c => c.Id == cart.ProductId).SingleOrDefault();

            CartItemViewModel civm = new CartItemViewModel
            {
                Count = cart.Count,
                ProductId = cart.ProductId,
                Image = pd.ImageUrl,
                Name = pd.Name,
                Price = pd.Price
            };
            return View(civm);
        }

        [HttpPost]
        public ActionResult Edit(CartItemViewModel model)
        {
            if (model.Count <= 0)
                return BadRequest();
            CartItem cart = _db.CartItems
                .Where(c => model.ProductId == c.ProductId
                && c.UserId == getUserId()).SingleOrDefault();
            cart.Count = model.Count;
            _db.SaveChanges();
            return RedirectToAction(Values.Index);
        }
    }
}
