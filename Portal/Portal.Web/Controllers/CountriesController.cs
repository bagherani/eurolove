using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portal.Web.Models;

namespace Portal.Web.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Italy()
        {
            return View();
        }

        public IActionResult Slovenia()
        {
            return View();
        }

        public IActionResult Portugal()
        {
            return View();
        }
    }
}
