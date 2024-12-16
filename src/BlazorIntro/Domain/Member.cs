using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Antiforgery;

namespace BlazorIntro.Domain
{
    public class Member
    {
        public const string EmailRegEx =
"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(100, ErrorMessage = "No more than 100 characters")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression(EmailRegEx, ErrorMessage = "Invalid email address")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Password is mandatory")]
        [StringLength(maximumLength: 100, MinimumLength = 5,
            ErrorMessage = "Passwords should be at least 5 long, an no more that 100")]
        public required string Password { get; set; }
        public string Message { get; set; } = string.Empty;
        public required string Country { get; set; }
        public bool Subscriber { get; set; }
        public Gender Gender { get; set; }
    }
}