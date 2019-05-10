using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Common;
using Ghy.Core.EntityFramework.EntityModel;

namespace Ghy.Core.Web.Api.Models
{
    public class JwtTokenUtil
    {
        public string GetJwtBase64(user user)
        {
            DateTime UTC = DateTime.UtcNow;
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Name),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),//JWT ID,JWT的唯一标识
                new Claim(JwtRegisteredClaimNames.Iat,UTC.ToString(),ClaimValueTypes.Integer64),//Issud At
            };
            return null;
        }
    }
}
