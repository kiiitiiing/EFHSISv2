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
    public class StiController : Controller
    {
        [HttpGet]
        public IActionResult StiHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StiHome(string filter)
        {
            return View();
        }
    }
}