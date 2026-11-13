
namespace LancerPlace_.NET_Demo.Src.Utils;
public class SecurityUtils
{
    public string Hash(string value)
    {
        return BCrypt.Net.BCrypt.HashPassword(value);
    }
    public bool VerifyHash(string value, string hashedValue)
    {
        return BCrypt.Net.BCrypt.Verify(value, hashedValue);
    }
}