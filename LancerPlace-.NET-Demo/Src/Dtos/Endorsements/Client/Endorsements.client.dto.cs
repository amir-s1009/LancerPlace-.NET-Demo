namespace LancerPlace_.NET_Demo.Src.Dtos.Endorsements.Client;

public class CreateEndorsementDtoReq
{
    public class EndorsementType
    {
        public string Description { get; set; } = null!;
    }
    public string ApplicationId { get; set; } = null!;
    public EndorsementType Endorsement { get; set; } = null!;
}