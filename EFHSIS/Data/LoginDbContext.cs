using EFHSIS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFHSIS.Data
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetUsers> AspNetUsers { get; set; }
    }
}
