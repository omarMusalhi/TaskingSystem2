using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskingSystem2.Models;

namespace TaskingSystem2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Directorate> Directorate { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Section> Section { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
