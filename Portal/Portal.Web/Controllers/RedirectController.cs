using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portal.Web.Models;

namespace Portal.Web.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult Italy()
        {
            return RedirectPermanent("/اخذ-اقامت-ایتالیا");
        }
        public IActionResult Slovenia()
        {
            return RedirectPermanent("/اخذ-اقامت-اسلوونی");
        }
        public IActionResult Portugal()
        {
            return RedirectPermanent("/اخذ-اقامت-پرتغال");
        }

        public IActionResult AboutUs()
        {
            return RedirectPermanent("/درباره-ما");
        }

        public IActionResult ContactUs()
        {
            return RedirectPermanent("/تماس-با-ما");
        }

    }
}
