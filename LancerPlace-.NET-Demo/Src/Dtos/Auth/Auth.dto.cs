namespace LancerPlace_.NET_Demo.Src.Dtos;

public class CheckEmailDtoReq
{
    public string Email { get; set; } = null!;
}

public class CheckEmailDtoRes
{
    public bool IsExisting { get; set; }
}

public class VerifyPasswordDtoReq
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}
public class VerifyPasswordDtoRes
{
    public string AccessToken { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
}

public class RequestEmailOtpDtoReq
{
    public string Email { get; set; } = null!;
}

public class VerifyEmailOtpDtoReq
{
    public string Email { get; set; } = null!;
    public int Otp { get; set; }
}
public class VerifyEmailOtpDtoRes
{
    public bool IsVerified { get; set; }
}

public class RegisterDtoReq
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}

public class RefreshTokenDtoReq
{
    public string RefreshToken { get; set; } = null!;
}
public class RefreshTokenDtoRes
{
    public string AccessToken { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
}