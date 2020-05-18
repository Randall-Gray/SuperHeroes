using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeroes.Models;

namespace SuperHeroes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
    
        }
    }
}
