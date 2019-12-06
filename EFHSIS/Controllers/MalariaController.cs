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
    public class MalariaController : Controller
    {
        [HttpGet]
        public IActionResult MalariaHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MalariaHome(string filter)
        {
            return View();
        }
    }
}