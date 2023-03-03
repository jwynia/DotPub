using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DotPub.DataContracts.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DotPub.WebApi.Controllers;

[ApiController]
[Route("//api/v1/users")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _config;

    public AuthController(IConfiguration config)
    {
        _config = config;
    }

    [HttpPost]
    [Route("token")]
    public IActionResult CreateToken(TokenRequest tokenRequest)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

        //If you've had the login module, you can also use the real user information here
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, tokenRequest.client_id),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(_config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims,
            expires: DateTime.Now.AddMinutes(120),
            signingCredentials: credentials);

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        return Content(tokenString);
    }
}