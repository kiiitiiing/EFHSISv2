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
    public class MortBhsController : Controller
    {
        [HttpGet]
        public IActionResult MorthBhsHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MorthBhsHome(string filter)
        {
            return View();
        }
    }
}