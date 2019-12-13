using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFHSIS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EFHSIS.Models.EFHSISModels;
using EFHSIS.Models.GraphModels;

namespace EFHSIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildCareController1 : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ChildCareController1(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getchildcare")]
        public List<ChildCare> GetChildCare()
        {
            var childcare = _context.ChildCare.FromSqlRaw("EXEC EFHSIS.dbo.GetChildCare @bgy_code = N'Poblacion Oriental';");
            return childcare.ToList();
        }

        [HttpGet]
        [Route("childcaregraph")]
        public List<ChildCareGraph> ChildCareGraph()
        {
            var child_graph = _context.ChildCareGraph.FromSqlRaw("EXEC EFHSIS.dbo.ChildCareGraph @date = N'2019-01-01',@prov_code = N'CEBU';");
            
            return child_graph.ToList();
        }

    }
}