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
    public class MortalityController : Controller
    {
        [HttpGet]
        public IActionResult MortalityHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MortalityHome(string filter)
        {
            return View();
        }

    }
}