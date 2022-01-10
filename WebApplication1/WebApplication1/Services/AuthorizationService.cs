using DeviceManagerBackend.Entities;
using DeviceManagerBackend.Models;
using DeviceManagerBackend.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DeviceManagerBackend.Services
{
    public class AuthorizationService
    {
        public IUserRepository _userRepo;

        public AuthorizationService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public string AuthorizeUser(string emailAddress, string password)
        {
            var user = _userRepo.GetUserByEmailAddress(emailAddress);
            if (password.Equals(user.Password))
            {
                return GetJwt(user);
            }
            return null;
        }

        private string GetJwt(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var secret = "702adff5-1835-42ab-b262-79115400488c";

            var key = Encoding.ASCII.GetBytes(secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {

                    new Claim(ClaimTypes.Email, user.EmailAddress),
                    new Claim(ClaimTypes.Role, user.Role.ToString()),
                    new Claim("SpaceList",string.Join(",", user.Spaces.Select(x => x.Name)))
                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
