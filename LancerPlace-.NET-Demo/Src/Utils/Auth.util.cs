using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace LancerPlace_.NET_Demo.Src.Utils;

public class Payload
{
    public Guid UserId { get; set; }
    public Role Role { get; set; }
}
public class AuthUtil(IConfiguration configuration)
{
    private readonly IConfigurationSection _jwt =
        configuration.GetSection("Jwt");

    public string IssueToken(Payload payload)
    {
        var claims = new List<Claim> {
            new("role", payload.Role.ToString()),
            new("userId", payload.UserId.ToString()),
        };
        var secret = _jwt["Secret"] ?? throw new InvalidOperationException("Jwt Secret Not Found!");
        var expirationMinutes = _jwt.GetValue<int>("ExpirationMinutes");
        var secretBytes = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        var credentials = new SigningCredentials(secretBytes, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(expirationMinutes),
            signingCredentials: credentials
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}