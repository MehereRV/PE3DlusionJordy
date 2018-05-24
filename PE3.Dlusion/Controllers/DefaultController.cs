using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PE3.Dlusion.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}