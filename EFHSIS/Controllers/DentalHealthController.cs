﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHSIS.AuthData;
using EFHSIS.Data;
using EFHSIS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EFHSIS.Controllers
{
    [Authorize]
    [MyActionFilter]
    public class DentalHealthController : Controller
    {
        private readonly ILogger<DentalHealthController> _logger;
        private readonly ApplicationDbContext _context;

        public DentalHealthController(ILogger<DentalHealthController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult DentalHome()
        {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);

            var child_graph = _context.ChildCareGraph.FromSqlRaw($"EXEC EFHSIS.dbo.ChildCareGraph @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(child_graph);
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            ViewBag.UserInfo = userInfo;
            return View();
        }

        [HttpPost]
        public IActionResult DentalHome(string filter)
        {
            var rx = new System.Text.RegularExpressions.Regex(" - ");
            var array = rx.Split(filter);
            var firstDay = array[0];
            var lastDay = array[1];
            var child_graph = _context.ChildCareGraph.FromSqlRaw($"EXEC EFHSIS.dbo.ChildCareGraph @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(child_graph);
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            ViewBag.UserInfo = userInfo;
            return View();
        }
    }
}