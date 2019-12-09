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
    public class MortalityController : Controller
    {
        private readonly ILogger<MortalityController> _logger;
        private readonly ApplicationDbContext _context;

        public MortalityController(ILogger<MortalityController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public IActionResult MortalityHome()
        {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);

            var consolidated = _context.Consolidated.FromSqlRaw($"EXEC EFHSIS.dbo.Consolidated @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(consolidated);
            ViewBag.UserInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            return View();
        }
        [HttpPost]
        public IActionResult MortalityHome(string filter)
        {
            var rx = new System.Text.RegularExpressions.Regex(" - ");
            var array = rx.Split(filter);
            var firstDay = array[0];
            var lastDay = array[1];
            var consolidated = _context.Consolidated.FromSqlRaw($"EXEC EFHSIS.dbo.Consolidated @date_start = N'{firstDay}',@date_end = N'{lastDay}',@prov_code = N'CEBU';");
            ViewBag.DataPoints = JsonConvert.SerializeObject(consolidated);
            ViewBag.UserInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            return View();
        }

    }
}