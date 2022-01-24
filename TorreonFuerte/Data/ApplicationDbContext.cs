using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TorreonFuerte.Models;

namespace TorreonFuerte.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
       
        }
        public DbSet<TorreonFuerte.Models.Members> Members { get; set; }
    }
}
