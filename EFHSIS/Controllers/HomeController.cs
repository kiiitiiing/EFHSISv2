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
using Microsoft.AspNetCore.Http;

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

        [HttpGet]
        public IActionResult Index()
        {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);

            var consolidated = _context.Consolidated.FromSqlRaw($"EXEC EFHSIS.dbo.Consolidated @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(consolidated);

            var userinfo = new UserInfo() { UserId = 1,UserName = "John Doe" };
            HttpContext.Session.SetString("SessionUser",JsonConvert.SerializeObject(userinfo));

            return View();
        }

        [HttpPost]
        public IActionResult Index(String filter)
        {
            var rx = new System.Text.RegularExpressions.Regex(" - ");
            var array = rx.Split(filter);
            var firstDay = array[0];
            var lastDay = array[1];
            var consolidated = _context.Consolidated.FromSqlRaw($"EXEC EFHSIS.dbo.Consolidated @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(consolidated);
            return View();
        }

        [HttpGet]
        public IActionResult ChildCare() {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);

            var child_graph = _context.ChildCareGraph.FromSqlRaw($"EXEC EFHSIS.dbo.ChildCareGraph @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(child_graph);
            return View();
        }

        [HttpPost]
        public IActionResult ChildCare(string filter)
        {
            var rx = new System.Text.RegularExpressions.Regex(" - ");
            var array = rx.Split(filter);
            var firstDay = array[0];
            var lastDay = array[1];
            var child_graph = _context.ChildCareGraph.FromSqlRaw($"EXEC EFHSIS.dbo.ChildCareGraph @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(child_graph);
            return View();
        }

        public List<DentalHealth> dentalhealth()
        {
            var dental_health = _context.DentalHealth
                                      .Where(s => s.ProvCode == "cebu")
                                      .ToList();
            return dental_health;
        }

        public object TestFunc() {
            var dictionary = new Dictionary<string, object>();
            var dictionary1 = new Dictionary<string, object>();
            dictionary1.Add("soccer", "Ronaldo Christiano");
            dictionary1.Add("boxing", "Manny Pacquiao");

            dictionary.Add("fname", dictionary1);
            dictionary.Add("mname", "tamayo");
            dictionary.Add("lname", "tayong");

            return dictionary;
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
