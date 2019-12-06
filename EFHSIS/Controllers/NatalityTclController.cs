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
    public class NatalityTclController : Controller
    {
        [HttpGet]
        public IActionResult NatalityTclHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NatalityTclHome(string filter)
        {
            return View();
        }
    }
}