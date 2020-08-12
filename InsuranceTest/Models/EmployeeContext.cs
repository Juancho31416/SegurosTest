using Microsoft.EntityFrameworkCore;
using System;

namespace InsuranceTest.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Uncle",
                LastName = "Bob",
                Email = "uncle.bob@gmail.com",
                DateOfBirth = new DateTime(1979, 04, 25),
                PhoneNumber = "999-888-7777"

            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Jan",
                LastName = "Kirsten",
                Email = "jan.kirsten@gmail.com",
                DateOfBirth = new DateTime(1981, 07, 13),
                PhoneNumber = "111-222-3333"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                id = 1,
                name = "Pedro perez",
                username = "pepe",
                address = "calle falsa 123",
                cellphone = "2222333455",
                password = "sdadsd445",
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
