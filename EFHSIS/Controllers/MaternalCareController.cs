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
    public class MaternalCareController : Controller
    {
        [HttpGet]
        public IActionResult MaternalHome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MaternalHome(string filter)
        {
            return View();
        }
    }
}