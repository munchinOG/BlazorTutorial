﻿using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required( ErrorMessage = "FirstName must be provided" )]
        [MinLength( 2 )]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        [EmailDomainValidator( AllowedDomain = "munchin.com",
            ErrorMessage = "Only Munchin.com is allowed" )]
        public string Email { get; set; }

        [CompareProperty( "Email", ErrorMessage = "Email and Confirm Email must match" )]
        public string ConfirmEmail { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        [Required]
        public int? DepartmentId { get; set; }

        public string PhotoPath { get; set; }
        public Department Department { get; set; }
    }
}
