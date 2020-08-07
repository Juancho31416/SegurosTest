using Microsoft.EntityFrameworkCore;
using System;

namespace InsuranceTest.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Insurance> Insurances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Insurance>().HasData(new Insurance
            {
                id= 1,
                description = "este es de prueba",
                price = 1233444,
                coverageInit= new DateTime(1979, 04, 25),
                coverageTime = 12,
                riskType = "alto",

            }, new Insurance
            {
                id = 1,
                description = "este es de prueba tambien",
                price = 1233444,
                coverageInit = new DateTime(1999, 04, 25),
                coverageTime = 48,
                riskType = "medio",
            });
        }
    }
}
