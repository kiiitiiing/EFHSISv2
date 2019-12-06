using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHSIS.AuthData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EFHSIS.Controllers
{
    [Authorize]
    [MyActionFilter]
    public class TuberculosisController : Controller
    {
        [HttpGet]
        public IActionResult TuberculosisHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TuberculosisHome(string filter)
        {
            return View();
        }
    }
}