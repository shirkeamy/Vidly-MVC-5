using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Models
{
    public class AgeValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId==1)
                return ValidationResult.Success;
            if(customer.DateOfBirth==null)
                return new ValidationResult("BirthDate is required");

            var age = DateTime.Now.Year - customer.DateOfBirth.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be 18 Years old!");

        }
    }
}