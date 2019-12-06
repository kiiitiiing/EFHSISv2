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
    public class SchistosomiasisController : Controller
    {
        [HttpGet]
        public IActionResult SchistosomiasHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SchistosomiasHome(string filter)
        {
            return View();
        }
    }
}