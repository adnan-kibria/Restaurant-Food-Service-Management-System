using BLL.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs
{
    public class RegistrationDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{11}", ErrorMessage = "Phone number must be 11 digit long")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email must follow the format (example@example.com)")]
        [UniqueEmail]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        public string AddressLine { get; set; } = null!;

        [Required(ErrorMessage = "Area is required")]
        public string Area { get; set; } = null!;

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[#@!%&$+*])[a-zA-Z\d#@!%&$+*]{8,}$", 
            ErrorMessage = "Password must be at least 8 characters long and contain an uppercase letter, a digit, and special character")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Confirm password is required")]
        [MatchPassword]
        public string ConfirmPassword { get; set; } = null!;

        [Required(ErrorMessage = "Please select a role")]
        public int RoleId { get; set; }

        public int StatusId { get; set; }
    }
}
