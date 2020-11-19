using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed Roles
            builder.Entity<IdentityRole>().HasData
            (
                new IdentityRole
                {
                    Id = "ADMIN",
                    Name = "Admin",
                },
                new IdentityRole
                {
                    Id = "FINANCE_ADMIN",
                    Name = "Finance Admin",
                },
                new IdentityRole
                {
                    Id = "SALES_ADMIN",
                    Name = "Sales Admin",
                },
                new IdentityRole
                {
                    Id = "HR_ADMIN",
                    Name = "HR Admin",
                },
                new IdentityRole
                {
                    Id = "TECH_ADMIN",
                    Name = "Tech Admin",
                }
            );
        }
    }
}
