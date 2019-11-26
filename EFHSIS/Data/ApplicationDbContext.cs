using System;
using System.Collections.Generic;
using System.Text;
using EFHSIS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFHSIS.Data
{
    public class ApplicationDbContext : IdentityDbContext<User,IdentityRole<int>,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
