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
    public class MbhsController : Controller
    {
        [HttpGet]
        public IActionResult MbhsHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MbhsHome(string filter)
        {
            return View();
        }
    }
}