﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync( )
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees( )
        {
            Employee e1 = new Employee
            {
                EmployeeId = 101,
                FirstName = "Mello",
                LastName = "Sky",
                Email = "Mello@munchinOG.com",
                DateOfBirth = new DateTime( 1988, 08, 2 ),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "HR" },
                PhotoPath = "images/mello.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 102,
                FirstName = "Kate",
                LastName = "Utibe",
                Email = "Kate@munchinOG.com",
                DateOfBirth = new DateTime( 1980, 05, 11 ),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/kate.png"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 103,
                FirstName = "Queen",
                LastName = "John",
                Email = "Queen@munchinOG.com",
                DateOfBirth = new DateTime( 1990, 05, 12 ),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Payroll" },
                PhotoPath = "images/queen.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@munchinOG.com",
                DateOfBirth = new DateTime( 1981, 12, 22 ),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "IT" },
                PhotoPath = "images/sam.jpg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}