using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserJWT.Services.Interfaces;

namespace UserJWT.Services.ServiceClasses
{
    public class TokenService : IToken
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GeneraterToken(string username, string isAdmin)
        {
            var jwtSetting = _configuration.GetSection("JwtSettings");
            var secretKey = Encoding.Unicode.GetBytes(jwtSetting["Token Key"]);
            Console.WriteLine(secretKey);
            var issuer = jwtSetting["Issuer"];


            var Claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim(ClaimTypes.Role, isAdmin),
            };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(Claims),
                Issuer = issuer,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha512Signature)

            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
