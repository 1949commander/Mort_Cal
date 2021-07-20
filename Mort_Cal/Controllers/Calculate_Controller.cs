using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mort_Cal.Controllers
{
    public class Calculate_Controller : Controller
    {
        public IActionResult Index()
        {
            var calculate = new Calculate_Controller();
            return View(calculate);
        }
    }
}
