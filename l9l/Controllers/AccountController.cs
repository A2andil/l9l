using System.Linq;
using Microsoft.AspNetCore.Mvc;
using l9l.Models;
using Microsoft.AspNetCore.Http;
using l9l.Data.ViewModels;
using l9l.Data.Helpers;
using System;

namespace l9l.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _db;

        public AccountController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            if (HttpContext.Session.GetInt32(Values.Key) != null)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account mdl)
        {
            var result = _db.Accounts
                .Where(c =>
                c.Email.ToLower() == mdl.Email.ToLower()
                && mdl.Password == c.Password).SingleOrDefault();
            if (result != null)
            {
                HttpContext.Session.SetInt32(Values.Key, result.Id);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            if (HttpContext.Session.GetInt32(Values.Key) != null)
                return RedirectToAction("Index", "Home");
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel mdl)
        {
            var user = _db.Accounts
                .Where(c => c.Email == mdl.Email).SingleOrDefault();
            if (user == null)
            {
                Account ac = new Account
                {
                    Email = mdl.Email, Password = mdl.Password,
                    FullName = mdl.FullName, ConfirmedPassword = true,
                    Phone = mdl.Phone, AccountType = mdl.Membership
                };
                _db.Accounts.Add(ac);
                _db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(new RegisterViewModel());
        }
    }
}
