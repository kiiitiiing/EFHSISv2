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
    public class LeprosyController : Controller
    {
        [HttpGet]
        public IActionResult LeprosyHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LeprosyHome(string filter)
        {
            return View();
        }
    }
}