using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EFHSIS.Data;
using EFHSIS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFHSIS.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginDbContext _context;

        public LoginController(LoginDbContext context)
        {
            _context = context;
        }

        public object LoginTest()
        {
            var users = from m in _context.AspNetUsers
                         select m;
            users = users.Where(x => x.username.Equals("ruseltayongski"));

            return users.First();
        }
    

    }
}