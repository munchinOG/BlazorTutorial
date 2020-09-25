using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagement.Api.EF
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext( DbContextOptions<EmployeeDbContext> options )
            : base( options )
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            base.OnModelCreating( modelBuilder );

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 201, DepartmentName = "IT" } );
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 202, DepartmentName = "HR" } );
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 203, DepartmentName = "Payroll" } );
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 204, DepartmentName = "Admin" } );

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData( new Employee
            {
                EmployeeId = 101,
                FirstName = "Mello",
                LastName = "Sky",
                Email = "Mello@munchinOG.com",
                DateOfBirth = new DateTime( 1988, 08, 2 ),
                Gender = Gender.Male,
                DepartmentId = 201,
                PhotoPath = "images/mello.png"
            } );

            modelBuilder.Entity<Employee>().HasData( new Employee
            {
                EmployeeId = 102,
                FirstName = "Kate",
                LastName = "Utibe",
                Email = "Kate@munchinOG.com",
                DateOfBirth = new DateTime( 1980, 05, 11 ),
                Gender = Gender.Female,
                DepartmentId = 202,
                PhotoPath = "images/kate.png"
            } );

            modelBuilder.Entity<Employee>().HasData( new Employee
            {
                EmployeeId = 103,
                FirstName = "Queen",
                LastName = "John",
                Email = "Queen@munchinOG.com",
                DateOfBirth = new DateTime( 1990, 05, 12 ),
                Gender = Gender.Female,
                DepartmentId = 203,
                PhotoPath = "images/queen.png"
            } );

            modelBuilder.Entity<Employee>().HasData( new Employee
            {
                EmployeeId = 104,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@munchinOG.com",
                DateOfBirth = new DateTime( 1981, 12, 22 ),
                Gender = Gender.Male,
                DepartmentId = 204,
                PhotoPath = "images/sam.png"
            } );
        }
    }
}
