﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.CustomValidators
{
    public class EmailDomainValidator : ValidationAttribute
    {
        public string AllowedDomain { get; set; }

        protected override ValidationResult IsValid( object value, ValidationContext validationContext )
        {
            string[] strings = value.ToString().Split( '@' );
            if(strings.Length > 1 && strings[1].ToString() == AllowedDomain.ToUpper())
            {
                return null;
            }

            return new ValidationResult( ErrorMessage,
                new[] { validationContext.MemberName } );
        }
    }
}
