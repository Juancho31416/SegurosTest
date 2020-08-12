using Microsoft.EntityFrameworkCore;
using System;

namespace InsuranceTest.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions UserContext)
            : base(UserContext)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                id = 1,
                name = "Pedro perez",
                username = "pepe",
                address ="calle falsa 123",
                cellphone ="2222333455",
                password="sdadsd445",
            }, new User
            {
                id = 2,
                name = "Pablo perez",
                username = "pablito",
                address = "calle falsa 1234",
                cellphone = "2222333455",
                password = "sdadsd345",
            });
        }
    }
}
