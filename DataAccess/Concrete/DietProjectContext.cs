using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class DietProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DietProject;Trusted_Connection=true");
        }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<PatientReport> PatientReports { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }
        public DbSet<City> Citys { get; set; }
    }
}
