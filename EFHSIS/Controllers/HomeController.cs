using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFHSIS.Models;
using Microsoft.AspNetCore.Authorization;
using EFHSIS.Data;
using Microsoft.EntityFrameworkCore;
using EFHSIS.Models.EFHSISModels;
using Newtonsoft.Json;
using EFHSIS.AuthData;

namespace EFHSIS.Controllers
{
    [Authorize]
    [MyActionFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var child_graph = _context.ChildCareGraph.FromSqlRaw("EXEC EFHSIS.dbo.ChildCareGraph @date = N'2019-01-01',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(child_graph);
            return View();
        }

        public IActionResult ChildCare() {
            var child_graph = _context.ChildCareGraph.FromSqlRaw("EXEC EFHSIS.dbo.ChildCareGraph @date = N'2019-01-01',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(child_graph);
            return View();
        }

        public List<ChildCare> GetChildCare()
        {
            var childcare = _context.ChildCare.FromSqlRaw("EXEC [EFHSIS].[dbo].[GetChildCare];");
            return childcare.ToList();
        }

        public IActionResult envi_health() {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
