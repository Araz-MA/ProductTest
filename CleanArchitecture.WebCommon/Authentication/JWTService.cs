using CleanArchitecture.Application.Common.Interfaces.IAuthentication;
using CleanArchitecture.Domain.Entities.IdentityEntities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanArchitecture.WebCommon.Authentication
{
    public class JWTService : IJWTService
    {
        public string GenerateToken(User user)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my custom Secret key for authentication"));            
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256Signature); 
            var claims = _getClams(user);

            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = "dfghjfghjfg",
                Audience = "dfghjfghjfg",
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now.AddMinutes(2),
                Expires = DateTime.Now.AddMinutes(2),
                SigningCredentials = signingCredentials,               
                Subject = new ClaimsIdentity(claims)
            };

            // برای جلوگیری از تبدیل کلیم های دات نت به کلیم های جی دبلیو تی
            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            //JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
            //JwtSecurityTokenHandler.DefaultOutboundClaimTypeMap.Clear();

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateJwtSecurityToken(descriptor);
            string encryptedJwt = tokenHandler.WriteToken(securityToken);
            return encryptedJwt;
        }
        private IEnumerable<Claim> _getClams(User user)
        {
            var claimList = new List<Claim>();
            claimList.Add(new Claim(ClaimTypes.Name, user.UserName));
            claimList.Add(new Claim(ClaimTypes.MobilePhone, user.PhoneNumber));
            return claimList;
        }
    }
}
