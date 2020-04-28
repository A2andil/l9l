using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace l9l.Controllers
{
    public class RateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
