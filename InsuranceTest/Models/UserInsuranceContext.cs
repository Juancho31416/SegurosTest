using Microsoft.EntityFrameworkCore;
using System;

namespace InsuranceTest.Models
{
    public class UserInsuranceContext : DbContext
    {
        public UserInsuranceContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<UserInsurance> UserInsurances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInsurance>().HasData(new UserInsurance
            {
                userid = 1,
                insuranceid= 2

            }, new UserInsurance
            {
                userid = 1,
                insuranceid = 1
            }, new UserInsurance
            {
                userid = 2,
                insuranceid = 1
            }, new UserInsurance
            {
                userid = 2,
                insuranceid = 2
            }

            );
        }
    }
}
