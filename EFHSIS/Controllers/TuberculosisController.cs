using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EFHSIS.AuthData;
using EFHSIS.Data;
using EFHSIS.Models;
using EFHSIS.Models.EFHSISModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static EFHSIS.Models.GraphModels.Graph;

namespace EFHSIS.Controllers
{
    [Authorize]
    [MyActionFilter]
    public class TuberculosisController : Controller
    {
        private readonly ILogger<TuberculosisController> _logger;
        private readonly ApplicationDbContext _context;

        public TuberculosisController(ILogger<TuberculosisController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult TuberculosisHome()
        {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            GraphFunc("TuberculosisGraph",firstDay,lastDay);
            return View();
        }

        [HttpPost]
        public IActionResult TuberculosisHome(string filter)
        {
            var rx = new System.Text.RegularExpressions.Regex(" - ");
            var array = rx.Split(filter);
            var firstDay = array[0];
            var lastDay = array[1];
            GraphFunc("TuberculosisGraph", Convert.ToDateTime(firstDay), Convert.ToDateTime(lastDay));
            return View();
        }

        public void GraphFunc(string stored_func, DateTime firstDay, DateTime lastDay)
        {
            var province = HttpContext.Session.GetString("province_id");
            var tuberculosis = _context.Tuberculosis.FromSqlRaw($"EXEC EFHSIS.dbo.{stored_func} @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'{province}';");
            var obj = tuberculosis.ToList().First();
            var pie_chart = new List<PieChart>();
            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.GetValue(obj) != null && property.Name != "Date" && property.Name != "max_data")
                {
                    pie_chart.Add(new PieChart
                    {
                        name = property.Name,
                        label = property.Name,
                        y = (int)property.GetValue(obj),
                        total = (int)property.GetValue(obj),
                        exploded = true
                    });
                }
            }
            ViewBag.pie_chart = JsonConvert.SerializeObject(pie_chart);

            var bar_chart = new List<BarChart>();
            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.GetValue(obj) != null && property.Name != "Date" && property.Name != "max_data")
                {
                    bar_chart.Add(new BarChart
                    {
                        label = property.Name,
                        y = (int)property.GetValue(obj)
                    });
                }
            }
            ViewBag.bar_chart = JsonConvert.SerializeObject(bar_chart);
        }

    }
}