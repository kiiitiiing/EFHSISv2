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

        public List<AspNetUsers> LoginTest()
        {
            var users = from m in _context.AspNetUsers
                         select m;
            users = users.Where(x => x.username.Equals("ruseltayongski"));

            return users.ToList();
        }

        public static byte[] GetHash(string password, string salt)
        {
            byte[] unhashedBytes = Encoding.Unicode.GetBytes(String.Concat(salt, password));

            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashedBytes = sha256.ComputeHash(unhashedBytes);

            return hashedBytes;
        }

        public static bool CompareHash(string attemptedPassword, byte[] hash, string salt)
        {
            string base64Hash = Convert.ToBase64String(hash);
            string base64AttemptedHash = Convert.ToBase64String(GetHash(attemptedPassword, salt));

            return base64Hash == base64AttemptedHash;
        }

    }
}