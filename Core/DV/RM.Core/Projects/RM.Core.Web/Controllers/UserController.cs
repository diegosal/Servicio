using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RM.Core.Client;
using RM.Core.Web.Entities.Views;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using RM.Common;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;

namespace RM.Core.Web.Controllers
{
    [Authorize]
    [Route("api/User")]
    public class UserController : Controller
    {
        private WebClient client = new WebClient();

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<TokenUser> LogInAsync([FromBody]WebUser webUser)
        {
            try {
                WebUser user = null;
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(ConstString.Secret);

                user = await client.PostAsync<WebUser, WebUser>(webUser, @"http://localhost:6235/api/User/LogIn");

                if (user == null)
                    return null;

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                var tokenString = tokenHandler.WriteToken(token);

                return new TokenUser {
                    Id = user.Id,
                    UserName = user.Email,
                    Name = user.UserName + " " + user.UserMiddleName + " " + user.UserLastName + " " + user.UserMotherName,
                    Token = tokenString,
                };
            }
            catch (Exception ex) {
                int a = 0;
                return null;
            }
        } 

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<string> RegisterAsync([FromBody]WebUser webUser)
        {

            string result = "";

            result = await client.PostAsync<string, WebUser>(webUser, @"http://localhost:6235/api/User/Register");
            return result;
        }
    }
}