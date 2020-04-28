using l9l.Data.Component;
using l9l.Data.Helpers;
using l9l.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Components
{
    public class AccountComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public AccountComponent(AppDbContext db)
        {
            _db = db;
        }

        private int getId()
        {
            int ans = 0;
            if (HttpContext.Session.GetInt32(Values.Key) != null)
                ans = (Int32)HttpContext.Session.GetInt32(Values.Key);
            return ans;
        }

        public IViewComponentResult Invoke()
        {
            Account account = _db.Accounts
                .Where(c => c.Id == getId()).SingleOrDefault();
            AccountCVM model = new AccountCVM
            {
                Id = account.Id,
                Name = account.FullName
            };
            return View(model);
        }
    }
}
