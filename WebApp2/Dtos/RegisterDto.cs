using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using WebApp2.Dtos;


namespace WebApp2.Dtos
{
    public class RegisterDto : LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public User CreateUser()=>new User() { Username = this.Username, Email = this.Email, Password = this.Password };
        
    }
}