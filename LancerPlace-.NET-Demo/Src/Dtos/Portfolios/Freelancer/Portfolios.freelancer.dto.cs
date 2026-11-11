using LancerPlace_.NET_Demo.Src.Dtos.File;

namespace LancerPlace_.NET_Demo.Src.Dtos.Portfolios.Freelancer;

public class PortfolioListItemDtoRes
{
    public class PosterType
    {
        public string Url { get; set; } = null!;
    }
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public PosterType? Poster { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string CreatedAt { get; set; } = null!;
}

public class PortfolioDetailDtoRes
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsPublic { get; set; }
    public List<FileDtoRes> Images { get; set; } = [];
}

public class CreatePortfolioDtoReq
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsPublic { get; set; }
    public List<FileDtoReq?> Images { get; set; } = [];
};
public class UpdatePortfolioDtoReq
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsPublic { get; set; }
    public List<FileDtoReq?> Images { get; set; } = [];
};