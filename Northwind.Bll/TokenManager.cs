using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Northwind.Entity.Dto;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //token uretme metodu
        public string CreateAccessToken(DtoLoginUser user)
        {
            //Claim olusturma
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserCode),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserID.ToString())
            };

            var claimsIdentitiy = new ClaimsIdentity(claims, "Token");

            //Rollerin olusturulmasi

            var claimsRoleList = new List<Claim> 
            {
                new Claim("role", "Admin"),
                //new Claim("role2", "")
            };

            //Security key'in simetrigini aliyoruz

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]));

            //Sifreli kimlik olusturma (sign in credential)

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //Token ayarlari (expire suresi vs.)

            var token = new JwtSecurityToken
                (
                    issuer: configuration["Tokens: Issuer"], //token dagitici url (issuer girmek zorunlu degil)
                    audience: configuration["Tokens:Issuer"], //erisilebilecek api'lerin bilgileri. Burada issuer'a karsilik geliyor. Hangi api'lerde calisacagini soyluyoruz
                    expires: DateTime.Now.AddMinutes(5), //token'in omru 5 dk
                    notBefore: DateTime.Now, //token uretildikten sonra ne kadar sure sonra devreye girecek? Hemen devreye girecekse DateTime.Now
                    signingCredentials: cred,
                    claims: claimsIdentitiy.Claims
                );

            //Token olusturma sinifiyla bir ornek alinip token uretme
            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            return tokenHandler.token;
        }
    }
}
