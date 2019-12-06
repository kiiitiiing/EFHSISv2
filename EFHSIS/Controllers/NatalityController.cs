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
    public class NatalityController : Controller
    {
        [HttpGet]
        public IActionResult NatalityHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NatalityHome(string filter)
        {
            return View();
        }
    }
}