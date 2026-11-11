using LancerPlace.NET.Demo.Src.Enums;
using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Users.User;

public class UserInfoDtoRes
{
    public Guid Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null!;
    public FileDtoRes? Avatar { get; set; } = null!;
    public Role Role { get; set; }

}
public class UpdateUserInfoReq
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null!;

}
public class UpdateUserAvatarDtoReq
{
    public FileDtoReq NewAvatar { get; set; } = null!;

}