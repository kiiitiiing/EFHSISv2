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
    public class FamilyPlanningController : Controller
    {
        [HttpGet]
        public IActionResult FamilyHome()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FamilyHome(string filter)
        {
            return View();
        }
    }
}