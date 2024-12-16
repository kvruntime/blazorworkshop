using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace blazorcustomauth.Models
{
    public record LoggedUserDto(int Id, string Name, string Email)
    {
        public Claim[] ToClaims() => new Claim[] { 
            new Claim(ClaimTypes.NameIdentifier, this.Id.ToString()),
            new Claim(ClaimTypes.Email, this.Email),
            new Claim(ClaimTypes.Name, this.Name),
        };

    }


}