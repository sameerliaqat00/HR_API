﻿using HR_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HR_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<LoanEligibleMonth> LoanEligibleMonths { get; set; }
        public DbSet<RegularizedPeriod> RegularizedPeriods { get; set; }
        public DbSet<SalaryMethod> SalaryMethods { get; set; }
        public DbSet<WorkLocation> WorkLocations { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<SubDepartment> SubDepartments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<EmployeeGrade> EmployeeGrades { get; set; }
    }
}
