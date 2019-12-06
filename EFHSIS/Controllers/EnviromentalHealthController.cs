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
    public class EnviromentalHealthController : Controller
    {
        [HttpGet]
        public IActionResult EnvironmentalHome()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnvironmentalHome(string filter)
        {
            return View();
        }
    }
}