using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PEV.Models.AccountViewModels;
using PEV.Models.ManageViewModels;

namespace PEV.Models
{
    public class ApplicationDbContext : DbContext
    {

        /*
         * ===========================
         * AUTH start
         * ===========================
         */
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; set; }
        public DbSet<IdentityUserRole<string>> IdentityUserRoles { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        public DbSet<IdentityUserLogin<string>> IdentityUserLogins { get; set; }
        /*
         * ===========================
         * AUTH end
         * ===========================
         */

        public DbSet<Paardenrace> Paardenraces { get; set; }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //auth start
            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasKey(c => new { c.UserId });

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(c => new { c.UserId });
            //auth end

            modelBuilder.Entity<Paardenrace>()
                .HasKey(c => new { c.gameid, c.userid });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=luukwuijster.io;database=pev;uid=pev;pwd=pev123;");
    }
}
