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
    public class FilariasisController : Controller
    {
        [HttpGet]
        public IActionResult FilariasisHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FilariasisHome(string filter) {
            return View();
        }
    }
}