using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.FrelancerProfiles.Freelancer;

public class FreelancerProfileInfoDtoRes
{
    public class SkillType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
    }
    public class CVType
    {
        public bool IsPublic { get; set; }
        public FileDtoRes? File { get; set; } = null!;
    }
    public string? bio { get; set; } = null!;
    public List<SkillType> Skills { get; set; } = [];
    public CVType? Cv { get; set; } = null!;
}

public class UpdateFreelancerProfileInfoDtoReq
{
    public class SkillType
    {
        public Guid? Id { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
    public string? bio { get; set; } = null!;
    public List<SkillType> Skills { get; set; } = [];
}
public class UpdateCVDtoReq
{
    public FileDtoReq NewCV { get; set; } = null!;
}