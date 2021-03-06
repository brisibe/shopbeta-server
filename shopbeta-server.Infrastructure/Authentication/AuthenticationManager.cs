using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using shopbeta.Core.DTO;
using shopbeta.Core.Interfaces;
using shopbeta.Core.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace shopbeta_server.Infrastructure.Authentication
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private User _user;

        public AuthenticationManager(UserManager<User> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<bool> ValidateUser(UserAuthenticationDto userrAuth)
        {
            _user = await _userManager.FindByEmailAsync(userrAuth.Email);
            return (_user != null && await _userManager.CheckPasswordAsync(_user, userrAuth.Password));
        }

        public async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }



        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_configuration.GetSection("SECRET").Value ?? throw new ArgumentNullException("secret is null"));
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName),
                new Claim ("Email", _user.Email),
                new Claim("sub", _user.Id),
                new Claim(ClaimTypes.Role, _user.Role)

            };

            //var roles = await _userManager.GetRolesAsync(_user);



            if (_user.Role == "Seller")
            {
                claims.Add(new Claim("Store", _user.StoreName));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {

            var tokenOptions = new JwtSecurityToken(
                  issuer: _configuration.GetSection("jwt_validIssuer").Value,
                  audience: _configuration.GetSection("jwt_validAudience").Value,
                  claims: claims,
                  expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration.GetSection("jwt_expires").Value)),
                  signingCredentials: signingCredentials

                  );
            return tokenOptions;

        }
    }
}
