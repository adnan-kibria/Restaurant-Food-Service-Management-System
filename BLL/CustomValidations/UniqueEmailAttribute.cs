using BLL.Services;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.CustomValidations
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var userService = (UserService)validationContext.GetService(typeof(UserService));
            var formEmail = (string)value;
            var data = userService.GetByEmail(formEmail);
            if (data == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Email is already exist");
        }
    }
}
