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
    public class NatalityLcrController : Controller
    {
        [HttpGet]
        public IActionResult NatalityLcrHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NatalityLcrHome(string filter)
        {
            return View();
        }
    }
}