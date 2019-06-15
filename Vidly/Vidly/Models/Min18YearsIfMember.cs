using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var custeomer = (Customer)validationContext.ObjectInstance;
            if (custeomer.MemberId == 5) {
                return ValidationResult.Success;
            }
            
            return null;
        }
    }
}