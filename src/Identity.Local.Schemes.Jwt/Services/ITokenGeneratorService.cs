using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Identity.Local.Schemes.Jwt.Models;
using Identity.Local.Schemes.Jwt.Models.Entities;

namespace Identity.Local.Schemes.Jwt.Services;

public interface ITokenGeneratorService
{
    string GetToken(User user);

    JwtSecurityToken GetJwtToken(User user);

    List<Claim> GetClaims(User user);
}