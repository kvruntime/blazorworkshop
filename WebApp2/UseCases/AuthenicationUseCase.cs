using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

using WebApp2.Data;
using WebApp2.Dtos;

namespace WebApp2.UseCases
{
    public class AuthenicationUseCase
    {
        private readonly AppDbContext _context;
        public AuthenicationUseCase(AppDbContext context)
        {
            _context = context;
        }
        public async Task<(string message, bool create)> Register(RegisterDto dto)
        {

            try
            {
                dto.Password = BCrypt.Net.BCrypt.HashPassword(dto.Password);
                await _context.Users.AddAsync(dto.CreateUser());
                await _context.SaveChangesAsync();
                return ("created", true);
            }
            catch (Exception ex)
            {
                return (ex.Message, false);
            }
        }

        public async Task<(string message, ClaimsPrincipal? principal)> Login(LoginDto dto, string scheme)
        {
            var existingUser = await _context.Users.Where(u => u.Username == dto.Username).FirstOrDefaultAsync();
            if (existingUser is null) return ("user not found", null);
            if (!BCrypt.Net.BCrypt.Verify(dto.Password, existingUser.Password)) return ("invalid credential", null);

            ClaimsIdentity identity = new ClaimsIdentity(new List<Claim>(){
                new Claim(ClaimTypes.Name, existingUser.Username),
                new Claim(ClaimTypes.Email, existingUser.Email),
            }, scheme);

            // TODO: add policies

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            return ("success", principal);
        }
    }
}