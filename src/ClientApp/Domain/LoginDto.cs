using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ClientApp.Domain
{
    public class LoginDto
    {
        [Required]
        [Length(minimumLength:3, maximumLength:20)]
        public string Email { get; set; } = "";
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
        [DisplayName(displayName:"Remeber Me")]
        public bool RememberMe { get; set; }

        public List<Claim> ToClaims() => new (){
            //  new Claim(ClaimTypes.NameIdentifier, ) ,
             new Claim(ClaimTypes.Email, Email) ,
             new Claim(ClaimTypes.Name, Email) ,
             };
    }
}