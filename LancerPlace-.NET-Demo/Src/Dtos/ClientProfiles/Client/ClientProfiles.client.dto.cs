namespace LancerPlace_.NET_Demo.Src.Dtos.ClientProfiles.Client;

public class ClientProfileInfoDtoRes
{
    public class PreferenceType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
    }
    public string? Bio { get; set; } = null!;
    public List<PreferenceType> Preferences { get; set; } = [];
}
public class UpdateClientProfileDtoReq
{
    public class PreferenceType
    {
        public Guid? Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
    public string? Bio { get; set; } = null!;
    public List<PreferenceType> Preferences { get; set; } = [];
}