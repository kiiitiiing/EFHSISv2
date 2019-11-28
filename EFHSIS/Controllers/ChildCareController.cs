using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHSIS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EFHSIS.Models.EFHSISModels;

namespace EFHSIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildCareController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChildCareController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getchildcare")]
        public List<ChildCare> GetChildCare()
        {
            var childcare = _context.ChildCare.FromSqlRaw("EXEC [EFHSIS].[dbo].[get_childcare];");

            return childcare.ToList();
        }
    }
}