using l9l.Data.Helpers;
using l9l.Data.Test;
using l9l.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Components
{
    public class ShoppingCartSummery : ViewComponent
    {
        private readonly AppDbContext _db;

        public ShoppingCartSummery(AppDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            int s = (int)HttpContext.Session.GetInt32(Values.Key);
            int r = _db.CartItems.Where(x => x.UserId == s).ToList().Count;
            CartCVM c = new CartCVM { Count = r };
            return View(c);
        }
    }
}
